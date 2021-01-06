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
    public partial class CategoriesForm : Form
    {
        private MySqlConnection connection_;
        private DataTable categoriesDt_ = new DataTable();


        public CategoriesForm()
        {
            InitializeComponent();
            categoriesGridView.DataSource = categoriesBindingSource;
            categoriesBindingSource.DataSource = categoriesDt_;
            connection_ = new MySqlConnection(
                Properties.Settings.Default.pharmacyConnectionString);
            FillOrderingFields();
            FillCategories();

            foreach (var col in categoriesGridView.Columns)
            {
                (col as DataGridViewColumn).SortMode =
                    DataGridViewColumnSortMode.NotSortable;
            }
            categoriesGridView.Columns[0].HeaderText = "ID";
            categoriesGridView.Columns[1].HeaderText = "Назва";
            categoriesGridView.Columns[2].HeaderText = "Опис";
        }


        private void FillOrderingFields()
        {
            List<OrderFieldItem> orderFields = new List<OrderFieldItem>()
            {
                new OrderFieldItem("category_id", "ID"),
                new OrderFieldItem("category_name", "Назвою")
            };
            orderByComboBox.DataSource = orderFields;
            orderByComboBox.DisplayMember = nameof(OrderFieldItem.Pseudonym);
            orderByComboBox.SelectedIndex = 0;
        }


        private void FillCategories()
        {
            MySqlCommand command = new MySqlCommand() { Connection = connection_ };
            string orderField = (orderByComboBox.SelectedItem as OrderFieldItem).FieldName;
            string orderDirection = descendingCheckBox.Checked ? "DESC" : "ASC";
            string query;
            int categoriesId;
            bool idParsed = int.TryParse(idFilterTextBox.Text, out categoriesId);
            if (idParsed)
            {
                query =
                    "SELECT * FROM drugcategories " +
                    "WHERE LOCATE(@category_name, category_name) > 0 " +
                    "   AND category_id = @category_id " +
                    $"ORDER BY {orderField} {orderDirection}";
                command.Parameters.AddWithValue("@category_id", categoriesId);
            }
            else
            {
                query =
                    "SELECT * FROM drugcategories " +
                    "WHERE LOCATE(@category_name, category_name) > 0 " +
                    $"ORDER BY {orderField} {orderDirection}";
            }
            command.CommandText = query;
            command.Parameters.AddWithValue("@category_name", nameFilterTextBox.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            categoriesDt_.Rows.Clear();
            try
            {
                adapter.Fill(categoriesDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }


        private DataRow GetSelectedDataRow()
        {
            if (categoriesGridView.SelectedRows.Count == 0)
            {
                return null;
            }

            DataRow dr = (categoriesGridView.SelectedRows[0].DataBoundItem as DataRowView).Row;
            return dr;
        }


        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCategories();
        }


        private void DescendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FillCategories();
        }


        private void FilterButton_Click(object sender, EventArgs e)
        {
            FillCategories();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            string str = searchString.Text;

            foreach (var r in categoriesGridView.Rows)
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
                        cell.Style.BackColor = categoriesGridView.DefaultCellStyle.BackColor;
                        cell.Style.SelectionBackColor =
                            categoriesGridView.DefaultCellStyle.SelectionBackColor;
                    }
                }
            }
        }


        private void DeletecategoriesButton_Click(object sender, EventArgs e)
        {
            DataRow selectedRow = GetSelectedDataRow();
            if (selectedRow == null)
            {
                return;
            }

            int selectedId = Convert.ToInt32(selectedRow["category_id"]);
            const string DEL_QUERY =
@"DELETE FROM drugcategories
WHERE category_id = @category_id";
            MySqlCommand delCommand = new MySqlCommand(DEL_QUERY, connection_);
            delCommand.Parameters.AddWithValue("category_id", selectedId);

            try
            {
                connection_.Open();
                delCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            connection_.Close();
            FillCategories();
        }


        private void EditcategoriesButton_Click(object sender, EventArgs e)
        {
            DataRow selected = GetSelectedDataRow();
            if (selected == null)
            {
                return;
            }

            EditCategoryForm form =
                new EditCategoryForm(selected);
            form.ShowDialog();
            FillCategories();
        }


        private void AddcategoriesButton_Click(object sender, EventArgs e)
        {
            EditCategoryForm form =
                new EditCategoryForm();
            form.ShowDialog();
            FillCategories();
        }
    }
}
