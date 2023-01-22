using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SlotMachine
{
    public partial class login : MaterialSkin.Controls.MaterialForm
    {
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=slot_machine;Uid=user;Pwd=password;";
        private MySqlConnection connection;
        private string username;
        private int money;
        public login()
        {
            InitializeComponent();
            //Change the look
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme =
            new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue600, MaterialSkin.Primary.BlueGrey900,
            MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Red700, MaterialSkin.TextShade.WHITE);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);

        }
        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
            Environment.Exit(1);

        }
        private void login_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
            //Remember ME
            if (Properties.Settings.Default.username != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.username;
                txtPassword.Text = Properties.Settings.Default.password;
                rememberme.Checked = true;
            }
            else
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                rememberme.Checked = false;
            }
        }
        //Saving data
        public void save(string user, int money)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE user_info SET money = @money WHERE username = @username";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@money", money);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.ExecuteNonQuery();
            }
            //For some reason the form doesn't fully close unless some of these commands are here
            this.Close();
            System.Windows.Forms.Application.Exit();
            Application.Exit();
            Environment.Exit(1);
        }

        //remember me
        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //login
        private void materialButton1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password");
                return;
            }

            string query = "SELECT username, money FROM user_info WHERE username = @username AND BINARY password = @password";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            username = reader.GetString("username");
                            money = reader.GetInt32("money");
                        }
                        if (rememberme.Checked == true)
                        {
                            Properties.Settings.Default.username = txtUsername.Text;
                            Properties.Settings.Default.password = txtPassword.Text;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.username = "";
                            Properties.Settings.Default.password = "";
                            Properties.Settings.Default.Save();
                        }
                        //Successful login message
                        this.Hide();
                        GameForm form1 = new GameForm(username, money);
                        form1.ShowDialog();

                      
                    }
                    else
                    {
                        MessageBox.Show("Invalid username/password, please try again", "WRONG!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    }
                }
            }
        }
        //signup
        private void materialLabel1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToLower();
            string password = txtPassword.Text;
            int money = 100;
            string insertQuery = "INSERT INTO user_info (username, password, money) VALUES (@username, @password, @money)";
            string checkQuery = "SELECT COUNT(*) FROM user_info WHERE username = @username";
            int count = 0;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password");
                return;
            }

            if (password.Length < 5 || password.Length > 12)
            {
                MessageBox.Show("The password must be within 5 to 12 characters","Invalid");
                return;
            }


            using (MySqlCommand command = new MySqlCommand(checkQuery, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                count = Convert.ToInt32(command.ExecuteScalar());
            }

            if (count > 0)
            {
                MessageBox.Show("Username already taken. Please choose another one.");
            }
            else
            {
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@money", money);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfull Registration!","Thank you");
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }
            }
        }
    }
}
