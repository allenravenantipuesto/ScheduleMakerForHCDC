using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Maker
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
        }
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader dr;
        void ExecuteNonQuery(string command)
        {
            try
            {
                cmd = new MySql.Data.MySqlClient.MySqlCommand(command, Connection.Conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool emailaddress = false, username = false;
            cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM useraccountview", Connection.Conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(dr["emailaddress"].ToString() == txtEmailAddress.Text)
                {
                    emailaddress = true;
                    break;
                }
                else
                {
                    if (dr["username"].ToString() == txtUsername.Text)
                    {
                        username = true;
                        break;
                    }
                }
            }
            dr.Close();
            cmd.Dispose();

            if (username == true)
            {
                MessageBox.Show("Your username is already taken","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Text = "";
            }
            else
            {
                if(emailaddress == true)
                {
                    MessageBox.Show("Your email address is already connected to another account", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailAddress.Text = "";
                }
                else if (!txtEmailAddress.Text.Contains("@"))
                {
                    MessageBox.Show("Email is invalid!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailAddress.Text = "";
                    txtEmailAddress.Focus();
                }
                else
                {
                    ExecuteNonQuery("INSERT INTO users(fullname,address,emailaddress) VALUES('"+txtFirstName.Text + " " + txtLastName.Text+"','"+txtAddress.Text+"','"+txtEmailAddress.Text+"')");

                    string userId = "";
                    cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM users where fullname='" + txtFirstName.Text + " " + txtLastName.Text + "' and address='" + txtAddress.Text + "' and emailaddress='" + txtEmailAddress.Text + "'", Connection.Conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        userId = dr["userID"].ToString();
                    }
                    dr.Close();
                    cmd.Dispose();

                    ExecuteNonQuery("INSERT INTO accounts VALUES(" + userId + ",'" + txtUsername.Text + "','" + txtPassword.Text + "')");
                    MessageBox.Show("Successfully registered!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
