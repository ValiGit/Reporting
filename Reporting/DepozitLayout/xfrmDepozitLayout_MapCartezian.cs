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
using DevExpress.XtraMap;

namespace Reporting.DepozitLayout
{
    public partial class xfrmDepozitLayout_MapCartezian : DevExpress.XtraEditors.XtraForm
    {
        public xfrmDepozitLayout_MapCartezian()
        {
            InitializeComponent();
        }

        private void splitterControl1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void mapControl1_SelectionChanged(object sender, DevExpress.XtraMap.MapSelectionChangedEventArgs e)
        {
            var mp = e.Selection[0] as MapPath;
            if (mp != null)
            {
                int count = mp.Attributes.Count();
                for (int i = 0; i < count; i++)
                {
                    MessageBox.Show(mp.Attributes[i].Name.ToString() + " " + mp.Attributes[i].Value.ToString());
                }
                
            }  
        }
    }
}