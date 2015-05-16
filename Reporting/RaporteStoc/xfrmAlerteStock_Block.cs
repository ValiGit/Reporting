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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Data.SqlClient;

namespace Reporting.RaporteStoc
{
    public partial class xfrmAlerteStock_Block : DevExpress.XtraEditors.XtraForm
    {
        public xfrmAlerteStock_Block()
        {
            InitializeComponent();
        }

        private int UnBlockCodProdus;
        private int UnBlockIdGestiune;

        private void RefreshGridFromDataset()
        {
            // TODO: This line of code loads data into the 'mRPDataSet_view_AlerteStockType1_Block.view_AlerteStocType1_Block' table. You can move, or remove it, as needed.
            this.view_AlerteStocType1_BlockTableAdapter.Fill(this.mRPDataSet_view_AlerteStockType1_Block.view_AlerteStocType1_Block);
        }
        private void xfrmAlerteStock_Block_Load(object sender, EventArgs e)
        {

            RefreshGridFromDataset();
            //incarc lista de gestiuni posibile


        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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
                        UnBlockCodProdus = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CodProdus"));
                        UnBlockIdGestiune = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IDGestiune"));
                        popupMenu1.ItemLinks[0].Caption = "Deblocheaza produs " +
                                Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CodProdus")) + " pe gestiunea " +
                                Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DenumireGestiune"));
                        popupMenu1.ShowPopup(MousePosition);

                    }

                }


            }
        }

        private void barButtonItemDeblocheazaProdus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Doriti sa deblocati produsul selectat?", "Raport stocuri", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                //aplic procedura de blocare prin scriere pereche - produs/gestiune in tabelul de blocari alerte de tip 1

                using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.MRPConnectionString))
                {
                    try
                    {
                        cnx.Open();
                        string sqlBlock = "DELETE FROM [stoc].[AlerteStocType1_Block]  WHERE IdGestiune = @IdGestiune AND CodProdus = @CodProdus";
                        SqlCommand cmd = new SqlCommand(sqlBlock, cnx);
                        cmd.Parameters.Add("@IdGestiune", System.Data.SqlDbType.Int).Value = UnBlockIdGestiune;
                        cmd.Parameters.Add("@CodProdus", System.Data.SqlDbType.Int).Value = UnBlockCodProdus;
                        cmd.ExecuteNonQuery();
                        RefreshGridFromDataset();
                        MessageBox.Show("Produsul " + UnBlockCodProdus.ToString() + " a fost deblocat pe gestiunea " + UnBlockIdGestiune.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare deblocare produs: " + ex.Message.ToString());
                    }
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {


        }

        private void btnAdaugaInListaPRINT_Click(object sender, EventArgs e)
        {
            int CodProdus = 0;
            int DinGestiunea = 0;
            int SpreGestiunea = 0;
            decimal Cantitate = 0M;

            if (gridControl1.MainView.RowCount > 1)
            {

                int cellValue = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CodProdus"));
                if (cellValue > 0)
                {
                    CodProdus = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CodProdus"));
                    DinGestiunea = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "IDGestiune"));
                    MessageBox.Show(Convert.ToString(CodProdus) + " din gestiunae " + Convert.ToString(DinGestiunea));

                    //validarea elementelor care se vor introduse:
                    //validarea cantitatii de transferat:
                    decimal.TryParse(txtCantitatePrint.Text, out Cantitate);


                    //validarea gestiunii destinatie:

                }

            }
        }
    }
}