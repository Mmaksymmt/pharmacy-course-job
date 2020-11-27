﻿using MySql.Data.MySqlClient;
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
        private const string DB_CONNECTION_STRING =
            "server=localhost;user id=root;password=YflOe234fOEM;persistsecurityinfo=True;" +
            "database=pharmacy";
        private MySqlConnection connection_ = new MySqlConnection(DB_CONNECTION_STRING);
        DataTable salesDrugsDataTable = new DataTable();
        MySqlDataAdapter salesDrugsAdapter;
        private int sellerId_;
        private int currentSaleId_;


        public EditSaleForm(int sellerId)
        {
            InitializeComponent();
            sellerId_ = sellerId;
            salesdrugsBindingSource.DataSource = salesDrugsDataTable;
            salesDrugsGridView.DataSource = salesdrugsBindingSource;

            InsertSale();
            CreateAdapter();
            FillData();
        }


        public EditSaleForm(int sellerId, int saleId)
        {
            InitializeComponent();
            sellerId_ = sellerId;
            currentSaleId_ = saleId;
            salesdrugsBindingSource.DataSource = salesDrugsDataTable;
            salesDrugsGridView.DataSource = salesdrugsBindingSource;

            CreateAdapter();
            FillData();
        }


        public void CreateAdapter()
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

            const string DELETE_QUERY = "DELETE FROM salesdrugs WHERE sale_id = @sale_id" +
                " AND drug_id = @drug_id"; ;
            MySqlCommand deleteCommand = new MySqlCommand(DELETE_QUERY, connection_);
            deleteCommand.Parameters.AddWithValue("@sale_id", currentSaleId_);
            var param = 
                deleteCommand.Parameters.Add("@drug_id", MySqlDbType.Int32, 4, "drug_id");
            param.SourceVersion = DataRowVersion.Original;
            salesDrugsAdapter.DeleteCommand = deleteCommand;
        }


        public void InsertSale()
        {
            string query = $"INSERT INTO sales (sale_seller_id) VALUES ({sellerId_});" +
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


        public void FillData()
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


        public void SaveChangesToDatabase()
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
    }
}