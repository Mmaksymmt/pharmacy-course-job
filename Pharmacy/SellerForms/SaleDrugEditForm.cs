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


        public SaleDrugEditForm(int saleId, int drugId)
        {
            InitializeComponent();
            saleId_ = saleId;
            drugId_ = drugId;
            GetAdapter();
            FillData();
        }


        private void GetAdapter()
        {
            string query =
                $"SELECT * FROM salesdrugs INNER JOIN drugs ON " +
                $"drugs.drug_id=salesdrugs.drug_id WHERE salesdrugs.sale_id={saleId_} " +
                $"AND salesdrugs.drug_id={drugId_};";

            try
            {
                connection_.Open();
                adapter_ = new MySqlDataAdapter(query, connection_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Close();
            }
            connection_.Close();

            // UPDATE query

            string updateQuery =
                $"UPDATE salesdrugs SET salesdrugs_amount = @sdAmount" +
                $" WHERE sale_id = {saleId_} AND drug_id = {drugId_};";
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection_);
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
            amountNumericUpDown.Maximum = Convert.ToInt32(salesdrugsDt_.Rows[0]["drug_amount"]);
            amountNumericUpDown.Minimum = 0;
            int salesDrugAmount = Convert.ToInt32(salesdrugsDt_.Rows[0]["salesdrugs_amount"]);
            amountNumericUpDown.Value =
                salesDrugAmount > amountNumericUpDown.Maximum
                ? amountNumericUpDown.Maximum
                : salesDrugAmount;
            amountNumericUpDown.Enabled = true;
            priceValueLabel.Text =
                Convert.ToDecimal(salesdrugsDt_.Rows[0]["drug_price"]).ToString();
            inStockValueLabel.Text = amountNumericUpDown.Maximum.ToString();
            saveButton.Enabled = true;
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
    }
}

// TODO: fix drugs amount display