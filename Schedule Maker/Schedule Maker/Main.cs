using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schedule_Maker
{
    public partial class Main : Form
    {
        public Main()
        {
            //Connection.Conn.Open();
            InitializeComponent();
            UserIndentification();
            LoadSubjectOffer();
            Reset();
            if (cbSchedules.Items.Count > 0)
            {
                cbSchedules.Text = cbSchedules.Items[0].ToString();
            }

        }

        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader dr;

        void UserIndentification()
        {

            cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * from useraccountview where userID=" + Connection.SessionUserID, Connection.Conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.Text += " -- [Account Logged in:  " +  dr["fullname"].ToString() + "]";
            }
            dr.Close();
            cmd.Dispose();
        }

        void LoadSubjectOffer()
        {
            dgSubjectOffered.Rows.Clear();
            cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * from subjectoffer", Connection.Conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string start = Misc.ConvertTime(dr[3].ToString());
                string end = Misc.ConvertTime(dr[4].ToString());

                dgSubjectOffered.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),start + " - " + end, dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cmd.Dispose();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgSubjectOffered.Rows.Clear();
            cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM subjectOffer where subjectofferno like '" + txtSearch.Text + "' or subjectcode like '%" + txtSearch.Text + "%' or description like '%" + Misc.SymbolCheckerToDatabase(txtSearch.Text) + "%'", Connection.Conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string start = Misc.ConvertTime(dr[3].ToString());
                string end = Misc.ConvertTime(dr[4].ToString());

                dgSubjectOffered.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), start + " - " + end, dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cmd.Dispose();
        }

        private void subjectOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var import = new Import_Subject_Offer();
            import.ShowDialog();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            
            Reset();
            if (dgSchedule.Rows.Count > 0)
            {
                for (int x = 0; x < dgSchedule.Rows.Count; x++)
                {
                    if (txtAddSubject.Text != dgSchedule.Rows[x].Cells[0].Value.ToString())
                    {
                        if (txtAddSubject.Text != " " && !txtAddSubject.Text.Contains(" "))
                        {
                            ExecuteNonQuery("INSERT INTO selectedSubjects VALUES('" + txtAddSubject.Text + "'," + Connection.SessionUserID + ")");
                            txtAddSubject.Text = "";
                            txtAddSubject.Focus();
                            Reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Subject is already on the schedule.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtAddSubject.Text = "";
                        txtAddSubject.Focus();
                        Reset();
                        break;
                    }

                }
            }
            else
            {
                if (txtAddSubject.Text != " " && !txtAddSubject.Text.Contains(" "))
                {
                    ExecuteNonQuery("INSERT INTO selectedSubjects VALUES('" + txtAddSubject.Text + "',"+Connection.SessionUserID+")");
                    txtAddSubject.Text = "";
                    txtAddSubject.Focus();
                    Reset();
                }
            }
            
           
            

        }

        void Reset()
        {
            string[] days = { "MWF", "M", "W", "F","MT", "MW","MTh","MF","TW","TF","WTh","WF","ThF", "TTh", "T", "Th", "MTWThF", "S" };
            dgSchedule.Rows.Clear();
            for (int x = 0; x < days.Length; x++)
            {
                cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM subjectSelectedView where userid="+Connection.SessionUserID+" ORDER BY timestart asc", Connection.Conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    string start = Misc.ConvertTime(dr[5].ToString());
                    string end = Misc.ConvertTime(dr[5].ToString());

                    if (dr[6].ToString() == days[x])
                    {
                        dgSchedule.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[3].ToString(), start + " - " + end, dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                    }
                }
                dr.Close();
                cmd.Dispose();

                
            }

            cbSchedules.Items.Clear();
            cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT DISTINCT(scheduleName) FROM schedules where userID=" + Connection.SessionUserID + "", Connection.Conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbSchedules.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cmd.Dispose();

            if (cbSchedules.Items.Count > 0)
            {
                cbSchedules.Text = cbSchedules.Items[0].ToString();
            }
        }

            void ExecuteNonQuery(string command)
        {
            try
            {
                cmd = new MySql.Data.MySqlClient.MySqlCommand(command, Connection.Conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured: " + error.Message);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Misc.ConvertTime(txtAddSubject.Text));
        }

        private void subjectOfferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadSubjectOffer();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            if (cbSchedules.Items.Count > 0)
            {
                cbSchedules.Text = cbSchedules.Items[0].ToString();
            }
        }
        
        private void dgSchedule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgSchedule.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this? ", "Continue to delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string org = dgSchedule.Rows[dgSchedule.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        ExecuteNonQuery("DELETE FROM selectedSubjects WHERE subjectOfferNo LIKE '" + org + "'");
                        Reset();
                    }
                }
            }
            
        }

        private void dgSubjectOffered_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgSubjectOffered.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to add this? ", "Continue to add?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string org = dgSubjectOffered.Rows[dgSubjectOffered.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    ExecuteNonQuery("INSERT INTO selectedSubjects VALUES('" + org + "',"+Connection.SessionUserID+") ");
                    Reset();
                }
            }
        }

        private void btnAddNewSchedule_Click(object sender, EventArgs e)
        {
            var schedules = new Schedules();
            schedules.ShowDialog();
            Reset();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSelectSchedule_Click(object sender, EventArgs e)
        {
            
            string[] days = { "MWF", "M", "W", "F", "MT", "MW", "MTh", "MF", "TW", "TF", "WTh", "WF", "ThF", "TTh", "T", "Th", "MTWThF", "S" };

            dgSchedule.Rows.Clear();
            for (int x = 0; x < days.Length; x++)
            {
                cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM schedulesView WHERE scheduleName like '" + cbSchedules.Text + "'  ORDER BY timestart ", Connection.Conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string start = Misc.ConvertTime(dr[5].ToString());
                    string end = Misc.ConvertTime(dr[6].ToString());
                    if (dr[7].ToString() == days[x])
                    {
                        dgSchedule.Rows.Add(dr[1].ToString(), dr[3].ToString(), dr[4].ToString(), start + " - " + end, dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                    }
                }
                dr.Close();
                cmd.Dispose();
            }
            
            
        }

        private void btnClearScheduleView_Click(object sender, EventArgs e)
        {
            dgSchedule.Rows.Clear();
            ExecuteNonQuery("delete From selectedsubjects where userID=" + Connection.SessionUserID);
            Reset();
        }

        private void txtAddSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAddSubject.PerformClick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            dgSchedule.Height = tabControl1.Height - 100;
            dgSchedule.Width = tabControl1.Width - 10;

            dgSubjectOffered.Height = tabControl1.Height - 100;
            dgSubjectOffered.Width = tabControl1.Width - 10;
        }
        bool envornmentExit = true;
        private void logoutSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            envornmentExit = false;
            Connection.SessionUserID = "";
            this.Close();

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (envornmentExit)
            {
                Environment.Exit(0);
            }
            
        }
    }
}