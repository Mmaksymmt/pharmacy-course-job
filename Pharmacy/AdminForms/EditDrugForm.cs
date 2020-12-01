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
        //private MySqlConnection connection_;
        private int currentDrugId_ = -1;


        public EditDrugForm()
        {
            InitializeComponent();
            FillCategories();   
        }


        public EditDrugForm(int drugId)
        {
            InitializeComponent();
            FillCategories();
            currentDrugId_ = drugId;
            drugsTableAdapter1.Fill(pharmacyDataSet1.drugs);

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

            //TODO: fix shelf life DBNull
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }

            Close();
        }
    }
}
