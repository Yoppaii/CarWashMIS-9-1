using CarWashMIS.DataSets.EmployeeTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashMIS.Forms
{
    public partial class frmEditAvgTime : Form
    {
        private int id { get; set; }
        private string xs { get; set; }
        private string s { get; set; }
        private string m { get; set; }
        private string l { get; set; }
        private string xl { get; set; }
        public frmEditAvgTime(int id, string xs, string s, string m, string l, string xl)
        {
            InitializeComponent();
            this.id = id;
            this.xs = xs;
            this.s = s;
            this.m = m;
            this.l = l;
            this.xl = xl;
        }
        private void frmEditAvgTime_Load(object sender, EventArgs e)
        {
            txtExtraSmall.Text = xs;
            txtSmall.Text = s;
            txtMedium.Text = m;
            txtLarge.Text = l;
            txtExtraLarge.Text = xl;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtExtraSmall.Text == "" || txtSmall.Text == "" || txtMedium.Text == "" || txtLarge.Text == "" || txtExtraLarge.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Update Average Car Wash Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    M_AverageTimeTableAdapter adp = new M_AverageTimeTableAdapter();

                    adp.UpdateQuery(txtExtraSmall.Text, txtSmall.Text, txtMedium.Text, txtLarge.Text, txtExtraLarge.Text, id);

                    MessageBox.Show("Successfully updated the Average Car Wash Time", "Update Average Car Wash Time", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

    }
}
