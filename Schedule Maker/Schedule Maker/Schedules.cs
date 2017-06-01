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
    public partial class Schedules : Form
    {
        public Schedules()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM selectedSubjects", Connection.Conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cmd.Dispose();

            for(int x =0; x < listBox1.Items.Count; x++)
            {
                ExecuteNonQuery("INSERT INTO schedules VALUES('" + txtScheduleName.Text + "','" + listBox1.Items[x].ToString() + "',"+Connection.SessionUserID+")");
            }

            ExecuteNonQuery("Truncate Table selectedSubjects");
            this.Close();
            
            
            


        }

        private void txtScheduleName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }
    }
}
