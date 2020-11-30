using MySql.Data.MySqlClient;
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
        private MySqlConnection connection_;
        MySqlDataAdapter adapter_;
        private DataTable salesDt_ = new DataTable();
        private int sellerId_;


        public SellerMainForm(int sellerId)
        {
            InitializeComponent();
            sellerId_ = sellerId;
            datatableBindingSource.DataSource = salesDt_;
            salesGridView.DataSource = datatableBindingSource;
            connection_ =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);
            CreateAdapter();
            FillData();
        }


        private void CreateAdapter()
        {
            const string QUERY = "SELECT sale_id, sale_date FROM sales " +
                "WHERE sale_seller_id = @sale_seller_id " +
                "AND DATE(sale_date) = CURRENT_DATE() ORDER BY sale_date DESC;";
            MySqlCommand command = new MySqlCommand(QUERY, connection_);
            command.Parameters.AddWithValue("@sale_seller_id", sellerId_);
            adapter_ = new MySqlDataAdapter(command);
        }


        private void FillData()
        {
            salesDt_.Rows.Clear();

            try
            {
                connection_.Open();
                adapter_.Fill(salesDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }

            connection_.Close();
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void AddSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSaleForm form = new EditSaleForm(sellerId_);
            form.ShowDialog();
            FillData();
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            if (salesGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataRow selected =
                (salesGridView.SelectedRows[0].DataBoundItem as DataRowView).Row;
            int saleId = Convert.ToInt32(selected["sale_id"]);
            var form = new EditSaleForm(sellerId_, saleId);
            form.ShowDialog();
            FillData();
        }
    }
}
