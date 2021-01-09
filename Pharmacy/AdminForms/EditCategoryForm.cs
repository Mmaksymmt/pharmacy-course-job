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
    public partial class EditCategoryForm : Form
    {
        private int categoryId_ = -1;

        public EditCategoryForm(DataRow categoryRow = null)
        {
            InitializeComponent();
            if (categoryRow != null)
            {
                categoryId_ = categoryRow.Field<int>("category_id");
                nameTextBox.Text =
                    categoryRow.Field<string>("category_name");
                descriptionTextBox.Text =
                    categoryRow.Field<string>("category_description");
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введіть назву категорії!");
                return;
            }

            try
            {
                if (categoryId_ == -1)
                {
                    categoriesTableAdapter1.InsertQuery(
                        nameTextBox.Text,
                        descriptionTextBox.Text);
                }
                else
                {
                    categoriesTableAdapter1.UpdateQuery(
                        nameTextBox.Text,
                        descriptionTextBox.Text,
                        categoryId_);
                }
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
