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
    public partial class SaleDrugInsertForm : Form
    {
        private const string DB_CONNECTION_STRING =
            "server=localhost;user id=root;password=YflOe234fOEM;persistsecurityinfo=True;" +
            "database=pharmacy";
        private MySqlConnection connection_ = new MySqlConnection(DB_CONNECTION_STRING);
        private DataTable drugsDt_ = new DataTable();
        private DataTable categoriesDt_ = new DataTable();
        private int currentSaleId_;


        public SaleDrugInsertForm(int saleId)
        {
            InitializeComponent();
            currentSaleId_ = saleId;
            nameComboBox.SelectedItem = null;
            FillCategories();
        }


        private void FillDrugs()
        {
            drugsDt_.Clear();
            if (categoryComboBox.SelectedItem == null)
            {
                return;
            }

            int categoryId =
                (Convert.ToInt32((categoryComboBox.SelectedItem as DataRowView)
                .Row["category_id"]));
            string query =
                $"SELECT * FROM drugs WHERE drug_category_id={categoryId} " +
                $"AND drug_id NOT IN " +
                $"(SELECT drug_id FROM salesdrugs WHERE salesdrugs.sale_id = {currentSaleId_});";
            MySqlDataAdapter adapter;

            try
            {
                connection_.Open();
                adapter = new MySqlDataAdapter(query, connection_);
                adapter.Fill(drugsDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }

            connection_.Close();
            nameComboBox.ValueMember = "drug_id";
            nameComboBox.DisplayMember = "drug_name";
            nameComboBox.DataSource = drugsDt_;
        }


        private void FillCategories()
        {
            string query = "SELECT * FROM drugcategories;";
            MySqlDataAdapter adapter;
            categoriesDt_.Clear();

            try
            {
                connection_.Open();
                adapter = new MySqlDataAdapter(query, connection_);
                adapter.Fill(categoriesDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }

            connection_.Close();
            categoryComboBox.DisplayMember = "category_name";
            categoryComboBox.ValueMember = "category_id";
            categoryComboBox.DataSource = categoriesDt_;
        }


        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDrugs();
        }


        private void NameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRow selected = (nameComboBox.SelectedItem as DataRowView)?.Row;
            if (nameComboBox.SelectedItem == null)
            {
                amountNumericUpDown.Value = 0;
                amountNumericUpDown.Enabled = false;
                priceValueLabel.Text = string.Empty;
                inStockValueLabel.Text = string.Empty;
                saveButton.Enabled = false;
            }
            else
            {
                amountNumericUpDown.Maximum = Convert.ToInt32(selected["drug_amount"]);
                amountNumericUpDown.Minimum = 0;
                amountNumericUpDown.Value = amountNumericUpDown.Maximum == 0 ? 0 : 1;
                amountNumericUpDown.Enabled = true;
                priceValueLabel.Text = Convert.ToDecimal(selected["drug_price"]).ToString();
                inStockValueLabel.Text = amountNumericUpDown.Maximum.ToString();
                saveButton.Enabled = true;
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataRow selected = (nameComboBox.SelectedItem as DataRowView).Row;
            string query = $"INSERT INTO salesdrugs (sale_id, drug_id, salesdrugs_amount) " +
                $"VALUES ({currentSaleId_}, {selected["drug_id"]}, {amountNumericUpDown.Value});";
            MySqlCommand command = new MySqlCommand(query, connection_);

            try
            {
                connection_.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Close();
            }

            connection_.Close();
            Close();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
