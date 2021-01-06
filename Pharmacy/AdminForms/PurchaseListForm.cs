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
    public partial class PurchaseListForm : Form
    {
        private MySqlConnection connection_;
        private DataTable drugsDt_ = new DataTable();
        private List<DrugItem> drugItems_ = new List<DrugItem>();


        public PurchaseListForm()
        {
            InitializeComponent();
            drugsBindingSource.DataSource = drugItems_;
            drugsGridView.DataSource = drugsBindingSource;
            connection_ =
                new MySqlConnection(Properties.Settings.Default.pharmacyConnectionString);
            stockUpDown.Value = 10;
            totalPriceLabel.Text = string.Empty;
        }


        private void CreateListButton_Click(object sender, EventArgs e)
        {
            const string QUERY =
                @"SELECT drugs.drug_id, drug_name, drug_price, drug_amount, 
                IFNULL(SUM(salesdrugs_amount), 0) as sold 
                FROM drugs LEFT JOIN salesdrugs ON drugs.drug_id = salesdrugs.drug_id 
                GROUP BY drug_id, drug_name, drug_price, drug_amount 
                ORDER BY sold DESC";

            MySqlCommand command = new MySqlCommand(QUERY, connection_);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            drugsDt_.Clear();

            try
            {
                adapter.Fill(drugsDt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }

            FormList();
        }


        private void FormList()
        {
            drugItems_.Clear();

            foreach (DataRow row in drugsDt_.Rows)
            {
                drugItems_.Add(
                    new DrugItem(
                        Convert.ToInt32(row["drug_id"]),
                        row["drug_name"].ToString(),
                        Convert.ToDecimal(row["drug_price"]),
                        Convert.ToUInt32(row["drug_amount"]),
                        Convert.ToInt32(row["sold"])));
            }

            // Creating list to buy

            decimal sum = 0;
            decimal money = priceUpDown.Value;
            bool isAdded;

            do
            {
                isAdded = false;

                for (int i = 0; i < drugItems_.Count && drugItems_[i].Sold != 0; i++)
                {
                    DrugItem curr = drugItems_[i];
                    if (curr.Price <= money && curr.ToBuy < curr.Sold)
                    {
                        curr.ToBuy++;
                        money -= curr.Price;
                        sum += curr.Price;
                        isAdded = true;
                    }
                }
            } while (isAdded);

            do
            {
                isAdded = false;

                for (int i = 0; i < drugItems_.Count; i++)
                {
                    DrugItem curr = drugItems_[i];

                    if (curr.Amount + curr.ToBuy < curr.Sold + stockUpDown.Value
                        && curr.Price <= money)
                    {
                        curr.ToBuy++;
                        money -= curr.Price;
                        sum += curr.Price;
                        isAdded = true;
                    }
                }
            } while (isAdded);

            for (int i = 0; i < drugItems_.Count; i++)
            {
                DrugItem curr = drugItems_[i];

                if (curr.ToBuy == 0)
                {
                    drugItems_.Remove(curr);
                    i--;
                }
            }

            totalPriceLabel.Text = $"Сума: {sum}";
            drugsBindingSource.ResetBindings(false);
        }


        public class DrugItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public uint Amount { get; set; }
            public int Sold { get; set; }
            public int ToBuy { get; set; } = 0;


            public DrugItem(
                int id,
                string name,
                decimal price,
                uint amount,
                int sold)
            {
                Id = id;
                Name = name;
                Price = price;
                Amount = amount;
                Sold = sold;
            }
        }


        private void MakeDocumentButton_Click(object sender, EventArgs e)
        {
            DrugsToBuyReportForm form = new DrugsToBuyReportForm(drugItems_);
            form.ShowDialog();
        }
    }
}
