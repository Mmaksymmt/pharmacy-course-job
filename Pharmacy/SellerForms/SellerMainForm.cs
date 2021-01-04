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
            salesGridView.Columns[0].HeaderText = "ID продажу";
            salesGridView.Columns[1].HeaderText = "Дата";
            salesGridView.Columns[2].HeaderText = "Сума";
        }


        private void CreateAdapter()
        {
            const string QUERY =
                "SELECT sales.sale_id, sale_date, " +
                "SUM(salesdrugs_amount * salesdrugs_price) as price " +
                "FROM sales LEFT JOIN salesdrugs ON sales.sale_id = salesdrugs.sale_id " +
                "WHERE sale_seller_id = @sale_seller_id " +
                "AND DATE(sale_date) = CURRENT_DATE() " +
                "GROUP BY sales.sale_id, sale_date " +
                "ORDER BY sale_date DESC;";
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
