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

namespace Pharmacy.SellerForms
{
    public partial class SaleDrugEditForm : Form
    {
        private const string DB_CONNECTION_STRING =
            "server=localhost;user id=root;password=YflOe234fOEM;persistsecurityinfo=True;" +
            "database=pharmacy";
        private MySqlConnection connection_ = new MySqlConnection(DB_CONNECTION_STRING);
        MySqlDataAdapter adapter_;
        private DataTable salesdrugsDt_ = new DataTable();
        private int saleId_;
        private int drugId_;
        private decimal price_;



        public SaleDrugEditForm(int saleId, int drugId)
        {
            InitializeComponent();
            saleId_ = saleId;
            drugId_ = drugId;
            CreateAdapter();
            FillData();
        }


        private void CreateAdapter()
        {
            const string QUERY =
                "SELECT * FROM salesdrugs INNER JOIN drugs ON " +
                "drugs.drug_id=salesdrugs.drug_id WHERE salesdrugs.sale_id=@sale_id " +
                "AND salesdrugs.drug_id=@drug_id;";
            MySqlCommand command = new MySqlCommand(QUERY, connection_);
            command.Parameters.AddWithValue("@sale_id", saleId_);
            command.Parameters.AddWithValue("@drug_id", drugId_);
            adapter_ = new MySqlDataAdapter(command);

            // UPDATE query

            const string UPDATE_QUERY =
                "UPDATE salesdrugs SET salesdrugs_amount = @sdAmount" +
                " WHERE sale_id = @sale_id AND drug_id = @drug_id;";
            MySqlCommand updateCommand = new MySqlCommand(UPDATE_QUERY, connection_);
            updateCommand.Parameters.AddWithValue("@sale_id", saleId_);
            updateCommand.Parameters.AddWithValue("@drug_id", drugId_);
            var param = updateCommand.Parameters.Add(
                "@sdAmount", MySqlDbType.Int32, 4, "salesdrugs_amount");
            adapter_.UpdateCommand = updateCommand;
        }


        private void FillData()
        {
            salesdrugsDt_.Clear();

            try
            {
                connection_.Open();
                adapter_.Fill(salesdrugsDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Close();
            }

            connection_.Close();
            nameLabel.Text = salesdrugsDt_.Rows[0]["drug_name"].ToString();
            amountNumericUpDown.Maximum =
                Convert.ToInt32(salesdrugsDt_.Rows[0]["salesdrugs_amount"]) +
                GetDrugsInStock();
            amountNumericUpDown.Minimum = 0;
            int salesDrugAmount = Convert.ToInt32(salesdrugsDt_.Rows[0]["salesdrugs_amount"]);
            amountNumericUpDown.Value =
                salesDrugAmount > amountNumericUpDown.Maximum
                ? amountNumericUpDown.Maximum
                : salesDrugAmount;
            amountNumericUpDown.Enabled = true;
            price_ = Convert.ToDecimal(salesdrugsDt_.Rows[0]["drug_price"]);
            priceValueLabel.Text = price_.ToString();
            inStockValueLabel.Text = amountNumericUpDown.Maximum.ToString();
            saveButton.Enabled = true;
            totalCostValueLabel.Text = (amountNumericUpDown.Value * price_).ToString();
        }


        private int GetDrugsInStock()
        {
            const string QUERY = "SELECT drug_amount FROM drugs WHERE drug_id=@drug_id";
            MySqlCommand command = new MySqlCommand(QUERY, connection_);
            command.Parameters.AddWithValue("@drug_id", drugId_);
            MySqlDataReader reader;
            int inStockValue;

            try
            {
                connection_.Open();
                reader = command.ExecuteReader();
                reader.Read();
                inStockValue = Convert.ToInt32(reader.GetValue(0)); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }

            connection_.Close();
            return inStockValue;
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            salesdrugsDt_.Rows[0]["salesdrugs_amount"] = amountNumericUpDown.Value;
            adapter_.Update(salesdrugsDt_);
            Close();
        }


        private void AmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalCostValueLabel.Text = (amountNumericUpDown.Value * price_).ToString();
        }
    }
}