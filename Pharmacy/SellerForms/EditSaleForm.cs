using MySql.Data.MySqlClient;
using Pharmacy.SellerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class EditSaleForm : Form
    {
        MySqlConnection connection_;
        DataTable salesDrugsDataTable = new DataTable();
        MySqlDataAdapter salesDrugsAdapter;
        private int sellerId_;
        private int currentSaleId_;
        private bool isCreating_;


        public EditSaleForm(int sellerId)
        {
            InitializeComponent();
            isCreating_ = true;
            sellerId_ = sellerId;
            salesdrugsBindingSource.DataSource = salesDrugsDataTable;
            salesDrugsGridView.DataSource = salesdrugsBindingSource;
            connection_ =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);

            InsertSale();
            CreateAdapter();
            FillData();
            DisableUnnecessaryControls();
            salesDrugsGridView.Columns[0].HeaderText = "ID ліків";
            salesDrugsGridView.Columns[1].HeaderText = "Назва";
            salesDrugsGridView.Columns[2].HeaderText = "Кількість";
            salesDrugsGridView.Columns[3].HeaderText = "Ціна за 1 шт.";
            salesDrugsGridView.Columns[4].HeaderText = "Сума";
        }


        public EditSaleForm(int sellerId, int saleId)
        {
            InitializeComponent();
            isCreating_ = false;
            sellerId_ = sellerId;
            currentSaleId_ = saleId;
            salesdrugsBindingSource.DataSource = salesDrugsDataTable;
            salesDrugsGridView.DataSource = salesdrugsBindingSource;
            connection_ =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);

            CreateAdapter();
            FillData();
            DisableUnnecessaryControls();
        }


        private void DisableUnnecessaryControls()
        {
            insertButton.Enabled =
            deleteButton.Enabled =
            editButton.Enabled =
            cancelButton.Enabled =
                isCreating_;
        }


        private void CreateAdapter()
        {
            const string FILL_TABLE_QUERY = "SELECT salesdrugs.drug_id, drug_name, " +
                "salesdrugs_amount, salesdrugs_price, " +
                "salesdrugs_price * salesdrugs_amount AS sum_price " +
                "FROM salesdrugs INNER JOIN drugs WHERE " +
                "sale_id=@sale_id AND drugs.drug_id=salesdrugs.drug_id;";
            MySqlCommand fillTableCommand = new MySqlCommand(FILL_TABLE_QUERY, connection_);
            fillTableCommand.Parameters.AddWithValue("@sale_id", currentSaleId_);
            salesDrugsAdapter = new MySqlDataAdapter(fillTableCommand);

            // DELETE command

            const string DELETE_QUERY =
                "DELETE FROM salesdrugs " +
                "WHERE sale_id = @sale_id AND drug_id = @drug_id"; ;
            MySqlCommand deleteCommand = new MySqlCommand(DELETE_QUERY, connection_);
            deleteCommand.Parameters.AddWithValue("@sale_id", currentSaleId_);
            var param = 
                deleteCommand.Parameters.Add("@drug_id", MySqlDbType.Int32, 4, "drug_id");
            param.SourceVersion = DataRowVersion.Original;
            salesDrugsAdapter.DeleteCommand = deleteCommand;
        }


        private void InsertSale()
        {
            string query =
                $"INSERT INTO sales (sale_seller_id) VALUES ({sellerId_});" +
                "SELECT LAST_INSERT_ID();";
            MySqlCommand command = new MySqlCommand(query, connection_);
            MySqlDataReader reader;

            try
            {
                connection_.Open();
                reader = command.ExecuteReader();
                reader.Read();
                currentSaleId_ = Convert.ToInt32(reader.GetValue(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Close();
            }
            connection_.Close();
        }


        private void FillData()
        {
            salesDrugsDataTable.Rows.Clear();

            try
            {
                connection_.Open();
                salesDrugsAdapter.Fill(salesDrugsDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
            connection_.Close();
        }


        private void SaveChangesToDatabase()
        {
            salesDrugsAdapter.Update(salesDrugsDataTable);

            try
            {
                connection_.Open();
                salesDrugsAdapter.Fill(salesDrugsDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
            connection_.Close();
            FillData();
        }


        private void DeleteCurrentSale()
        {
            string query = $"DELETE FROM sales WHERE sale_id = {currentSaleId_};";
            MySqlCommand command = new MySqlCommand(query, connection_);

            try
            {
                connection_.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                FillData();
            }
            connection_.Close();
            Close();
        }


        private void SalesDrugsGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            SaveChangesToDatabase();
        }

        
        private void InsertButton_Click(object sender, EventArgs e)
        {
            var form = new SaleDrugInsertForm(currentSaleId_);
            DialogResult res = form.ShowDialog();
            FillData();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (salesDrugsGridView.SelectedRows.Count == 0)
            {
                return;
            }

            salesDrugsGridView.Rows.Remove(salesDrugsGridView.SelectedRows[0]);
            SaveChangesToDatabase();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            while (salesDrugsGridView.Rows.Count != 0)
            {
                salesDrugsGridView.Rows.Remove(salesDrugsGridView.Rows[0]);
            }

            SaveChangesToDatabase();
            DeleteCurrentSale();
            Close();
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            if (salesDrugsGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var selected =
                (salesDrugsGridView.SelectedRows[0].DataBoundItem as DataRowView).Row;
            int drugId = Convert.ToInt32(selected["drug_id"]);
            var form = new SaleDrugEditForm(currentSaleId_, drugId);
            form.ShowDialog();
            FillData();
        }


        private void PrintCheckButton_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm(currentSaleId_);
            form.ShowDialog();
        }
    }
}
