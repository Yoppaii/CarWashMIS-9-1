using CarWashMIS.DataSets;
using CarWashMIS.DataSets.EmployeeTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashMIS.Forms
{
    
    public partial class frmSettings : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=MIS_CarWash;Integrated Security=True");

        private M_AverageTimeTableAdapter adpAvg = new M_AverageTimeTableAdapter();
        private Employee.M_AverageTimeDataTable dtAvg = new Employee.M_AverageTimeDataTable();

        public frmSettings()
        {
            InitializeComponent();

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            dtAvg = adpAvg.GetData();

        }
        private void btnAvg_Click(object sender, EventArgs e)
        {
            int id = 1;

            string xs = dtAvg.Rows[0]["ExtraSmall"].ToString();
            string s = dtAvg.Rows[0]["Small"].ToString();
            string m = dtAvg.Rows[0]["Medium"].ToString();
            string l = dtAvg.Rows[0]["Large"].ToString();
            string xl = dtAvg.Rows[0]["ExtraLarge"].ToString();


            frmEditAvgTime avg = new frmEditAvgTime(id, xs, s, m, l ,xl);
            avg.ShowDialog();


        }

        private void btnVehicleList_Click(object sender, EventArgs e)
        {
            frmEditVehicleLists vl = new frmEditVehicleLists();
            vl.ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK )
            {
                txtLocation.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();

            if(txtLocation.Text == string.Empty)
            {
                MessageBox.Show("Please enter the backup location");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK = '" + txtLocation.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak'";
                con.Open();

                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();

                MessageBox.Show("Successfully created database backup");
                con.Close();
                btnBackup.Enabled = false;

            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|.bak";
            dlg.Title = "Database restore";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtLocation2.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }


        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();

            if (txtLocation2.Text == string.Empty)
            {
                MessageBox.Show("Please enter the backup file location");
            }
            else
            {
                con.Open();

                try
                {
                    string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINLGE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    cmd1.ExecuteNonQuery();

                    string str2 = "USER MASTER RESTORE DATABASE [" + database + "] FROM DISK = '" + txtLocation2.Text + "' WITH REPLACE;";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    cmd2.ExecuteNonQuery();

                    string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand cmd3 = new SqlCommand(str3, con);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Successfully restored database");
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }
    }
}
