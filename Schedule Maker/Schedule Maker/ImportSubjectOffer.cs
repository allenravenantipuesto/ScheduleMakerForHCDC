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
    public partial class Import_Subject_Offer : Form
    {
        public Import_Subject_Offer()
        {
            InitializeComponent();
           
        }

        private void btnPasteFromExcel_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dgImport.RowCount > 0)
                    dgImport.Rows.Clear();

                if (dgImport.ColumnCount > 0)
                    dgImport.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = System.Text.RegularExpressions.Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            dgImport.Columns.Add("col" + i, pastedRowCells[i]);

                        columnsAdded = true;
                        continue;
                    }

                    dgImport.Rows.Add();
                    int myRowIndex = dgImport.Rows.Count - 1;

                    using (DataGridViewRow dgStudentsRow = dgImport.Rows[myRowIndex])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            dgStudentsRow.Cells[i].Value = pastedRowCells[i];
                    }
                }
            }
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
            catch (Exception error)
            {
                MessageBox.Show("An error occured: " + error.Message);
            }
        }
        private void btnImportToDatabase_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Maximum = dgImport.Rows.Count;
            for (int x = 0; x < dgImport.Rows.Count; x++)
            {
                ExecuteNonQuery("INSERT INTO subjectOffer(subjectofferno,subjectcode,description,timeStart,timeEnd,day,leclab,room,section) VALUES('" + Misc.SymbolCheckerToDatabase(dgImport.Rows[x].Cells[0].Value.ToString()) + "','" + Misc.SymbolCheckerToDatabase(dgImport.Rows[x].Cells[1].Value.ToString()) + "','" + Misc.SymbolCheckerToDatabase(dgImport.Rows[x].Cells[2].Value.ToString()) + "','" + Misc.SymbolCheckerToDatabase(dgImport.Rows[x].Cells[3].Value.ToString()) + "','" + Misc.SymbolCheckerToDatabase(dgImport.Rows[x].Cells[4].Value.ToString()) + "','" + Misc.SymbolCheckerToDatabase(dgImport.Rows[x].Cells[5].Value.ToString()) + "','" + Misc.SymbolCheckerToDatabase(dgImport.Rows[x].Cells[6].Value.ToString()) + "','" + Misc.SymbolCheckerToDatabase(dgImport.Rows[x].Cells[7].Value.ToString()) + "','" + Misc.SymbolCheckerToDatabase(dgImport.Rows[x].Cells[8].Value.ToString()) + "')");
                progressBar.Value = x;
            }
            MessageBox.Show("Successfully Imported", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Import_Subject_Offer_Load(object sender, EventArgs e)
        {
            

            if (Connection.SessionUserID == "3")
            {

            }
            else
            {
                cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * from useraccountView where userid=" + Connection.SessionUserID, Connection.Conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show("Please login as Administrator!\nYou are currently logged in as " + dr["fullname"].ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                dr.Close();
                cmd.Dispose();

                
                this.Close();
            }
        }
    }
}
