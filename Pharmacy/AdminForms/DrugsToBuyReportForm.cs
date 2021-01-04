using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pharmacy.AdminForms.PurchaseListForm;

namespace Pharmacy.AdminForms
{
    public partial class DrugsToBuyReportForm : Form
    {
        public DrugsToBuyReportForm(List<DrugItem> drugItems)
        {
            InitializeComponent();
            reportBindingSource.DataSource = drugItems;
        }


        private void DrugsToBuyReportForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            reportViewer1.RefreshReport();
        }
    }
}
