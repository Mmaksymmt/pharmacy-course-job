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
    public partial class SalesStatisticsForm : Form
    {
        private DataTable salesDt_ = new DataTable();
        private DataTable drugsDt_ = new DataTable();


        public SalesStatisticsForm()
        {
            InitializeComponent();
            fromDatePicker.Value = DateTime.Now.AddMonths(-1);
            salesBindingSource.DataSource = salesDt_;
            salesGridView.DataSource = salesBindingSource;
            drugsBindingSource.DataSource = drugsDt_;
            drugsGridView.DataSource = drugsBindingSource;
        }


        private void FillSales()
        {
            const string QUERY =
@"SELECT
    sales.sale_id as 'ID продажу',
    sale_date as 'Дата',
    sale_seller_id as 'ID продавця',
    CONCAT(CONCAT(seller_surname, ' '), seller_name) as 'ПІБ продавця',
    COUNT(DISTINCT salesdrugs.drug_id) as 'Найменувань',
    SUM(salesdrugs_amount * salesdrugs_price) as 'Вартість продажу'
FROM
    (sales
    LEFT JOIN salesdrugs ON salesdrugs.sale_id = sales.sale_id)
    LEFT JOIN sellers ON sale_seller_id = seller_id
WHERE sale_date BETWEEN @from AND @to
GROUP BY sales.sale_id, sale_date, sale_seller_id";
            MySqlConnection connection = new MySqlConnection(
                Properties.Settings.Default.pharmacyConnectionString);
            MySqlCommand command = new MySqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@from", fromDatePicker.Value);
            command.Parameters.AddWithValue("@to", toDatePicker.Value);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            salesDt_.Rows.Clear();
            try
            {
                adapter.Fill(salesDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        private void FillDrugs()
        {
            DataRow selectedSale = GetSelectedSale();
            if (selectedSale == null)
            {
                drugsDt_.Clear();
                return;
            }

            int id = selectedSale.Field<int>("ID продажу");
            const string QUERY =
@"SELECT
    drug_id as 'ID ліків',
    drug_name as 'Назва',
    salesdrugs_amount as 'Ціна',
    salesdrugs_price as 'Кількість',
    salesdrugs_amount * salesdrugs_price as 'Всього'
FROM salesdrugs NATURAL JOIN drugs
WHERE sale_id = @id";
            MySqlConnection connection = new MySqlConnection(
                Properties.Settings.Default.pharmacyConnectionString);
            MySqlCommand command = new MySqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@id", id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            drugsDt_.Rows.Clear();
            try
            {
                adapter.Fill(drugsDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        private void FillTotalStatistics()
        {
            MySqlConnection connection = new MySqlConnection(
                Properties.Settings.Default.pharmacyConnectionString);
            connection.Open();
            const string INCOME_QUERY =
@"SELECT
    SUM(salesdrugs_price * salesdrugs_amount)
FROM sales
LEFT JOIN salesdrugs ON sales.sale_id = salesdrugs.sale_id
WHERE sale_date BETWEEN @from AND @to";
            MySqlCommand command = new MySqlCommand(INCOME_QUERY, connection);
            command.Parameters.AddWithValue("@from", fromDatePicker.Value);
            command.Parameters.AddWithValue("@to", toDatePicker.Value);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                reader.Read();
                incomeTextBox.Text = reader.GetDecimal(0).ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                incomeTextBox.Text = "0";
            }
            

            const string SOLD_DRUGS_QUERY =
@"SELECT
    SUM(salesdrugs_amount)
FROM sales
LEFT JOIN salesdrugs ON sales.sale_id = salesdrugs.sale_id
WHERE sale_date BETWEEN @from AND @to";
            command.CommandText = SOLD_DRUGS_QUERY;
            try
            {
                reader = command.ExecuteReader();
                reader.Read();
                soldDrugsTextBox.Text = reader.GetInt32(0).ToString();
            }
            catch (Exception ex)
            {
                soldDrugsTextBox.Text = "0";
            }
            connection.Close();
            totalStatisticsPanel.Visible = true;
        }


        private DataRow GetSelectedSale()
        {
            if (salesGridView.SelectedRows.Count == 0)
            {
                return null;
            }
            return
                ((salesGridView.SelectedRows[0].DataBoundItem) as DataRowView).Row;
        }


        private void CreateStatisticsButton_Click(object sender, EventArgs e)
        {
            FillSales();
            FillTotalStatistics();
        }


        private void SalesGridView_SelectionChanged(object sender, EventArgs e)
        {
            FillDrugs();
        }
    }
}
