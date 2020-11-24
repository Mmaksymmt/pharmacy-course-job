using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class SellerMainForm : Form
    {
        private int sellerId_;


        public SellerMainForm(int sellerId)
        {
            InitializeComponent();
            sellerId_ = sellerId;
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void AddSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSaleForm form = new EditSaleForm(sellerId_);
            form.ShowDialog();
        }
    }
}
