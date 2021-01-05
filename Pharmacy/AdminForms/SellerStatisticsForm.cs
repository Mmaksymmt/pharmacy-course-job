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

namespace Pharmacy.AdminForms
{
    public partial class SellerStatisticsForm : Form
    {
        private MySqlConnection connection_;
        private DataRow sellerRow_;
        private DataTable statisticsTable_ = new DataTable();
        private DataTable salesTable_ = new DataTable();


        public SellerStatisticsForm(DataRow sellerRow)
        {
            InitializeComponent();
            sellerRow_ = sellerRow;
            idTextBox.Text = sellerRow.Field<int>("seller_id").ToString();
            nameTextBox.Text =
                sellerRow.Field<string>("seller_name") + " " +
                sellerRow.Field<string>("seller_surname") + " " +
                sellerRow.Field<string>("seller_patronymic");
            fromDatePicker.Value = DateTime.Now.AddMonths(-1);
            statisticsBindingSource.DataSource = statisticsTable_;
            statisticsGridView.DataSource = statisticsBindingSource;
            salesBindingSource.DataSource = salesTable_;
            salesGridView.DataSource = salesBindingSource;
            connection_ = new MySqlConnection(
                Properties.Settings.Default.pharmacyConnectionString);
        }


        private void CreateStatisticsButton_Click(object sender, EventArgs e)
        {
            const string STATISTICS_QUERY = @"
SELECT
    COUNT(DISTINCT sales.sale_id) AS ""Продажів"",
    SUM(salesdrugs_amount) AS ""Проданих одиниць товарів"",
    SUM(salesdrugs_price * salesdrugs_amount) AS ""Сума продажів""
FROM
    sales INNER JOIN salesdrugs ON salesdrugs.sale_id = sales.sale_id
WHERE
    sale_seller_id = @seller_id AND sale_date BETWEEN @date_from AND @date_to
";
            MySqlCommand statisticsCommand = new MySqlCommand(STATISTICS_QUERY, connection_);
            statisticsCommand.Parameters.AddWithValue(
                "@seller_id",
                sellerRow_.Field<int>("seller_id"));
            statisticsCommand.Parameters.AddWithValue(
                "@date_from", fromDatePicker.Value);
            statisticsCommand.Parameters.AddWithValue(
                "@date_to", toDatePicker.Value);
            MySqlDataAdapter statisticsAdapter = new MySqlDataAdapter(statisticsCommand);
            statisticsTable_.Rows.Clear();
            statisticsAdapter.Fill(statisticsTable_);

            const string SALES_QUERY = @"
SELECT
    sales.sale_id AS ""ID"", sale_date AS ""Дата"",
    SUM(salesdrugs_price * salesdrugs_amount) AS ""Сума продажу"",
    COUNT(salesdrugs.drug_id) AS ""Найменувань товарів""
FROM
    sales INNER JOIN salesdrugs ON salesdrugs.sale_id = sales.sale_id
WHERE
    sale_seller_id = @seller_id AND sale_date BETWEEN @date_from AND @date_to
GROUP BY ""Дата"", sales.sale_id
";
            MySqlCommand salesCommand = new MySqlCommand(SALES_QUERY, connection_);
            salesCommand.Parameters.AddWithValue(
                "@seller_id",
                sellerRow_.Field<int>("seller_id"));
            salesCommand.Parameters.AddWithValue(
                "@date_from", fromDatePicker.Value);
            salesCommand.Parameters.AddWithValue(
                "@date_to", toDatePicker.Value);
            MySqlDataAdapter salesAdapter = new MySqlDataAdapter(salesCommand);
            salesTable_.Rows.Clear();
            salesAdapter.Fill(salesTable_);
        }
    }
}
