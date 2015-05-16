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
using System.Data;
using System.Data.SqlClient;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace Reporting.RaporteStoc
{
    public partial class xfrmAlerteStoc : DevExpress.XtraEditors.XtraForm
    {
        public xfrmAlerteStoc()
        {
            InitializeComponent();
        }

        public int BlockCodProdus;
        public int BlockIdGestiune;
        private void xfrmAlerteStoc_Load(object sender, EventArgs e)
        {
            this.dateEditIncepandCuData.DateTime = DateTime.Today;
            this.txtNumarZileInBack.Text = "10";
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.MRPConnectionString))
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Stoc.AlerteStocType1", cnx);                   
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    
                }
            }

            RefreshGridFromDataset();

            //incarc lista de combo gestiuni din care poate fi efectuat transferul
            List<Gestiune> listGestiuni = new List<Gestiune>();
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.MRPConnectionString))
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("SELECT IdGestiune, DenumireGestiune FROM Gestiune", cnx);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            listGestiuni.Add(new Gestiune { IdGestiune = Convert.ToInt32(r["IdGestiune"]), DenumireGestiune = Convert.ToString(r["DenumireGestiune"]) });
                        }
                    }
                    lookUpEditGestiunePrint.Properties.DataSource = listGestiuni;
                    lookUpEditGestiunePrint.Properties.ValueMember = "IdGestiune";
                    lookUpEditGestiunePrint.Properties.DisplayMember = "DenumireGestiune";
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Eroare populare lista gestiuni iesire: " + ex.Message.ToString());
                }
            }
        }
        private class Gestiune
        {
            public int IdGestiune { get; set; }
            public string DenumireGestiune { get; set; }
        }
        private void RefreshGridFromDataset()
        {
            // TODO: This line of code loads data into the 'mRPDataSet_view_Stoc_AlerteStocType1.view_AlerteStocType1' table. You can move, or remove it, as needed.
            this.view_AlerteStocType1TableAdapter.Fill(this.mRPDataSet_view_Stoc_AlerteStocType1.view_AlerteStocType1);
        }
        private void btnGenereazaAlerte_Click(object sender, EventArgs e)
        {
            int DaysBack;
            int NrZileOffsetBackDataRef;
            if (!int.TryParse(txtNumarZileInBack.Text, out DaysBack))
            {
                MessageBox.Show("Introduceti o valoare numerica pentru numarul de zile de analiza incepand cu data indicata.");
                return;
            }
            else
            {
                if (DaysBack == 0 )
                {
                    MessageBox.Show("Introduceti o valoare diferita de zero!");
                }
            }

            if (!int.TryParse(txtOffsetDaysBack.Text, out NrZileOffsetBackDataRef))
            {
                MessageBox.Show("Introduceti o valoare numerica pentru numarul de zile de offset.");
                return;
            }
            
            //calcul alerte si scrierea lor in tabel Stoc.AlerteStocType1. Presupune ca tabelul Stoc.StocRetro este calculat cel putin cu numarul de zile in urma cerut
            using (SqlConnection cnx= new SqlConnection(Properties.Settings.Default.MRPConnectionString))
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "CreateAlert_Type1";
                    cmd.Parameters.Add("@DaysBack", System.Data.SqlDbType.Int).Value = DaysBack;
                    cmd.Parameters.Add("@NrZileOffsetBackDataRef", System.Data.SqlDbType.Int).Value = NrZileOffsetBackDataRef;
                    cmd.Parameters.Add("@MarkIfAvailableElsewhare", System.Data.SqlDbType.Bit).Value = true;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }


            this.view_AlerteStocType1TableAdapter.Fill(this.mRPDataSet_view_Stoc_AlerteStocType1.view_AlerteStocType1);
            gridView1.RefreshData();
            
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            int lastRowHandle;
            int lastColumn;
            if (e.Info == null && e.SelectedControl == gridControl1)
            {
                ToolTipControlInfo info = null;
                GridView view = gridControl1.GetViewAt(e.ControlMousePosition) as GridView;
                if (view == null) return;
                GridHitInfo gridHitInfo = view.CalcHitInfo(e.ControlMousePosition);

                //Display a hint for row indicator cells
                if (gridHitInfo.HitTest == GridHitTest.RowIndicator)
                {
                    //An object that uniquely identifies a row indicator cell
                    object o = gridHitInfo.HitTest.ToString() + gridHitInfo.RowHandle.ToString();
                    string text = "Rand " + gridHitInfo.RowHandle.ToString();
                    info = new ToolTipControlInfo(o, text);
                }
                if (gridHitInfo.HitTest == GridHitTest.RowCell)
                {
                    object ocell = gridHitInfo.HitTest.ToString() + gridHitInfo.RowHandle.ToString();
                    string text = "Celula " + gridHitInfo.HitTest.ToString();
                    info = new ToolTipControlInfo(ocell, text);
                }
                //if (gridHitInfo.InRowCell)
                //{
                //    int i = Convert.ToInt32(gridView1.GetRowCellDisplayText(gridHitInfo.RowHandle, gridHitInfo.Column));

                //    if (lastRowHandle != gridHitInfo.RowHandle || lastColumn != gridHitInfo.Column)
                //    {
                //        lastColumn = info.Column;
                //        lastRowHandle = info.RowHandle;
                //        string text = "";
                //        if (i > 30000)
                //        {
                //            text = "here is a big string to display";
                //            lastInfo = new ToolTipControlInfo(new GridToolTipInfo(view, new CellToolTipInfo(info.RowHandle, info.Column, "Text")), text);
                //        }
                //        else
                //            lastInfo = new ToolTipControlInfo(new GridToolTipInfo(view, new CellToolTipInfo(info.RowHandle, info.Column, "Text")), i.ToString());
                //    }
                //    e.Info = lastInfo;
                //}
                //Supply tooltip information if applicable, otherwise preserve default tooltip (if any)
                if (info != null)
                    e.Info = info;            
                }



            




        }

        


        private void cmdExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Salvare fisier Export Excel";
            saveDialog.Filter = "*.xls|*.xlsx";
            saveDialog.ShowDialog();
            if (string.IsNullOrEmpty(saveDialog.FileName))
            {
                MessageBox.Show("Cale/Fisier invalid");
                return;
            }
            gridView1.ExportToXls(saveDialog.FileName);
        }

        private void btnCalculStocIstoric_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Doriti calcul stoc istoric? Atentie, calculul dureaza destul de multisor!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            int DaysBack;
            int NrZileOffsetBackDataRef;
            if (!int.TryParse(txtNumarZileInBack.Text, out DaysBack))
            {
                MessageBox.Show("Introduceti o valoare numerica pentru numarul de zile de analiza incepand cu data indicata.");
            }
            else
            {
                if (DaysBack == 0)
                {
                    MessageBox.Show("Introduceti o valoare diferita de zero!");
                }
            }

            

            if (!int.TryParse(txtOffsetDaysBack.Text, out NrZileOffsetBackDataRef))
            {
                MessageBox.Show("Introduceti o valoare numerica pentru numarul de zile de offset.");
                return;
            }
            //calcul alerte si scrierea lor in tabel Stoc.AlerteStocType1. Presupune ca tabelul Stoc.StocRetro este calculat cel putin cu numarul de zile in urma cerut
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.MRPConnectionString))
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("", cnx);
                    cmd.CommandTimeout = 20000; // in secunde
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "CalculStocRetro";
                    cmd.Parameters.Add("@AllProducts", System.Data.SqlDbType.Bit).Value = true;
                    cmd.Parameters.Add("@ColumnFilterName", System.Data.SqlDbType.VarChar, 50).Value = "";
                    cmd.Parameters.Add("@ColumnFlterValue", System.Data.SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@DaysRetro", System.Data.SqlDbType.Int).Value = DaysBack;
                    cmd.Parameters.Add("@ActivateArrayFiltruIdDoc", System.Data.SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@NrZileOffset", System.Data.SqlDbType.Int).Value = NrZileOffsetBackDataRef;

                
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare calcul stoc istoric: " + ex.Message.ToString());
                    
                }
            }
            
            
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Doriti sa blocati produsul selectat?", "Raport stocuri", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                //aplic procedura de blocare prin scriere pereche - produs/gestiune in tabelul de blocari alerte de tip 1

                using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.MRPConnectionString))
                {
                    try
                    {
                        cnx.Open();
                        string sqlBlock = "INSERT INTO [stoc].[AlerteStocType1_Block] (IdGestiune, CodProdus) VALUES (@IdGestiune, @CodProdus)";
                        SqlCommand cmd = new SqlCommand(sqlBlock, cnx);
                        cmd.Parameters.Add("@IdGestiune", System.Data.SqlDbType.Int).Value = BlockIdGestiune;
                        cmd.Parameters.Add("@CodProdus", System.Data.SqlDbType.Int).Value = BlockCodProdus;
                        cmd.ExecuteNonQuery();
                        RefreshGridFromDataset();
                        MessageBox.Show("Produsul " + BlockCodProdus.ToString() + " a fost blocat pe gestiunea " + BlockIdGestiune.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare blocare produs: " + ex.Message.ToString());
                    }
                }
            }
        }
        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                if (gridControl1.MainView.RowCount > 1)
                {

                    int cellValue = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CodProdus"));
                    if (cellValue > 0)
                    {
                        BlockCodProdus = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CodProdus"));
                        BlockIdGestiune = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IdGestiune"));
                        popupMenu1.ItemLinks[0].Caption = "Blocheaza produs " +
                                Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CodProdus")) + " pe gestiunea " +
                                Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DenumireGestiune"));
                        popupMenu1.ShowPopup(MousePosition);

                    }

                }


            }
        }

        private void barButtonItemAdaugaInListaDePrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //scriu produsul selectat in lista de print

            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.MRPConnectionString))
            {
                try
                {
                    cnx.Open();
                    string sqlBlock = "INSERT INTO [stoc].[PrintRapid] (IdGestiune, CodProdus) VALUES (@IdGestiune, @CodProdus)";
                    SqlCommand cmd = new SqlCommand(sqlBlock, cnx);
                    cmd.Parameters.Add("@IdGestiune", System.Data.SqlDbType.Int).Value = BlockIdGestiune;
                    cmd.Parameters.Add("@CodProdus", System.Data.SqlDbType.Int).Value = BlockCodProdus;
                    cmd.ExecuteNonQuery();
                    RefreshGridFromDataset();
                    MessageBox.Show("Produsul " + BlockCodProdus.ToString() + " a fost blocat pe gestiunea " + BlockIdGestiune.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare blocare produs: " + ex.Message.ToString());
                }
            }

        }

        private void btnAdaugaInListaP_Click(object sender, EventArgs e)
        {
            int CodProdus = 0;
            int DinGestiunea = 0;
            int SpreGestiunea = 0;
            decimal Cantitate = 0M;
            string Descriere = "";
            string DenumireGestiuneTo = "";
            string DenumireGestiuneFrom = "";

            if (gridControl1.MainView.RowCount > 1)
            {

                int cellValue = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CodProdus"));
                if (cellValue > 0)
                {
                    CodProdus = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CodProdus"));
                    DinGestiunea = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IdGestiune"));
                    Descriere = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descriere"));
                    DenumireGestiuneTo = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DenumireGestiune"));
                    
                    //MessageBox.Show(Convert.ToString(CodProdus) + " din gestiunea " + Convert.ToString(DinGestiunea));

                    //validarea elementelor care se vor introduse:
                    //validarea cantitatii de transferat:
                    decimal.TryParse(txtCantitatePrint.Text, out Cantitate);
                    if (Cantitate <= 0)
                    {
                        MessageBox.Show("Introduceti o cantitate >0 pentru transfer!");
                        return;

                    }

                    //validarea gestiunii destinatie:
                    if (lookUpEditGestiunePrint.EditValue == null)
                    {
                        MessageBox.Show("Introduceti gestiunea sursa!");
                        return;
                    }
                    else
                    {
                        int.TryParse(lookUpEditGestiunePrint.EditValue.ToString(), out SpreGestiunea);
                        DenumireGestiuneFrom = lookUpEditGestiunePrint.Text;
                    }


                    //trec la insert ca datele au fost validate:

                    using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.MRPConnectionString))
                    {
                        try
                        {
                            cnx.Open();
                            string sqlInsert = "INSERT INTO [stoc].[AlerteStocType1_PrintRapid] " +
                                    "   ([CodProdus] " +
                                    "   ,[Descriere] " +
                                    "   ,[IdGestiuneFrom] " +
                                    "   ,[DenumireGestiuneFrom] " +
                                    "   ,[IdGestiuneTo] " +
                                    "   ,[DenumireGestiuneTo] " +
                                    "   ,[Cantitate]) " +
                                    " VALUES (@CodProdus " +
                                    "   ,@Descriere " +
                                    "   ,@IdGestiuneFrom " +
                                    "   ,@DenumireGestiuneFrom " +
                                    "   ,@IdGestiuneTo " +
                                    "   ,@DenumireGestiuneTo " +
                                    "   ,@Cantitate) ";

                            SqlCommand cmd = new SqlCommand(sqlInsert, cnx);

                            cmd.Parameters.Add("@CodProdus", System.Data.SqlDbType.Int).Value = CodProdus;
                            cmd.Parameters.Add("@Descriere", System.Data.SqlDbType.VarChar, 100).Value = Descriere;
                            cmd.Parameters.Add("@IdGestiuneFrom", System.Data.SqlDbType.Int).Value = DinGestiunea;
                            cmd.Parameters.Add("@DenumireGestiuneFrom", System.Data.SqlDbType.VarChar, 100).Value = DenumireGestiuneFrom;
                            cmd.Parameters.Add("@IdGestiuneTo", System.Data.SqlDbType.Int).Value = SpreGestiunea;
                            cmd.Parameters.Add("@DenumireGestiuneTo", System.Data.SqlDbType.VarChar, 100).Value = DenumireGestiuneTo;
                            cmd.Parameters.Add("@Cantitate", System.Data.SqlDbType.Money).Value = Cantitate;

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Produsul " + CodProdus.ToString() + " a fost adaugat in lista de transfer din gestiunea " + DenumireGestiuneFrom + " spre gestiunea " + DenumireGestiuneTo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare adaugare produs in lista de transfer: " + ex.Message.ToString());
                        }
                    }
                }

            }
        }

        private void btnVeziListaPRINT_Click(object sender, EventArgs e)
        {
            xfrmListaPrint xfrm_ListaPrint = (xfrmListaPrint)GetOpenedForm<xfrmListaPrint>();
            if (xfrm_ListaPrint == null)
            {
            }
            else
            {

                xfrm_ListaPrint.Close();
                xfrm_ListaPrint.Dispose();
                xfrm_ListaPrint = null;
            }
            //open anyway
            xfrm_ListaPrint = new xfrmListaPrint();
            xfrm_ListaPrint.Text = "Lista produse alese pentru transfer";
            xfrm_ListaPrint.Tag = "Lista produse alese pentru transfer";
            xfrm_ListaPrint.Show();
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
    }
}