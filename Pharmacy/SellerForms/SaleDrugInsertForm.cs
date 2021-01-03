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
        private DataTable substancesDt_ = new DataTable();
        private int currentSaleId_;


        public SaleDrugInsertForm(int saleId)
        {
            InitializeComponent();
            drugsTableBindingSource.DataSource = drugsDt_;
            drugsGridView.DataSource = drugsTableBindingSource;
            substTableBindingSource.DataSource = substancesDt_;
            substancesGridView.DataSource = substTableBindingSource;
            currentSaleId_ = saleId;
            connection_ =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);
            FillCategories();
            FillOrderingFields();
            //FillTable();
            categoryFilterComboBox.SelectedItem = null;
        }


        private void FillOrderingFields()
        {
            List<OrderFieldItem> orderFields = new List<OrderFieldItem>()
            {
                new OrderFieldItem("drug_id", "ID"),
                new OrderFieldItem("drug_name", "Назвою"),
                new OrderFieldItem("drug_price", "Ціною"),
                new OrderFieldItem("drug_amount", "Кількістю на складі")
            };
            orderByComboBox.DataSource = orderFields;
            orderByComboBox.DisplayMember = nameof(OrderFieldItem.Pseudonym);
            orderByComboBox.SelectedIndex = 0;
        }


        private void FillDrugs()
        {
            DataRow categoryRow = (categoryFilterComboBox.SelectedItem as DataRowView)?.Row;
            string query;
            MySqlCommand command = new MySqlCommand() { Connection = connection_ };
            string orderField = (orderByComboBox.SelectedItem as OrderFieldItem).FieldName;
            string orderDirection = descendingCheckBox.Checked ? "DESC" : "ASC";
            decimal minPriceFilter;
            bool minPriceParced =
                decimal.TryParse(minPriceFilterTextBox.Text, out minPriceFilter);
            decimal maxPriceFilter;
            bool maxPriceParced =
                decimal.TryParse(maxPriceFilterTextBox.Text, out maxPriceFilter);
            if (!minPriceParced)
            {
                minPriceFilter = 0;
            }
            if (!maxPriceParced)
            {
                maxPriceFilter = decimal.MaxValue;
            }

            if (categoryRow == null)
            {
                query = "SELECT drug_id, drug_name, drugcategories.category_name, drug_form, " +
                    "drug_manufacturer, drug_prescription_leave, drug_price, drug_amount " +
                    "FROM drugs INNER JOIN drugcategories " +
                    "ON drugs.drug_category_id = drugcategories.category_id " +
                    "WHERE LOCATE(@name_filter, drug_name) > 0 " +
                    "AND LOCATE(@manuf_filter, drug_manufacturer) > 0 " +
                    "AND drug_price >= @min_price AND drug_price <= @max_price " +
                    "AND drug_prescription_leave = @presc_filter " +
                    "AND drug_amount >= @amount_filter " +
                    "AND drug_id NOT IN " +
                    "(SELECT drug_id FROM salesdrugs WHERE salesdrugs.sale_id = @sale_id) " +
                    $"ORDER BY {orderField} {orderDirection}";
            }
            else
            {
                query = "SELECT drug_id, drug_name, drugcategories.category_name, drug_form, " +
                    "drug_manufacturer, drug_prescription_leave, drug_price, drug_amount " +
                    "FROM drugs INNER JOIN drugcategories " +
                    "ON drugs.drug_category_id = drugcategories.category_id " +
                    "WHERE LOCATE(@name_filter, drug_name) > 0 " +
                    "AND LOCATE(@manuf_filter, drug_manufacturer) > 0 " +
                    "AND drug_price >= @min_price AND drug_price <= @max_price " +
                    "AND drug_prescription_leave = @presc_filter " +
                    "AND drug_amount >= @amount_filter " +
                    "AND drug_category_id = @category_id AND drug_id NOT IN " +
                    "(SELECT drug_id FROM salesdrugs WHERE salesdrugs.sale_id = @sale_id) " +
                    $"ORDER BY {orderField} {orderDirection}";
                int categoryId = Convert.ToInt32(categoryRow["category_id"]);
                command.Parameters.AddWithValue("@category_id", categoryId);
            }
            if (substTextBox.Text.Length != 0)
            {
                query = $"SELECT T.drug_id, T.drug_name, T.category_name, drug_form, " +
                    $"drug_manufacturer, drug_prescription_leave, drug_price, drug_amount " +
                    $"FROM drugssubstances INNER JOIN ({query}) AS T " +
                    $"ON drugssubstances.drug_id = T.drug_id INNER JOIN substances " +
                    $"ON drugssubstances.subst_id = substances.subst_id " +
                    $"WHERE LOCATE(@subst_str, subst_name) > 0;";
            }
            command.Parameters.AddWithValue("@sale_id", currentSaleId_);
            command.Parameters.AddWithValue("@name_filter", nameFilterTextBox.Text);
            command.Parameters.AddWithValue("@manuf_filter", manufFilterTextBox.Text);
            command.Parameters.AddWithValue("@min_price", minPriceFilter);
            command.Parameters.AddWithValue("@max_price", maxPriceFilter);
            command.Parameters.AddWithValue("@subst_str", substTextBox.Text);
            command.Parameters.AddWithValue("@presc_filter", prescriptionFilterCheckBox.Checked);
            command.Parameters.AddWithValue(
                "@amount_filter",
                leftInStockFilterCheckBox.Checked ? 1 : 0);
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

            foreach (var col in drugsGridView.Columns)
            {
                (col as DataGridViewColumn).SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
            categoryFilterComboBox.DisplayMember = "category_name";
            categoryFilterComboBox.ValueMember = "category_id";
            categoryFilterComboBox.DataSource = categoriesDt_;
            categoryFilterComboBox.SelectedItem = null;
        }


        private void FillSubstances()
        {
            substancesDt_.Rows.Clear();
            DataRow selectedRow = GetSelectedDrugRow();

            if (selectedRow == null)
            {
                return;
            }

            MySqlConnection connection =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);
            int selectedDrugId = Convert.ToInt32(selectedRow["drug_id"]);
            const string QUERY = "SELECT subst_name, drugsubst_amount, subst_description FROM drugssubstances INNER JOIN substances ON drugssubstances.subst_id = substances.subst_id WHERE drugssubstances.drug_id = @drug_id;";
            MySqlCommand command = new MySqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("drug_id", selectedDrugId);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            try
            {
                adapter.Fill(substancesDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Substances Error: {ex.Message}");
                throw;
            }
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


        #region form events
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


        private void FilterButton_Click(object sender, EventArgs e)
        {
            FillDrugs();
            FillSubstances();
        }


        private void DrugsGridView_SelectionChanged(object sender, EventArgs e)
        {
            FillSubstances();

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


        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDrugs();
        }


        private void DescendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FillDrugs();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            string str = searchString.Text;

            foreach (var r in drugsGridView.Rows)
            {
                foreach (DataGridViewCell cell in (r as DataGridViewRow).Cells)
                {
                    if (str != "" && cell.Value.ToString().Contains(str))
                    {
                        cell.Style.BackColor = Color.Orange;
                        cell.Style.SelectionBackColor = Color.Orange;
                    }
                    else
                    {
                        cell.Style.BackColor = drugsGridView.DefaultCellStyle.BackColor;
                        cell.Style.SelectionBackColor =
                            drugsGridView.DefaultCellStyle.SelectionBackColor;
                    }
                }
            }
        }
        #endregion


        private class OrderFieldItem
        {
            public string FieldName { get; set; }
            public string Pseudonym { get; set; }

            public OrderFieldItem(string fieldName, string pseudonym)
            {
                FieldName = fieldName;
                Pseudonym = pseudonym;
            }
        }
    }
}
