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
    public partial class EditDrugForm : Form
    {
        private MySqlConnection connection_;
        private DataTable substancesDt_ = new DataTable();
        private MySqlDataAdapter substAdapter_;
        private int currentDrugId_ = -1;


        public EditDrugForm()
        {
            InitializeComponent();
            connection_ =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);
            FillCategories();
            FillSubstances();
            drugsTableAdapter1.Fill(pharmacyDataSet1.drugs);
            substGridView.DataSource = substancesBindingSource;
            substancesBindingSource.DataSource = substancesDt_;
            RenameColumns();
        }


        public EditDrugForm(int drugId)
        {
            InitializeComponent();
            currentDrugId_ = drugId;
            connection_ =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);
            FillCategories();
            FillSubstances();
            drugsTableAdapter1.Fill(pharmacyDataSet1.drugs);
            substGridView.DataSource = substancesBindingSource;
            substancesBindingSource.DataSource = substancesDt_;
            

            pharmacyDataSet.drugsRow drugRow =
                pharmacyDataSet1.drugs.FindBydrug_id(drugId);
            idLabel.Text = $"ID препарату: {drugId}";
            nameTextBox.Text = drugRow.drug_name;
            formTextBox.Text = drugRow.drug_form;
            manufacturerTextBox.Text = drugRow.drug_manufacturer;
            categoryComboBox.SelectedItem =
                pharmacyDataSet1.drugcategories.FindBycategory_id(drugRow.drug_category_id);
            string shelfLife = drugRow["drug_shelf_life"].ToString();
            shelfLifeTextBox.Text = shelfLife;
            prescriptionCheckBox.Checked = drugRow.drug_prescription_leave;
            priceUpDown.Value = drugRow.drug_price;
            amountUpDown.Value = drugRow.drug_amount;
            RenameColumns();
        }


        private void RenameColumns()
        {
            substGridView.Columns[0].HeaderText = "ID речовини";
            substGridView.Columns[1].HeaderText = "Назва";
            substGridView.Columns[2].HeaderText = "Опис";
        }


        private void CreateSubstancesAdapter()
        {
            // SELECT query
            MySqlCommand selectCommand = new MySqlCommand() { Connection = connection_ };
            const string SELECT_QUERY =
                @"SELECT subst_id, subst_name, drugsubst_amount
                FROM drugssubstances NATURAL JOIN substances
                WHERE drug_id = @drug_id";
            selectCommand.CommandText = SELECT_QUERY;
            substAdapter_ = new MySqlDataAdapter(selectCommand);

            // INSERT query
            const string INSERT_QUERY =
                @"INSERT INTO drugssubstances (drug_id, subst_id, drugsubst_amount) 
                VALUES (@drug_id, @subst_id, @amount)";
            substAdapter_.InsertCommand = new MySqlCommand()
            {
                Connection = connection_,
                CommandText = INSERT_QUERY
            };
            substAdapter_.InsertCommand.Parameters.Add(
                "@subst_id", MySqlDbType.Int32, 4, "subst_id");
            substAdapter_.InsertCommand.Parameters.Add(
                "@amount", MySqlDbType.TinyText, 255, "drugsubst_amount");

            // UPDATE query
            const string UPDATE_QUERY =
                @"UPDATE drugssubstances " +
                "SET drugsubst_amount = @amount " +
                "WHERE drug_id = @drug_id AND subst_id = @subst_id";
            substAdapter_.UpdateCommand = new MySqlCommand()
            {
                Connection = connection_,
                CommandText = UPDATE_QUERY
            };
            substAdapter_.UpdateCommand.Parameters.Add(
                "@subst_id", MySqlDbType.Int32, 4, "subst_id");
            substAdapter_.UpdateCommand.Parameters.Add(
                "@amount", MySqlDbType.TinyText, 255, "drugsubst_amount");

            // DELETE query
            const string DELETE_QUERY =
                @"DELETE FROM drugssubstances 
                WHERE drug_id = @drug_id AND subst_id = @subst_id";
            substAdapter_.DeleteCommand = new MySqlCommand()
            {
                Connection = connection_,
                CommandText = DELETE_QUERY
            };
            substAdapter_.DeleteCommand.Parameters.Add(
                "@subst_id", MySqlDbType.Int32, 4, "subst_id");

            selectCommand.Parameters.AddWithValue("@drug_id", currentDrugId_);
            substAdapter_.InsertCommand.Parameters.AddWithValue("@drug_id", currentDrugId_);
            substAdapter_.DeleteCommand.Parameters.AddWithValue("@drug_id", currentDrugId_);
            substAdapter_.UpdateCommand.Parameters.AddWithValue("@drug_id", currentDrugId_);
        }


        private void FillCategories()
        {
            try
            {
                drugcategoriesTableAdapter1.Fill(pharmacyDataSet1.drugcategories);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Close();
            }

            categoryComboBox.DataSource = pharmacyDataSet1.drugcategories;
            categoryComboBox.DisplayMember = "category_name";
            categoryComboBox.ValueMember = "category_id";
        }


        private void FillSubstances()
        {
            if (substAdapter_ == null)
            {
                CreateSubstancesAdapter();
            }

            try
            {
                substAdapter_.Fill(substancesDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }


        private void CreateNewDrug()
        {
            pharmacyDataSet.drugsRow drugRow = pharmacyDataSet1.drugs.NewdrugsRow();
            drugRow.drug_name = nameTextBox.Text;
            drugRow.drug_form = formTextBox.Text;
            drugRow.drug_manufacturer = manufacturerTextBox.Text;
            drugRow.drug_category_id =
                ((categoryComboBox.SelectedItem as DataRowView)
                .Row as pharmacyDataSet.drugcategoriesRow)
                .category_id;
            drugRow.drug_shelf_life = shelfLifeTextBox.Text;
            drugRow.drug_prescription_leave = prescriptionCheckBox.Checked;
            drugRow.drug_price = priceUpDown.Value;
            drugRow.drug_amount = (uint)amountUpDown.Value;
            pharmacyDataSet1.drugs.AdddrugsRow(drugRow);
        }


        private void SetExistingDrug()
        {
            pharmacyDataSet.drugsRow drugRow =
                pharmacyDataSet1.drugs.FindBydrug_id(currentDrugId_);
            drugRow.drug_name = nameTextBox.Text;
            drugRow.drug_form = formTextBox.Text;
            drugRow.drug_manufacturer = manufacturerTextBox.Text;
            drugRow.drug_category_id =
                ((categoryComboBox.SelectedItem as DataRowView)
                .Row as pharmacyDataSet.drugcategoriesRow)
                .category_id;
            drugRow.drug_shelf_life = shelfLifeTextBox.Text;
            drugRow.drug_prescription_leave = prescriptionCheckBox.Checked;
            drugRow.drug_price = priceUpDown.Value;
            drugRow.drug_amount = (uint)amountUpDown.Value;
        }


        private DataRow GetSelectedSubstRow()
        {
            if (substGridView.SelectedRows.Count == 0)
            {
                return null;
            }
            return (substGridView.SelectedRows[0].DataBoundItem as DataRowView).Row;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            drugsTableAdapter1.Fill(pharmacyDataSet1.drugs);
            
            if (currentDrugId_ == -1)
            {
                CreateNewDrug();
            }
            else
            {
                SetExistingDrug();
            }

            try
            {
                drugsTableAdapter1.Update(pharmacyDataSet1.drugs);
                if (currentDrugId_ == -1)
                {
                    const string QUERY = "SELECT MAX(drug_id) as last_id FROM drugs;";
                    connection_.Open();
                    MySqlDataReader sqlReader =
                        new MySqlCommand(QUERY, connection_).ExecuteReader();
                    sqlReader.Read();
                    currentDrugId_ = sqlReader.GetInt32(0);
                    connection_.Close();
                }
                substAdapter_.InsertCommand.Parameters["@drug_id"].Value = currentDrugId_;
                substAdapter_.Update(substancesDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
            
            Close();
        }


        private void RemoveSubstButton_Click(object sender, EventArgs e)
        {
            DataRow selected = GetSelectedSubstRow();
            if (selected == null)
            {
                return;
            }
            selected.Delete();
        }


        private void AddSubstButton_Click(object sender, EventArgs e)
        {
            AddSubstanceToDrugForm form =
                new AddSubstanceToDrugForm(substancesDt_, currentDrugId_);
            form.ShowDialog();
        }


        private void SubstGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataRow selected = GetSelectedSubstRow();
            if (selected == null)
            {
                return;
            }

            substAmountTextBox.Text = selected.Field<string>("drugsubst_amount");
        }


        private void SaveAmountString_Click(object sender, EventArgs e)
        {
            DataRow selected = GetSelectedSubstRow();
            if (selected == null)
            {
                return;
            }

            selected["drugsubst_amount"] = substAmountTextBox.Text;
        }


        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
