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
    public partial class SubstancesForm : Form
    {
        private MySqlConnection connection_;
        private DataTable substDt_ = new DataTable();


        public SubstancesForm()
        {
            InitializeComponent();
            substGridView.DataSource = substBindingSource;
            substBindingSource.DataSource = substDt_;
            connection_ = new MySqlConnection(
                Properties.Settings.Default.pharmacyConnectionString);
            FillOrderingFields();
            FillSubstances();

            foreach (var col in substGridView.Columns)
            {
                (col as DataGridViewColumn).SortMode =
                    DataGridViewColumnSortMode.NotSortable;
            }
            substGridView.Columns[0].HeaderText = "ID";
            substGridView.Columns[1].HeaderText = "Назва";
            substGridView.Columns[2].HeaderText = "Опис";
        }


        private void FillOrderingFields()
        {
            List<OrderFieldItem> orderFields = new List<OrderFieldItem>()
            {
                new OrderFieldItem("subst_id", "ID"),
                new OrderFieldItem("subst_name", "Назвою")
            };
            orderByComboBox.DataSource = orderFields;
            orderByComboBox.DisplayMember = nameof(OrderFieldItem.Pseudonym);
            orderByComboBox.SelectedIndex = 0;
        }


        private void FillSubstances()
        {
            MySqlCommand command = new MySqlCommand() { Connection = connection_ };
            string orderField = (orderByComboBox.SelectedItem as OrderFieldItem).FieldName;
            string orderDirection = descendingCheckBox.Checked ? "DESC" : "ASC";
            string query;
            int substId;
            bool idParsed = int.TryParse(idFilterTextBox.Text, out substId);
            if (idParsed)
            {
                query =
                    @"SELECT * FROM substances " +
                    "WHERE LOCATE(@subst_name, subst_name) > 0 AND subst_id = @subst_id " +
                    $"ORDER BY {orderField} {orderDirection}";
                command.Parameters.AddWithValue("@subst_id", substId);
            }
            else
            {
                query =
                    "SELECT * FROM substances " +
                    "WHERE LOCATE(@subst_name, subst_name) > 0 " +
                    $"ORDER BY {orderField} {orderDirection}";
            }
            command.CommandText = query;
            command.Parameters.AddWithValue("@subst_name", nameFilterTextBox.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            substDt_.Rows.Clear();
            try
            {
                adapter.Fill(substDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }


        private DataRow GetSelectedDataRow()
        {
            if (substGridView.SelectedRows.Count == 0)
            {
                return null;
            }

            DataRow dr = (substGridView.SelectedRows[0].DataBoundItem as DataRowView).Row;
            return dr;
        }


        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSubstances();
        }


        private void DescendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FillSubstances();
        }


        private void FilterButton_Click(object sender, EventArgs e)
        {
            FillSubstances();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            string str = searchString.Text;

            foreach (var r in substGridView.Rows)
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
                        cell.Style.BackColor = substGridView.DefaultCellStyle.BackColor;
                        cell.Style.SelectionBackColor =
                            substGridView.DefaultCellStyle.SelectionBackColor;
                    }
                }
            }
        }


        private void DeleteSubstButton_Click(object sender, EventArgs e)
        {
            DataRow selectedRow = GetSelectedDataRow();
            if (selectedRow == null)
            {
                return;
            }

            int selectedId = Convert.ToInt32(selectedRow["subst_id"]);
            const string DEL_QUERY = "DELETE FROM substances WHERE subst_id = @subst_id";
            MySqlCommand delCommand = new MySqlCommand(DEL_QUERY, connection_);
            delCommand.Parameters.AddWithValue("subst_id", selectedId);

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
            FillSubstances();
        }


        private void EditSubstButton_Click(object sender, EventArgs e)
        {
            DataRow selected = GetSelectedDataRow();
            if (selected == null)
            {
                return;
            }

            EditSubstanceForm form =
                new EditSubstanceForm(selected);
            form.ShowDialog();
            FillSubstances();
        }


        private void AddSubstButton_Click(object sender, EventArgs e)
        {
            EditSubstanceForm form =
                new EditSubstanceForm();
            form.ShowDialog();
            FillSubstances();
        }
    }
}
