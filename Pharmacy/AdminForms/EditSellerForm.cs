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
    public partial class EditSellerForm : Form
    {
        private DataTable sellersDt_;
        private DataRow seller_;


        public EditSellerForm(DataTable sellers, DataRow seller = null)
        {
            InitializeComponent();
            sellersDt_ = sellers;
            seller_ = seller;

            if (seller != null)
            {
                nameTextBox.Text = seller.Field<string>("seller_name");
                surnameTextBox.Text = seller.Field<string>("seller_surname");
                patronymTextBox.Text = seller.Field<string>("seller_patronymic");
                switch (seller.Field<string>("seller_gender"))
                {
                    case "Ч":
                        genderComboBox.SelectedIndex = 0;
                        break;
                    case "Ж":
                        genderComboBox.SelectedIndex = 1;
                        break;
                    default:
                        throw new Exception("Стать у неправильному форматі");
                }
                birthdatePicker.Value = seller.Field<DateTime>("seller_dob");
                hiredatePicker.Value = seller.Field<DateTime>("seller_hiring_date");
                passwordTextBox.Text = seller.Field<string>("seller_password");
                adminCheckBox.Checked = seller.Field<bool>("seller_admin");
                DateTime? dismissalDate = seller.Field<DateTime?>("seller_dismissal_date");
                if (dismissalDate == null)
                {
                    dismissalCheckBox.Checked = false;
                }
                else
                {
                    dismissalCheckBox.Checked = true;
                    dismissalDatePicker.Value = dismissalDate.Value;
                }
            }
            else
            {
                genderComboBox.SelectedIndex = 0;
            }
            dismissalDatePicker.Enabled = dismissalCheckBox.Checked;
        }


        private void DismissalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dismissalDatePicker.Enabled = dismissalCheckBox.Checked;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime? dismissalDate = null;
            if (dismissalCheckBox.Checked)
            {
                dismissalDate = dismissalDatePicker.Value;
            }
            if (seller_ == null)
            {
                sellersTableAdapter1.Insert(
                    nameTextBox.Text,
                    surnameTextBox.Text,
                    patronymTextBox.Text,
                    genderComboBox.Text,
                    birthdatePicker.Value,
                    hiredatePicker.Value,
                    passwordTextBox.Text,
                    adminCheckBox.Checked,
                    dismissalDate);
            }
            else
            {
                sellersTableAdapter1.Update(
                    nameTextBox.Text,
                    surnameTextBox.Text,
                    patronymTextBox.Text,
                    genderComboBox.Text,
                    birthdatePicker.Value,
                    hiredatePicker.Value,
                    passwordTextBox.Text,
                    adminCheckBox.Checked,
                    dismissalDate,
                    seller_.Field<int>("seller_id"));
            }
            Close();
        }
    }
}
