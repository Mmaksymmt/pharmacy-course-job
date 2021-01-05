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
    public partial class DrugsStatisticsForm : Form
    {
        private MySqlConnection connection_;
        private DataTable drugsDt_ = new DataTable();


        public DrugsStatisticsForm()
        {
            InitializeComponent();
            connection_ = new MySqlConnection(
                Properties.Settings.Default.pharmacyConnectionString);
            fromDatePicker.Value = DateTime.Now.AddMonths(-1);
            bindingSource1.DataSource = drugsDt_;
            drugsGridView.DataSource = bindingSource1;
        }


        private void CreateStatisticsButton_Click(object sender, EventArgs e)
        {
            const string QUERY = @"
SELECT
    drugs.drug_id AS ""ID"", drug_name AS ""Назва"", category_name AS ""Категорія"",
    SUM(salesdrugs_amount) AS ""Продано одиниць"",
    COUNT(salesdrugs.drug_id) AS ""Продажів"",
    SUM(salesdrugs_amount * salesdrugs_price) AS ""Продано на суму""
FROM
    drugs LEFT JOIN salesdrugs ON drugs.drug_id = salesdrugs.drug_id
    LEFT JOIN sales ON salesdrugs.sale_id = sales.sale_id
    LEFT JOIN drugcategories ON drugcategories.category_id = drugs.drug_category_id
WHERE sale_date BETWEEN @date_from AND @date_to
GROUP BY drugs.drug_id, drug_name, category_name
";
            MySqlCommand command = new MySqlCommand(QUERY, connection_);
            command.Parameters.AddWithValue("@date_from", fromDatePicker.Value);
            command.Parameters.AddWithValue("@date_to", toDatePicker.Value);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            drugsDt_.Rows.Clear();
            adapter.Fill(drugsDt_);
        }
    }
}
