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
        private MySqlConnection connection_;
        private DataTable drugsDt_ = new DataTable();
        private DataTable categoriesDt_ = new DataTable();
        private int currentSaleId_;


        public SaleDrugInsertForm(int saleId)
        {
            InitializeComponent();
            dataTableBindingSource.DataSource = drugsDt_;
            drugsGridView.DataSource = dataTableBindingSource;
            currentSaleId_ = saleId;
            connection_ =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);
            FillCategories();
            FillTable();
            categoryComboBox.SelectedItem = null;
        }


        private void FillTable()
        {
            DataRow categoryRow = (categoryComboBox.SelectedItem as DataRowView)?.Row;
            string query;
            MySqlCommand command = new MySqlCommand() { Connection = connection_ };

            if (categoryRow == null)
            {
                query = "SELECT drug_id, drug_name, drugcategories.category_name, drug_form, " +
                    "drug_manufacturer, drug_prescription_leave, drug_price, drug_amount " +
                    "FROM drugs INNER JOIN drugcategories " +
                    "ON drugs.drug_category_id = drugcategories.category_id " +
                    "WHERE LOCATE(@name_filter, drug_name) > 0 " +
                    "AND drug_id NOT IN " +
                    "(SELECT drug_id FROM salesdrugs WHERE salesdrugs.sale_id = @sale_id);";
            }
            else
            {
                query = "SELECT drug_id, drug_name, drugcategories.category_name, drug_form, " +
                    "drug_manufacturer, drug_prescription_leave, drug_price, drug_amount " +
                    "FROM drugs INNER JOIN drugcategories " +
                    "ON drugs.drug_category_id = drugcategories.category_id " +
                    "WHERE LOCATE(@name_filter, drug_name) > 0 " +
                    "AND drug_category_id = @category_id AND drug_id NOT IN " +
                    "(SELECT drug_id FROM salesdrugs WHERE salesdrugs.sale_id = @sale_id);";
                int categoryId = Convert.ToInt32(categoryRow["category_id"]);
                command.Parameters.AddWithValue("@category_id", categoryId);
            }

            command.Parameters.AddWithValue("@sale_id", currentSaleId_);
            command.Parameters.AddWithValue("@name_filter", nameTextBox.Text);
            command.CommandText = query;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            drugsDt_.Rows.Clear();

            try
            {
                connection_.Open();
                adapter.Fill(drugsDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }

            connection_.Close();
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
            categoryComboBox.SelectedItem = null;
        }


        private DataRow GetSelectedDrugRow()
        {
            if (drugsGridView.SelectedRows.Count == 0)
            {
                return null;
            }

            return (drugsGridView.SelectedRows[0].DataBoundItem as DataRowView).Row;
        }


        private void UpdatePriceLabel()
        {
            DataRow selected = GetSelectedDrugRow();

            if (selected == null)
            {
                priceValueLabel.Text = string.Empty;
                return;
            }

            decimal priceForOne = Convert.ToDecimal(selected["drug_price"]);
            priceValueLabel.Text = (amountNumericUpDown.Value * priceForOne).ToString();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (GetSelectedDrugRow() == null)
            {
                return;
            }

            DataRow selected = GetSelectedDrugRow();
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


        private void SearchButton_Click(object sender, EventArgs e)
        {
            FillTable();
        }


        private void DrugsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (GetSelectedDrugRow() == null)
            {
                priceValueLabel.Text = string.Empty;
                amountNumericUpDown.Minimum = 0;
                amountNumericUpDown.Maximum = 0;
                amountNumericUpDown.Value = 0;
                inStockValueLabel.Text = string.Empty;
                amountNumericUpDown.Enabled = false;
                saveButton.Enabled = false;
            }
            else
            {
                DataRow selected = GetSelectedDrugRow();
                int inStockAmount = Convert.ToInt32(selected["drug_amount"]);
                int price = Convert.ToInt32(selected["drug_price"]);
                
                if (inStockAmount == 0)
                {
                    amountNumericUpDown.Minimum = 0;
                    amountNumericUpDown.Maximum = 0;
                    amountNumericUpDown.Value = 0;
                    inStockValueLabel.Text = "0";
                    amountNumericUpDown.Enabled = false;
                    saveButton.Enabled = false;
                }
                else
                {
                    amountNumericUpDown.Maximum = inStockAmount;
                    amountNumericUpDown.Minimum = 1;
                    amountNumericUpDown.Value = 1;
                    inStockValueLabel.Text = inStockAmount.ToString();
                    amountNumericUpDown.Enabled = true;
                    saveButton.Enabled = true;
                }
            }

            UpdatePriceLabel();
        }


        private void AmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdatePriceLabel();
        }
    }
}
