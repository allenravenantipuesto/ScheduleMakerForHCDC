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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Connection.Conn.Open();
        }

        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader dr;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool accountExisting = false;
            cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM useraccountview", Connection.Conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (txtUsername.Text == dr["username"].ToString() && txtPassword.Text == dr["password"].ToString())
                {
                    accountExisting = true;
                    Connection.SessionUserID = dr[0].ToString();
                }
            }
            dr.Close();
            cmd.Dispose();

            if (accountExisting == true)
            {
                var mainform = new Main();
                Hide();
                
                accountExisting = false;
                mainform.ShowDialog();
                txtUsername.Text = "";
                txtPassword.Text = "";
                Connection.SessionUserID = "";
                Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void tbKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.ShowDialog();
        }
    }
}
