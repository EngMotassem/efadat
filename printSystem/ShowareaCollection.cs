using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printSystem
{
    public partial class ShowareaCollection : Form
    {
        public ShowareaCollection()
        {
            InitializeComponent();
        }

        private void ShowareaCollection_Load(object sender, EventArgs e)
        {
            this.decTblTableAdapter.FillBy2(this.dataDataSet.decTbl);
            //  this.decTblTableAdapter.FillByDepatrment(this.dataDataSet.decTbl, "1");


            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
