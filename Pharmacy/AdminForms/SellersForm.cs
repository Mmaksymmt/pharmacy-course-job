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
    public partial class SellersForm : Form
    {
        private MySqlConnection connection_;
        private MySqlDataAdapter filterAdapter_ = new MySqlDataAdapter();


        public SellersForm()
        {
            InitializeComponent();
            genderFilterComboBox.SelectedIndex = 0;
            jobFilterComboBox.SelectedIndex = 0;

            connection_ = new MySqlConnection(
                Properties.Settings.Default.pharmacyConnectionString);
            FillOrderingFields();
            FillSellers();
        }


        private void FillOrderingFields()
        {
            List<OrderFieldItem> orderFields = new List<OrderFieldItem>()
            {
                new OrderFieldItem("seller_id", "ID"),
                new OrderFieldItem("seller_name", "ім'ям"),
                new OrderFieldItem("seller_surname", "прізвищем"),
                new OrderFieldItem("seller_patronymic", "по-батькові"),
                new OrderFieldItem("seller_dob", "датою народження"),
                new OrderFieldItem("seller_hiring_date", "датою найму"),
                new OrderFieldItem("seller_dismissal_date", "датою звільнення")
            };
            orderByComboBox.DataSource = orderFields;
            orderByComboBox.DisplayMember = nameof(OrderFieldItem.Pseudonym);
            orderByComboBox.SelectedIndex = 0;
        }


        private void FillSellers()
        {
            MySqlCommand command = new MySqlCommand() { Connection = connection_ };
            string orderField = (orderByComboBox.SelectedItem as OrderFieldItem).FieldName;
            string orderDirection = descendingCheckBox.Checked ? "DESC" : "ASC";
            int sellerId;
            bool idParsed = int.TryParse(idFilterTextBox.Text, out sellerId);
            string selectQuery;
            if (idParsed)
            {
                selectQuery =
                    "SELECT * FROM sellers " +
                    "WHERE LOCATE(@name, seller_name) > 0 " +
                    "   AND LOCATE(@surname, seller_surname) > 0 " +
                    "   AND LOCATE(@patronymic, seller_patronymic) > 0 " +
                    "   AND LOCATE(seller_gender, @genders) > 0 " +
                    "   AND (!@by_birth OR (seller_dob BETWEEN @dob_min AND @dob_max)) " +
                    "   AND (!@by_hire OR (seller_hiring_date BETWEEN @hire_min AND @hire_max)) " +
                    "   AND (seller_admin = @show_admin OR seller_admin = @show_seller) " +
                    "   AND (!@by_dismiss OR (seller_dismissal_date BETWEEN @dismiss_min AND @dismiss_max))" +
                    "   AND seller_id = @id " +
                    $"ORDER BY {orderField} {orderDirection}";
            }
            else
            {
                selectQuery =
                    "SELECT * FROM sellers " +
                    "WHERE LOCATE(@name, seller_name) > 0 " +
                    "   AND LOCATE(@surname, seller_surname) > 0 " +
                    "   AND LOCATE(@patronymic, seller_patronymic) > 0 " +
                    "   AND LOCATE(seller_gender, @genders) > 0 " +
                    "   AND (!@by_birth OR (seller_dob BETWEEN @dob_min AND @dob_max)) " +
                    "   AND (!@by_hire OR (seller_hiring_date BETWEEN @hire_min AND @hire_max)) " +
                    "   AND (seller_admin = @show_admin OR seller_admin = @show_seller) " +
                    "   AND (!@by_dismiss OR (seller_dismissal_date BETWEEN @dismiss_min AND @dismiss_max))" +
                    $"ORDER BY {orderField} {orderDirection}";
            }
            command.CommandText = selectQuery;
            command.Parameters.AddWithValue("@id", sellerId);
            command.Parameters.AddWithValue("@name", nameFilterTextBox.Text);
            command.Parameters.AddWithValue("@surname", surnameFilterTextBox.Text);
            command.Parameters.AddWithValue("@patronymic", patronFilterTextBox.Text);
            string gender = "ЧЖ";
            if (genderFilterComboBox.SelectedItem.ToString() == "Ч" ||
                genderFilterComboBox.SelectedItem.ToString() == "Ж")
            {
                gender = genderFilterComboBox.SelectedItem.ToString();
            }
            command.Parameters.AddWithValue("@genders", gender);
            command.Parameters.AddWithValue("@by_birth", birthdateFilterCheckBox.Checked);
            command.Parameters.AddWithValue("@dob_min", birthdateMinPicker.Value);
            command.Parameters.AddWithValue("@dob_max", birthdateMaxPicker.Value);
            command.Parameters.AddWithValue("@by_hire", hiredateFilterCheckBox.Checked);
            command.Parameters.AddWithValue("@hire_min", hiredateMinPicker.Value);
            command.Parameters.AddWithValue("@hire_max", hiredateMaxPicker.Value);
            command.Parameters.AddWithValue("@by_dismiss", dismissdateFilterCheckbox.Checked);
            command.Parameters.AddWithValue("@dismiss_min", dismissMinPicker.Value);
            command.Parameters.AddWithValue("@dismiss_max", dismissMaxPicker.Value);
            bool job1 = true;
            bool job2 = false;
            switch (jobFilterComboBox.SelectedItem.ToString())
            {
                case "Адміністратор":
                    job1 = job2 = true;
                    break;
                case "Продавець":
                    job1 = job2 = false;
                    break;
            }
            command.Parameters.AddWithValue("@show_admin", job1);
            command.Parameters.AddWithValue("@show_seller", job2);

            filterAdapter_.SelectCommand = command;
            pharmacyDataSet1.sellers.Rows.Clear();
            try
            {
                filterAdapter_.Fill(pharmacyDataSet1.sellers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }


        private DataRow GetSelectedRow()
        {
            if (sellersGridView.SelectedRows.Count == 0)
            {
                return null;
            }

            return ((sellersGridView.SelectedRows[0].DataBoundItem) as DataRowView).Row;
        }


        private void BirthdateFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            birthdateMinPicker.Enabled = birthdateMaxPicker.Enabled =
                birthdateFilterCheckBox.Checked;
        }


        private void HiredateFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            hiredateMinPicker.Enabled = hiredateMaxPicker.Enabled =
                hiredateFilterCheckBox.Checked;
        }


        private void DismissdateFilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dismissMinPicker.Enabled = dismissMaxPicker.Enabled =
                dismissdateFilterCheckbox.Checked;
        }


        private void FilterButton_Click(object sender, EventArgs e)
        {
            FillSellers();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            string str = searchString.Text;

            foreach (var r in sellersGridView.Rows)
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
                        cell.Style.BackColor = sellersGridView.DefaultCellStyle.BackColor;
                        cell.Style.SelectionBackColor =
                            sellersGridView.DefaultCellStyle.SelectionBackColor;
                    }
                }
            }
        }


        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSellers();
        }


        private void DescendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FillSellers();
        }


        private void DeleteSellerButton_Click(object sender, EventArgs e)
        {
            DataRow selected = GetSelectedRow();
            if (selected == null)
            {
                return;
            }

            try
            {
                selected.Delete();
                sellersTableAdapter1.Update(pharmacyDataSet1.sellers);
                FillSellers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося видалити працівника");
                FillSellers();
            }
        }


        private void EditSellerButton_Click(object sender, EventArgs e)
        {
            DataRow selected = GetSelectedRow();
            if (selected == null)
            {
                return;
            }

            EditSellerForm form =
                new EditSellerForm(pharmacyDataSet1.sellers, selected);
            form.ShowDialog();
            sellersTableAdapter1.Update(pharmacyDataSet1.sellers);
            FillSellers();
        }


        private void AddSellerButton_Click(object sender, EventArgs e)
        {
            EditSellerForm form =
                new EditSellerForm(pharmacyDataSet1.sellers);
            form.ShowDialog();
            sellersTableAdapter1.Update(pharmacyDataSet1.sellers);
            FillSellers();
        }


        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            DataRow selected = GetSelectedRow();
            if (selected == null)
            {
                return;
            }

            SellerStatisticsForm form =
                new SellerStatisticsForm(selected);
            form.Show();
        }
    }
}
