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
    public partial class EditSubstanceForm : Form
    {
        private int substId_ = -1;

        public EditSubstanceForm(DataRow substRow = null)
        {
            InitializeComponent();
            if (substRow != null)
            {
                substId_ = substRow.Field<int>("subst_id");
                nameTextBox.Text = substRow.Field<string>("subst_name");
                descriptionTextBox.Text = substRow.Field<string>("subst_description");
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (substId_ == -1)
                {
                    substancesTableAdapter1.InsertQuery(
                        nameTextBox.Text,
                        descriptionTextBox.Text);
                }
                else
                {
                    substancesTableAdapter1.UpdateQuery(
                        nameTextBox.Text,
                        descriptionTextBox.Text,
                        substId_);
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
