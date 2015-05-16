using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;

namespace Reporting.RaporteStoc
{
    public partial class xfrmComparatiiStocCurent_ToateProdusele : DevExpress.XtraEditors.XtraForm
    {
        public xfrmComparatiiStocCurent_ToateProdusele()
        {
            InitializeComponent();
        }

        private void xfrmComparatiiStocCurent_ToateProdusele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_StocCurentToateGestiunile.Stocuri' table. You can move, or remove it, as needed.


        }

        private string ReturnSQLPivot ()
        {
            return
                    " SELECT CodProdus, Descriere, Familie, Categorie, Subcategorie, Furnizor, [Depozit], [Iancului], [Baicului], [Beldiman], [Foisor]  " +
                    " FROM " +
	                "     ( " +
		            "         SELECT Gestiune.DenumireGestiune, Nomstoc.Descriere, Familii.DenumireFamilie as Familie, Categorii.DenumireCategorie as Categorie, Subcategorii.DenumireSubcategorie as Subcategorie, " +
			        "             Parteneri.Denumire as Furnizor, " +
			        "             Stocuri.CodProdus, Stocuri.Cantitate " +
		            "         FROM Stocuri Inner Join Gestiune ON Stocuri.IdGestiune = Gestiune.IdGestiune INNER JOIN Nomstoc ON Stocuri.CodProdus = Nomstoc.CodProdus " +
			        "             LEFT JOIN Familii ON Nomstoc.IdFamilie = Familii.IdFamilie " +
			        "             LEFT JOIN Categorii ON Nomstoc.IdCategorie = Categorii.IdCategorie " +
			        "             LEFT JOIN Subcategorii ON Nomstoc.IdSubcategorie = Subcategorii.IdSubcategorie " +
			        "             LEFT JOIN Parteneri ON Nomstoc.IdPartener = Parteneri.IdPartener " +
	                "     ) p " +
                    " PIVOT " +
                    " ( " +
	                "     SUM (Cantitate) " +
	                "     FOR DenumireGestiune IN ( [Depozit], [Iancului], [Baicului], [Beldiman], [Foisor] ) " +
                    " ) AS pvt " +
                    " ORDER BY pvt.CodProdus;";
            
        }
        private class MyData
        {
            public int CodProdus { get; set; }
            public string Descrire { get; set; }
            public string Familie { get; set; }
            public string Categorie { get; set; }
            public string Subcategorie { get; set; }
            public string Furnizor { get; set; }
            public decimal Depozit { get; set; }
            public decimal Iancului { get; set; }
            public decimal Beldiman { get; set; }
            public decimal Foisor { get; set; }


        }

        private void xfrmComparatiiStocCurent_ToateProdusele_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dateMasterDataSet_Gestiune.Gestiune' table. You can move, or remove it, as needed.
            this.gestiuneTableAdapter.Fill(this.dateMasterDataSet_Gestiune.Gestiune);
            // TODO: This line of code loads data into the 'ds_StocCurentToateGestiunile1.view_reports_stoc_all' table. You can move, or remove it, as needed.
            this.view_reports_stoc_allTableAdapter.Fill(this.ds_StocCurentToateGestiunile1.view_reports_stoc_all);

        }

        private void btnOKFiltruGestiuniNOTIn_Click(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = "";
                //"[" + searchLookUpEdit_ProdCareSuntInGestiunea.Text + "] IS NOT NULL AND [" + searchLookUpEdit_ProdCareNUSuntInGestiunea.Text + "] IS NULL";
            //gridView1.Columns[searchLookUpEdit_ProdCareSuntInGestiunea.Text].FilterInfo = new ColumnFilterInfo();
            //new ColumnFilterInfo("[" + searchLookUpEdit_ProdCareSuntInGestiunea.Text + "] IS NOT NULL AND [" + searchLookUpEdit_ProdCareNUSuntInGestiunea.Text + "] IS NULL");
        }

    }
}