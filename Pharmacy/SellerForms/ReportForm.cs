using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class ReportForm : Form
    {
        private int saleId_;


        public ReportForm(int saleId)
        {
            saleId_ = saleId;
            InitializeComponent();
            checktableTableAdapter1.Fill(pharmacyDataSet1.checktable, 1);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.checktableTableAdapter.Fill(this.pharmacyDataSet.checktable, saleId_);
            this.reportViewer1.RefreshReport();
        }
    }
}
