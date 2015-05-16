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

namespace Reporting.RaporteStoc
{
    public partial class xfrmEvolutieStocPerProdusGestiune : DevExpress.XtraEditors.XtraForm
    {
        public xfrmEvolutieStocPerProdusGestiune()
        {
            InitializeComponent();
        }

        private void xfrmEvolutieStocPerProdusGestiune_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mRPDataSet_Stoc_StocRetro.StocRetro' table. You can move, or remove it, as needed.
            this.stocRetroTableAdapter.Fill(this.mRPDataSet_Stoc_StocRetro.StocRetro);

        }
    }
}