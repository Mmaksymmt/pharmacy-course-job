using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy.AdminForms
{
    public partial class AdminMainForm : Form
    {
        private MySqlConnection connection_;
        private DataTable drugsDt_ = new DataTable();
        private DataTable categoriesDt_ = new DataTable();
        private DataTable substancesDt_ = new DataTable();
        private int adminId_;


        public AdminMainForm(int adminId)
        {
            InitializeComponent();
            drugsTableBindingSource.DataSource = drugsDt_;
            drugsGridView.DataSource = drugsTableBindingSource;
            substTableBindingSource.DataSource = substancesDt_;
            substancesGridView.DataSource = substTableBindingSource;
            connection_ =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);
            FillCategories();
            FillOrderingFields();
            categoryFilterComboBox.SelectedItem = null;
            drugsGridView.Columns[0].HeaderText = "ID ліків";
            drugsGridView.Columns[1].HeaderText = "Назва";
            drugsGridView.Columns[2].HeaderText = "Категорія";
            drugsGridView.Columns[3].HeaderText = "Форма випуску";
            drugsGridView.Columns[4].HeaderText = "Виробник";
            drugsGridView.Columns[5].HeaderText = "Термін придатності";
            drugsGridView.Columns[6].HeaderText = "За рецептом";
            drugsGridView.Columns[7].HeaderText = "Ціна";
            drugsGridView.Columns[8].HeaderText = "На складі";

            substancesGridView.Columns[0].HeaderText = "Назва речовини";
            substancesGridView.Columns[1].HeaderText = "Кількість";
            substancesGridView.Columns[2].HeaderText = "Опис";
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
                    "drug_manufacturer, drug_shelf_life, drug_prescription_leave, drug_price, " +
                    "drug_amount " +
                    "FROM drugs INNER JOIN drugcategories " +
                    "ON drugs.drug_category_id = drugcategories.category_id " +
                    "WHERE LOCATE(@name_filter, drug_name) > 0 " +
                    "AND LOCATE(@manuf_filter, drug_manufacturer) > 0 " +
                    "AND drug_price >= @min_price AND drug_price <= @max_price " +
                    "AND (drug_prescription_leave = 0 " +
                    "   OR drug_prescription_leave != @presc_filter) " +
                    "AND drug_amount >= @amount_filter " +
                    $"ORDER BY {orderField} {orderDirection}";
            }
            else
            {
                query = "SELECT drug_id, drug_name, drugcategories.category_name, drug_form, " +
                    "drug_manufacturer, drug_shelf_life, drug_prescription_leave, drug_price, " +
                    "drug_amount " +
                    "FROM drugs INNER JOIN drugcategories " +
                    "ON drugs.drug_category_id = drugcategories.category_id " +
                    "WHERE LOCATE(@name_filter, drug_name) > 0 " +
                    "AND LOCATE(@manuf_filter, drug_manufacturer) > 0 " +
                    "AND drug_price >= @min_price AND drug_price <= @max_price " +
                    "AND (drug_prescription_leave = 0 " +
                    "   OR drug_prescription_leave != @presc_filter) " +
                    "AND drug_amount >= @amount_filter " +
                    "AND drug_category_id = @category_id " +
                    $"ORDER BY {orderField} {orderDirection}";
                int categoryId = Convert.ToInt32(categoryRow["category_id"]);
                command.Parameters.AddWithValue("@category_id", categoryId);
            }
            if (substTextBox.Text.Length != 0)
            {
                query = $"SELECT T.drug_id, T.drug_name, T.category_name, drug_form, " +
                    $"drug_manufacturer, drug_shelf_life, drug_prescription_leave, " +
                    $"drug_price, drug_amount " +
                    $"FROM drugssubstances INNER JOIN ({query}) AS T " +
                    $"ON drugssubstances.drug_id = T.drug_id INNER JOIN substances " +
                    $"ON drugssubstances.subst_id = substances.subst_id " +
                    $"WHERE LOCATE(@subst_str, subst_name) > 0;";
            }
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
            DataRow selectedRow = GetSelectedDataRow();

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


        private DataRow GetSelectedDataRow()
        {
            if (drugsGridView.SelectedRows.Count == 0)
            {
                return null;
            }

            DataRow dr = (drugsGridView.SelectedRows[0].DataBoundItem as DataRowView).Row;
            return dr;
        }


        #region form events
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void AddDrugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDrugForm form = new EditDrugForm();
            form.ShowDialog();
            FillDrugs();
        }


        private void EditDrugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow selected = GetSelectedDataRow();

            if (selected == null)
            {
                return;
            }

            EditDrugForm form = new EditDrugForm(Convert.ToInt32(selected["drug_id"]));
            form.ShowDialog();
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


        private void DrugsGridView_SelectionChanged(object sender, EventArgs e)
        {
            FillSubstances();
        }


        private void DeleteDrugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow selectedRow = GetSelectedDataRow();
            if (selectedRow == null)
            {
                return;
            }

            int selectedId = Convert.ToInt32(selectedRow["drug_id"]);
            const string DEL_QUERY = "DELETE FROM drugs WHERE drug_id = @drug_id";
            MySqlCommand delCommand = new MySqlCommand(DEL_QUERY, connection_);
            delCommand.Parameters.AddWithValue("drug_id", selectedId);

            try
            {
                connection_.Open();
                delCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
            connection_.Close();
            FillDrugs();
        }


        private void PurchaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseListForm form = new PurchaseListForm();
            form.ShowDialog();
        }


        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDrugs();
        }


        private void DescendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FillDrugs();
        }


        private void FilterButton_Click(object sender, EventArgs e)
        {
            FillDrugs();
            FillSubstances();
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
