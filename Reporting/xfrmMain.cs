using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.LookAndFeel;
using Reporting.RaporteStoc;
using System.Data.SqlClient;
using Reporting.DepozitLayout;

namespace Reporting
{
    public partial class xfrmMain : RibbonForm
    {
        public xfrmMain()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        private bool UpdateStructuraBd()
        {
            if (!Reporting.CnxManager.CheckLocalConnection())
            {
                MessageBox.Show("Conexiunea la baza de date locala nu este posibila. Verificati setarile.");
                return false;
            }
            try
            {

                string pasEroare = "";
                using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.MRPConnectionString))
                {
                    try
                    {
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("", cnx);

                        pasEroare = "1.1.1";
                        #region Creare Schema: Stoc
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'stoc')\n"
                                    + "EXEC sys.sp_executesql N'CREATE SCHEMA [stoc]'\n";

                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.1.2";
                        #region Creare Tabel: [stoc].[StocRetro]
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[stoc].[StocRetro]') AND type in (N'U'))\n"
                               + "BEGIN\n"
                               + "CREATE TABLE [stoc].[StocRetro](\n"
                               + "	[CodProdus] [int] NULL,\n"
                               + "	[IdGestiune] [int] NULL,\n"
                               + "	[Data] [date] NULL,\n"
                               + "	[SI] [money] NULL,\n"
                               + "	[SF] [money] NULL,\n"
                               + "	[D] [money] NULL,\n"
                               + "	[C] [money] NULL\n"
                               + ") ON [PRIMARY]\n"
                               + "END\n";

                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.1.3";
                        #region Creare Tabel: [stoc].[AlerteStocType1]
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[stoc].[AlerteStocType1]') AND type in (N'U'))\n"
                                   + "BEGIN\n"
                                   + "CREATE TABLE [stoc].[AlerteStocType1](\n"
                                   + "	[ID] [int] IDENTITY(1,1) NOT NULL,\n"
                                   + "	[CodProdus] [int] NULL,\n"
                                   + "	[IdGestiune] [int] NULL,\n"
                                   + "	[Stoc] [money] NULL,\n"
                                   + "	[GestiuniCuStoc] [varchar](200) NULL,\n"
                                   + " CONSTRAINT [PK_AlerteStocType1] PRIMARY KEY CLUSTERED \n"
                                   + "(\n"
                                   + "	[ID] ASC\n"
                                   + ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\n"
                                   + ") ON [PRIMARY]\n"
                                   + "END\n";

                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.1.4";
                        #region Creare Functie: udf_GetGestiuni
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[stoc].[udf_GetGestiuni]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))\n"
                                        + "BEGIN\n"
                                        + "execute dbo.sp_executesql @statement = N'CREATE FUNCTION [stoc].[udf_GetGestiuni](@CodProdus int)\n"
                                        + "RETURNS VARCHAR(200) AS\n"
                                        + "\n"
                                        + "BEGIN\n"
                                        + "   DECLARE @ListaGestiuni varchar(200)\n"
                                        + "\n"
                                        + "   SELECT @ListaGestiuni = COALESCE(@ListaGestiuni + '','', '''', '''''''') + g.DenumireGestiune + ''('' + convert(varchar, s.Cantitate) + '') ''\n"
                                        + "   FROM (Stocuri s INNER JOIN Gestiune g  ON s.IdGestiune = g.IdGestiune) \n"
                                        + "   WHERE (s.CodProdus = @CodProdus and s.Cantitate <> 0) \n"
                                        + "\n"
                                        + "   RETURN @ListaGestiuni\n"
                                        + "END\n"
                                        + "\n"
                                        + "' \n"
                                        + "END\n";
                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.1.5";
                        #region Creare SP: CalculStocRetro
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CalculStocRetro]') AND type in (N'P', N'PC'))\n"
                                       + "BEGIN\n"
                                       + "EXEC dbo.sp_executesql @statement = N'\n"
                                       + "CREATE PROCEDURE [dbo].[CalculStocRetro]\n"
                                       + "	(@AllProducts bit, @ColumnFilterName varchar(50), @ColumnFlterValue int, @DaysRetro int, @ActivateArrayFiltruIdDoc bit = false, @NrZileOffset int = 0)\n"
                                       + "AS\n"
                                       + "BEGIN\n"
                                       + "\n"
                                       + "	SET NOCOUNT ON;\n"
                                       + "\n"
                                       + "	Declare @DataStart date\n"
                                       + "	SET @DataStart = CONVERT(date, getdate())\n"
                                       + "	SET @DataStart = DATEADD(day,-1 * @NrZileOffset, @DataStart)\n"
                                       + "	print convert (varchar,@datastart)\n"
                                       + "	Declare @NrZileCalculate int\n"
                                       + "	SET @NrZileCalculate = 0\n"
                                       + "\n"
                                       + "	Declare @CodProdusCurent int\n"
                                       + "	Declare @IdGestiuneCurent int\n"
                                       + "	Declare @DataCurent date\n"
                                       + "\n"
                                       + "	Declare @SF_Azi_CodProdusGestiune money\n"
                                       + "	SET @SF_Azi_CodProdusGestiune = 0\n"
                                       + "\n"
                                       + "	Declare @Row_CodProdus int\n"
                                       + "	Declare @Row_IdGestiune int\n"
                                       + "	Declare @Row_Data date\n"
                                       + "	Declare @Row_SI money\n"
                                       + "	Declare @Row_SF money\n"
                                       + "	Declare @Row_D money\n"
                                       + "	Declare @Row_C money\n"
                                       + "\n"
                                       + "\n"
                                       + "	CREATE TABLE #Gestiuni (IdGestiune int)\n"
                                       + "	INSERT INTO #Gestiuni SELECT IdGestiune  FROM Gestiune\n"
                                       + "\n"
                                       + "\n"
                                       + "		DECLARE ccProduse CURSOR FOR SELECT DISTINCT CodProdus FROM Stocuri WHERE IdGestiune <> 1 AND Cantitate IS NOT NULL ORDER BY CodProdus\n"
                                       + "			OPEN ccProduse   \n"
                                       + "			FETCH NEXT FROM ccProduse INTO @CodProdusCurent   \n"
                                       + "			\n"
                                       + "			WHILE @@FETCH_STATUS = 0   \n"
                                       + "			BEGIN   \n"
                                       + "				DECLARE ccGestiuni SCROLL CURSOR FOR SELECT IdGestiune FROM Gestiune\n"
                                       + "				OPEN ccGestiuni\n"
                                       + "				FETCH NEXT FROM ccGestiuni INTO  @IdGestiuneCurent 				\n"
                                       + "			\n"
                                       + "				WHILE @@FETCH_STATUS = 0\n"
                                       + "					BEGIN\n"
                                       + "						SET @NrZileCalculate = 0\n"
                                       + "						WHILE  @NrZileCalculate <= @DaysRetro\n"
                                       + "							BEGIN\n"
                                       + "								--scriu valori de insert variabile\n"
                                       + "								SET @Row_CodProdus = @CodProdusCurent\n"
                                       + "								SET @Row_IdGestiune = @IdGestiuneCurent\n"
                                       + "								SET @Row_Data = DATEADD(day,-1 * (@NrZileCalculate + 1), @DataStart)\n"
                                       + "								--SET @Row_Data = cONVERT(DATE, GETDATE())\n"
                                       + "								SET @Row_SI = 1\n"
                                       + "								SET @Row_SF = 2\n"
                                       + "								SET @Row_D = 4\n"
                                       + "								SET @Row_C = 6\n"
                                       + "\n"
                                       + "								--determin SF pentru produs/gestiune pe ziua curenta de calcul, daca e prima zi il extrag din baza de date din tabel stocuri (ca si stoc curent)\n"
                                       + "								IF @NrZileCalculate = 0 \n"
                                       + "									BEGIN\n"
                                       + "										SET @Row_SF = (SELECT Cantitate FROM Stocuri WHERE IDGestiune = @IdGestiuneCurent AND CodProdus = @CodProdusCurent)\n"
                                       + "									END\n"
                                       + "								ELSE\n"
                                       + "									BEGIN\n"
                                       + "										SET @Row_SF = @SF_Azi_CodProdusGestiune\n"
                                       + "									END\n"
                                       + "								--calculez rulaj D si Rulaj C pentru ziua curenta\n"
                                       + "								SET @Row_D = ISNULL((\n"
                                       + "											SELECT Sum (DetaliiFactura.Cantitate) FROM DetaliiFactura INNER JOIN Factura ON Factura.IDFactura = DetaliiFactura.IDFactura \n"
                                       + "											WHERE Factura.Anulat = 0 AND TipOperatie IN (0,3) \n"
                                       + "												AND DetaliiFactura.IDGestiune = @IdGestiuneCurent AND DetaliiFactura.CodProdus = @CodProdusCurent AND Factura.Data = @Row_Data\n"
                                       + "											),0)\n"
                                       + "								SET @Row_C = ISNULL((\n"
                                       + "											SELECT Sum (DetaliiFactura.Cantitate) FROM DetaliiFactura INNER JOIN Factura ON Factura.IDFactura = DetaliiFactura.IDFactura \n"
                                       + "											WHERE Factura.Anulat = 0 AND TipOperatie IN (1,2,4,7) \n"
                                       + "												AND DetaliiFactura.IDGestiune = @IdGestiuneCurent AND DetaliiFactura.CodProdus = @CodProdusCurent AND Factura.Data = @Row_Data\n"
                                       + "											),0)\n"
                                       + "								SET @Row_SI = @Row_SF - @Row_D + @Row_C\n"
                                       + "								SET @SF_Azi_CodProdusGestiune = @Row_SI\n"
                                       + "\n"
                                       + "								MERGE Stoc.StocRetro as TARGET\n"
                                       + "								USING (SELECT @Row_CodProdus, @Row_IdGestiune, @Row_Data, @Row_SI, @Row_SF, @Row_D, @Row_C)\n"
                                       + "								AS SOURCE    ( Row_CodProdus,  Row_IdGestiune,  Row_Data,  Row_SI,  Row_SF,  Row_D,  Row_C) \n"
                                       + "									ON (TARGET.CodProdus = SOURCE.Row_CodProdus AND TARGET.IdGestiune = SOURCE.Row_IDGestiune AND TARGET.Data = SOURCE.Row_Data) \n"
                                       + "									WHEN MATCHED THEN  \n"
                                       + "									UPDATE SET SI = SOURCE.Row_SI, SF = SOURCE.Row_SF, D = SOURCE.Row_D,  C = SOURCE.Row_C\n"
                                       + "									WHEN NOT MATCHED THEN \n"
                                       + "									INSERT (CodProdus, IDGestiune, Data, SI, SF, D, C) \n"
                                       + "									VALUES (SOURCE.Row_CodProdus, SOURCE.Row_IDGestiune, SOURCE.Row_Data, SOURCE.Row_SI, SOURCE.Row_SF, SOURCE.Row_D, SOURCE.Row_C);\n"
                                       + "\n"
                                       + "								SET @NrZileCalculate = @NrZileCalculate + 1\n"
                                       + "								--PRINT CONVERT(VARCHAR, @NrZileCalculate)\n"
                                       + "								--PRINT CONVERT(VARCHAR, @Row_Data)\n"
                                       + "								--PRINT CONVERT(VARCHAR, @CodProdusCurent)\n"
                                       + "							END\n"
                                       + "\n"
                                       + "						FETCH NEXT FROM ccGestiuni INTO  @IdGestiuneCurent \n"
                                       + "					END\n"
                                       + "				CLOSE ccGestiuni\n"
                                       + "				DEALLOCATE ccGestiuni\n"
                                       + "				\n"
                                       + "				FETCH NEXT FROM ccProduse INTO @CodProdusCurent   \n"
                                       + "			END   \n"
                                       + "\n"
                                       + "		CLOSE ccProduse   \n"
                                       + "		DEALLOCATE ccProduse\n"
                                       + "	\n"
                                       + "	DROP TABLE #Gestiuni\n"
                                       + "END\n"
                                       + "' \n"
                                       + "END\n";
                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.1.6";
                        #region Creare SP: CreateAlert_Type1
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CreateAlert_Type1]') AND type in (N'P', N'PC'))\n"
                                   + "BEGIN\n"
                                   + "EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[CreateAlert_Type1]\n"
                                   + "	(@DaysBack int, @NrZileOffsetBackDataRef int,  @MarkIfAvailableElsewhare bit)\n"
                                   + "as\n"
                                   + "BEGIN\n"
                                   + "	\n"
                                   + "	Declare @DataRef date\n"
                                   + "	Set @DataRef = CONVERT(date, getdate())\n"
                                   + "	Set @DataRef = DATEADD(day, (-1) * @NrZileOffsetBackDataRef, @DataRef)\n"
                                   + "	--print convert(varchar, @NrZileOffsetBackDataRef)\n"
                                   + "	--print convert(varchar, @DataRef)\n"
                                   + "	--print convert(varchar, DATEADD(day, (-1) * @DaysBack, @DataRef))\n"
                                   + "	\n"
                                   + "	TRUNCATE TABLE Stoc.AlerteStocType1\n"
                                   + "	INSERT INTO Stoc.AlerteStocType1 (CodProdus, IdGestiune, Stoc)\n"
                                   + "		SELECT StocRetro.CodProdus, StocRetro.IdGestiune, sum(StocRetro.SF) \n"
                                   + "			FROM stoc.StocRetro INNER JOIN stocuri ON StocRetro.CodProdus = stocuri.CodProdus AND StocRetro.IdGestiune = stocuri.IDGestiune\n"
                                   + "			WHERE Data >= DATEADD(day, (-1) * @DaysBack, @DataRef )\n"
                                   + "			AND Stocuri.Cantitate = 0\n"
                                   + "			GROUP BY StocRetro.CodProdus, StocRetro.IdGestiune HAVING sum(SF) = 0\n"
                                   + "\n"
                                   + "	UPDATE Stoc.AlerteStocType1 SET GestiuniCuStoc  = \n"
                                   + "				(SELECT DISTINCT stoc.udf_GetGestiuni(CodProdus) AS Gestiuni \n"
                                   + "                       FROM Stocuri f \n"
                                   + "					   WHERE f.CodProdus = Stoc.AlerteStocType1.CodProdus \n"
                                   + "					   AND f.IDGestiune = Stoc.AlerteStocType1.IdGestiune\n"
                                   + "					   )\n"
                                   + "\n"
                                   + "END\n"
                                   + "' \n"
                                   + "END\n";
                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.1.7";
                        #region Creare View: [stoc].[view_AlerteStocType1]
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[stoc].[view_AlerteStocType1]'))\n"
                               + "EXEC dbo.sp_executesql @statement = N'CREATE VIEW [stoc].[view_AlerteStocType1]\n"
                               + "AS\n"
                               + "SELECT        stoc.AlerteStocType1.CodProdus, NomStoc.Descriere, stoc.AlerteStocType1.IdGestiune, Gestiune.DenumireGestiune, stoc.AlerteStocType1.Stoc, \n"
                               + "                         stoc.AlerteStocType1.GestiuniCuStoc\n"
                               + "FROM            stoc.AlerteStocType1 INNER JOIN\n"
                               + "                         Gestiune ON stoc.AlerteStocType1.IdGestiune = Gestiune.IDGestiune INNER JOIN\n"
                               + "                         NomStoc ON stoc.AlerteStocType1.CodProdus = NomStoc.CodProdus\n"
                               + "' \n";

                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.1.8";
                        #region Creare View: [stoc].[view_StocRetro]
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[stoc].[view_StocRetro]'))\n"
                               + "EXEC dbo.sp_executesql @statement = N'CREATE VIEW [stoc].[view_StocRetro]\n"
                               + "AS\n"
                               + "SELECT        stoc.StocRetro.CodProdus, stoc.StocRetro.IdGestiune, dbo.NomStoc.Descriere, dbo.Gestiune.DenumireGestiune, stoc.StocRetro.Data, stoc.StocRetro.SI, \n"
                               + "                         stoc.StocRetro.SF, stoc.StocRetro.D, stoc.StocRetro.C\n"
                               + "FROM            stoc.StocRetro INNER JOIN\n"
                               + "                         dbo.NomStoc ON stoc.StocRetro.CodProdus = dbo.NomStoc.CodProdus INNER JOIN\n"
                               + "                         dbo.Gestiune ON stoc.StocRetro.IdGestiune = dbo.Gestiune.IDGestiune\n"
                               + "' \n";
                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.1.9";
                        #region adaugare index IdGestiune/CodProdus pe tabel [stoc].[AlerteStocType1]
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[stoc].[AlerteStocType1]') AND name = N'IdGestiuneCodProdus')\n"
                               + "CREATE NONCLUSTERED INDEX [IdGestiuneCodProdus] ON [stoc].[AlerteStocType1]\n"
                               + "(\n"
                               + "	[IdGestiune] ASC,\n"
                               + "	[CodProdus] ASC\n"
                               + ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\n";
                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.2.0";
                        #region creare tabel [stoc].[AlerteStocType1_Block] 
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[stoc].[AlerteStocType1_Block]') AND type in (N'U'))\n"
                               + "BEGIN\n"
                               + "CREATE TABLE [stoc].[AlerteStocType1_Block](\n"
                               + "	[Id] [int] IDENTITY(1,1) NOT NULL,\n"
                               + "	[IDGestiune] [int] NULL,\n"
                               + "	[CodProdus] [int] NULL,\n"
                               + " CONSTRAINT [PK_AlerteStocType1_Block] PRIMARY KEY CLUSTERED \n"
                               + "(\n"
                               + "	[Id] ASC\n"
                               + ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\n"
                               + ") ON [PRIMARY]\n"
                               + "END\n";
                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.2.1";
                        #region si indexare IdGestiuneCodProdusBlock pe tabel [stoc].[AlerteStocType1_Block]
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[stoc].[AlerteStocType1_Block]') AND name = N'BlockIdGestiuneCodProdus')\n"
                               + "CREATE NONCLUSTERED INDEX [BlockIdGestiuneCodProdus] ON [stoc].[AlerteStocType1_Block]\n"
                               + "(\n"
                               + "	[IDGestiune] ASC,\n"
                               + "	[CodProdus] ASC\n"
                               + ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\n";
                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.2.2";
                        #region Modificare view stoc.AlerteStocType1 pentru a exclude produsele blocate
                        cmd.CommandText = "ALTER VIEW [stoc].[view_AlerteStocType1] " +
                                " AS SELECT        stoc.AlerteStocType1.CodProdus, dbo.NomStoc.Descriere, stoc.AlerteStocType1.IdGestiune, dbo.Gestiune.DenumireGestiune, stoc.AlerteStocType1.Stoc, \n"
                               + "                         stoc.AlerteStocType1.GestiuniCuStoc, dbo.Categorii.DenumireCategorie, dbo.Parteneri.Denumire\n"
                               + "FROM            stoc.AlerteStocType1 INNER JOIN\n"
                               + "                         dbo.Gestiune ON stoc.AlerteStocType1.IdGestiune = dbo.Gestiune.IDGestiune INNER JOIN\n"
                               + "                         dbo.NomStoc ON stoc.AlerteStocType1.CodProdus = dbo.NomStoc.CodProdus INNER JOIN\n"
                               + "                         dbo.Categorii ON dbo.NomStoc.IDCategorie = dbo.Categorii.IDCategorie INNER JOIN\n"
                               + "                         dbo.Parteneri ON dbo.NomStoc.IDPartener = dbo.Parteneri.IDPartener\n"
                               + "WHERE        (stoc.AlerteStocType1.GestiuniCuStoc IS NOT NULL) AND (stoc.AlerteStocType1.CodProdus NOT IN\n"
                               + "                             (SELECT        CodProdus\n"
                               + "                               FROM            stoc.AlerteStocType1_Block\n"
                               + "                               WHERE        (CodProdus = stoc.AlerteStocType1.CodProdus) AND (IDGestiune = stoc.AlerteStocType1.IdGestiune)))\n";
                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.2.3";
                        #region [stoc].[view_AlerteStocType1_Block] creare view pentru deblocare produse
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[stoc].[view_AlerteStocType1_Block]'))\n"
                               + "EXEC dbo.sp_executesql @statement = N'CREATE VIEW [stoc].[view_AlerteStocType1_Block]\n"
                               + "AS\n"
                               + "SELECT        stoc.AlerteStocType1_Block.IDGestiune, dbo.Gestiune.DenumireGestiune, stoc.AlerteStocType1_Block.CodProdus, dbo.NomStoc.Descriere, \n"
                               + "                         dbo.NomStoc.IDSubCategorie, dbo.SubCategorii.DenumireSubcategorie\n"
                               + "FROM            stoc.AlerteStocType1_Block INNER JOIN\n"
                               + "                         dbo.NomStoc ON stoc.AlerteStocType1_Block.CodProdus = dbo.NomStoc.CodProdus INNER JOIN\n"
                               + "                         dbo.Gestiune ON stoc.AlerteStocType1_Block.IDGestiune = dbo.Gestiune.IDGestiune INNER JOIN\n"
                               + "                         dbo.SubCategorii ON dbo.NomStoc.IDSubCategorie = dbo.SubCategorii.IDSubCategorie\n"
                               + "' \n";
                        cmd.ExecuteNonQuery();
                        #endregion

                        pasEroare = "1.2.4";
                        #region  creare tabel [stoc].[AlerteStocType1_PrintRapid] pentru printare produse alese in urma analizarii alertelor de stoc
                        cmd.CommandText = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[stoc].[AlerteStocType1_PrintRapid]') AND type in (N'U'))\n"
                           + "BEGIN\n"
                           + "CREATE TABLE [stoc].[AlerteStocType1_PrintRapid](\n"
                           + "	[Id] [int] IDENTITY(1,1) NOT NULL,\n"
                           + "	[CodProdus] [int] NULL,\n"
                           + "	[Descriere] [varchar](100) NULL,\n"
                           + "	[IdGestiuneFrom] [int] NULL,\n"
                           + "	[IdGestiuneTo] [int] NULL,\n"
                           + "	[DenumireGestiuneFrom] [varchar](100) NULL,\n"
                           + "	[DenumireGestiuneTo] [varchar](100) NULL,\n"
                           + "	[Cantitate] [money] NULL,\n"
                           + " CONSTRAINT [PK_AlerteStocType1_PrintRapid] PRIMARY KEY CLUSTERED \n"
                           + "(\n"
                           + "	[Id] ASC\n"
                           + ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\n"
                           + ") ON [PRIMARY]\n"
                           + "END";
                        cmd.ExecuteNonQuery();
                        #endregion


                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare actualizare structura bd. pas " + pasEroare + " " + ex.Message.ToString());
                        return false;

                    }
                    finally
                    {
                        cnx.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare actualizare structura bd. pas -1: " + ex.Message.ToString());
                return false;

            }
        }

        public static Form GetOpenedForm<T>() where T : Form
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == typeof(T))
                {
                    return openForm;
                }
            }
            return null;
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Blue";
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Light";
            DevExpress.LookAndFeel.UserLookAndFeel.Default.UseWindowsXPTheme = false;
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.LookAndFeelStyle.Office2003;

            ribbonControl.Minimized = true;
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void xfrmMain_Load(object sender, EventArgs e)
        {
            if (!UpdateStructuraBd())
            {
                this.Close();
            }
            
        }

        private void ItemStocCurentCrossGestiune_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            xfrmComparatiiStocCurent_ToateProdusele xfrm_ComparatiiStocCurent_ToateProdusele = (xfrmComparatiiStocCurent_ToateProdusele)GetOpenedForm<xfrmComparatiiStocCurent_ToateProdusele>();
            if (xfrm_ComparatiiStocCurent_ToateProdusele == null)
            {
            }
            else
            {

                xfrm_ComparatiiStocCurent_ToateProdusele.Close();
                xfrm_ComparatiiStocCurent_ToateProdusele.Dispose();
                xfrm_ComparatiiStocCurent_ToateProdusele = null;
            }
            //open anyway
            xfrm_ComparatiiStocCurent_ToateProdusele = new xfrmComparatiiStocCurent_ToateProdusele();
            xfrm_ComparatiiStocCurent_ToateProdusele.Text = "Stoc curent - interactiv - toate gestiunile";
            xfrm_ComparatiiStocCurent_ToateProdusele.MdiParent = this;
            xfrm_ComparatiiStocCurent_ToateProdusele.Tag = "Stoc curent - interactiv - toate gestiunile";
            xfrm_ComparatiiStocCurent_ToateProdusele.Show();
        }

        private void navBarItemStocIstoric_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            xfrmEvolutieStocPerProdusGestiune xfrm_EvolutieStocPerProdusGestiune = (xfrmEvolutieStocPerProdusGestiune)GetOpenedForm<xfrmEvolutieStocPerProdusGestiune>();
            if (xfrm_EvolutieStocPerProdusGestiune == null)
            {
            }
            else
            {

                xfrm_EvolutieStocPerProdusGestiune.Close();
                xfrm_EvolutieStocPerProdusGestiune.Dispose();
                xfrm_EvolutieStocPerProdusGestiune = null;
            }
            //open anyway
            xfrm_EvolutieStocPerProdusGestiune = new xfrmEvolutieStocPerProdusGestiune();
            xfrm_EvolutieStocPerProdusGestiune.Text = "Evolutie stoc produse in ultimele N zile";
            xfrm_EvolutieStocPerProdusGestiune.MdiParent = this;
            xfrm_EvolutieStocPerProdusGestiune.Tag = "Evolutie stoc produse in ultimele N zile";
            xfrm_EvolutieStocPerProdusGestiune.Show();
        }

        private void navBarItemAlerteStoc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xfrmAlerteStoc xfrm_AlerteStoc = (xfrmAlerteStoc)GetOpenedForm<xfrmAlerteStoc>();
            if (xfrm_AlerteStoc == null)
            {
            }
            else
            {

                xfrm_AlerteStoc.Close();
                xfrm_AlerteStoc.Dispose();
                xfrm_AlerteStoc = null;
            }
            //open anyway
            xfrm_AlerteStoc = new xfrmAlerteStoc();
            xfrm_AlerteStoc.Text = "ALERTE STOC Istoric Zero Prelungit";
            xfrm_AlerteStoc.MdiParent = this;
            xfrm_AlerteStoc.Tag = "ALERTE STOC Istoric Zero Prelungit";
            xfrm_AlerteStoc.Show();
        }

        private void navBarItemProduseBlocatePentruAlerte_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            xfrmAlerteStock_Block xfrm_AlerteStock_Block = (xfrmAlerteStock_Block)GetOpenedForm<xfrmAlerteStock_Block>();
            if (xfrm_AlerteStock_Block == null)
            {
            }
            else
            {

                xfrm_AlerteStock_Block.Close();
                xfrm_AlerteStock_Block.Dispose();
                xfrm_AlerteStock_Block = null;
            }
            //open anyway
            xfrm_AlerteStock_Block = new xfrmAlerteStock_Block();
            xfrm_AlerteStock_Block.Text = "Deblocare produse ptrnu alerte stoc";
            xfrm_AlerteStock_Block.MdiParent = this;
            xfrm_AlerteStock_Block.Tag = "Deblocare produse ptrnu alerte stoc";
            xfrm_AlerteStock_Block.Show();
        }

        private void navBarItemDepozit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xfrmDepozitLayout_MapCartezian xfrm_DepozitLayout_MapCartezian = (xfrmDepozitLayout_MapCartezian)GetOpenedForm<xfrmDepozitLayout_MapCartezian>();
            if (xfrm_DepozitLayout_MapCartezian == null)
            {
            }
            else
            {

                xfrm_DepozitLayout_MapCartezian.Close();
                xfrm_DepozitLayout_MapCartezian.Dispose();
                xfrm_DepozitLayout_MapCartezian = null;
            }
            //open anyway
            xfrm_DepozitLayout_MapCartezian = new xfrmDepozitLayout_MapCartezian();
            xfrm_DepozitLayout_MapCartezian.Text = "Asezare rafturi - depozit";
            xfrm_DepozitLayout_MapCartezian.MdiParent = this;
            xfrm_DepozitLayout_MapCartezian.Tag = "Asezare rafturi - depozit";
            xfrm_DepozitLayout_MapCartezian.Show();


        }


    }
}