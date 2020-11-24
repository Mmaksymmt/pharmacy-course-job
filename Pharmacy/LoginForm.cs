using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class LoginForm : Form
    {
        private const string DB_CONNECTION_STRING =
            "server=localhost;user id=root;password=YflOe234fOEM;persistsecurityinfo=True;" +
            "database=pharmacy";
        private MySqlConnection connection_ = new MySqlConnection(DB_CONNECTION_STRING);


        public LoginForm()
        {
            InitializeComponent();
        }


        private void EnterButton_Click(object sender, EventArgs e)
        {
            int id;
            bool idParsed = int.TryParse(idTextBox.Text, out id);
            string passw = passwordTextBox.Text;

            // Empty fields or can not parse id

            if (!idParsed || string.IsNullOrEmpty(passw))
            {
                MessageBox.Show("Введіть дані у правильному форматі!");
                return;
            }

            string query = $"SELECT seller_id, seller_password, seller_admin " +
                    $"FROM Sellers WHERE seller_id={id} AND seller_password=\"{passw}\"";
            DataTable sellers = new DataTable();

            try
            {
                connection_.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection_);
                adapter.Fill(sellers);
            }
            catch (Exception ex)
            {
                // DB connection error

                MessageBox.Show($"Error: {ex.Message}");
                return;
            }
            connection_.Close();

            // Entered wrong data

            if (sellers.Rows.Count == 0)
            {
                MessageBox.Show("Користувач не знайдений!");
                return;
            }

            //OK

            Form form;

            if ((bool)sellers.Rows[0]["seller_admin"])
            {
                //form = new AdminMainForm((int)sellers.Rows[0]["seller_id"]);
                form = new SellerMainForm((int)sellers.Rows[0]["seller_id"]);
            }
            else
            {
                form = new SellerMainForm((int)sellers.Rows[0]["seller_id"]);
            }

            Program.Context.MainForm = form;
            Close();
            form.Show();
        }
    }
}
