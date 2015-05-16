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
using System.Data.SqlClient;

namespace Reporting.RaporteStoc
{
    public partial class xfrmListaPrint : DevExpress.XtraEditors.XtraForm
    {
        public xfrmListaPrint()
        {
            InitializeComponent();
        }

        private void xfrmListaPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mRPDataSet_AlerteStocType1_PrintRapid.AlerteStocType1_PrintRapid' table. You can move, or remove it, as needed.
            this.alerteStocType1_PrintRapidTableAdapter.Fill(this.mRPDataSet_AlerteStocType1_PrintRapid.AlerteStocType1_PrintRapid);

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
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

        private void btnSterge_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.MRPConnectionString))
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM stoc.AlerteStocType1_PrintRapid", cnx);                 
                    cmd.ExecuteNonQuery();
                    this.alerteStocType1_PrintRapidTableAdapter.Fill(this.mRPDataSet_AlerteStocType1_PrintRapid.AlerteStocType1_PrintRapid);
                    gridView1.RefreshData();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Eroare stergere date print rapid: " + ex.Message.ToString());

                }
            }
        }
    }
}