using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            adminId_ = adminId;
            connection_ =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);
            drugsGridView.DataSource = tableBindingSource;
            tableBindingSource.DataSource = drugsDt_;
            substancesBindingSource.DataSource = substancesDt_;
            substancesGridView.DataSource = substancesBindingSource;
            FillCategories();
            categoryComboBox.SelectedItem = null;
            FillDrugs();
        }


        private void FillDrugs()
        {
            DataRow categoryRow = (categoryComboBox.SelectedItem as DataRowView)?.Row;
            string query;
            MySqlCommand command = new MySqlCommand() { Connection = connection_ };

            if (categoryRow == null)
            {
                query = "SELECT drug_id, drug_name, drugcategories.category_name, " +
                    "drug_form, drug_manufacturer, drug_prescription_leave, drug_price, " +
                    "drug_amount FROM drugs INNER JOIN drugcategories " +
                    "ON drugs.drug_category_id = drugcategories.category_id " +
                    "WHERE LOCATE(@name_filter, drug_name) > 0";
            }
            else
            {
                query = "SELECT drug_id, drug_name, drugcategories.category_name, " +
                    "drug_form, drug_manufacturer, drug_prescription_leave, drug_price, " +
                    "drug_amount FROM drugs INNER JOIN drugcategories " +
                    "ON drugs.drug_category_id = drugcategories.category_id " +
                    "WHERE LOCATE(@name_filter, drug_name) > 0 " +
                    "AND drug_category_id = @category_id";
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

            command.Parameters.AddWithValue("@name_filter", nameTextBox.Text);
            command.Parameters.AddWithValue("@subst_str", substTextBox.Text);
            command.CommandText = query;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            drugsDt_.Rows.Clear();

            try
            {
                adapter.Fill(drugsDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Drugs Error: {ex.Message}");
                throw;
            }
        }


        private void FillCategories()
        {
            string query = "SELECT * FROM drugcategories;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection_);
            categoriesDt_.Clear();

            try
            {
                adapter.Fill(categoriesDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Categories Error: {ex.Message}");
                throw;
            }

            categoryComboBox.DisplayMember = "category_name";
            categoryComboBox.ValueMember = "category_id";
            categoryComboBox.DataSource = categoriesDt_;
            categoryComboBox.SelectedItem = null;
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


        private DataRow GetSelectedDataRow()
        {
            if (drugsGridView.SelectedRows.Count == 0)
            {
                return null;
            }

            DataRow dr = (drugsGridView.SelectedRows[0].DataBoundItem as DataRowView).Row;
            return dr;
        }


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
            FillDrugs();
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
    }
}
