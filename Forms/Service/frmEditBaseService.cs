using CarWashMIS.DataSets;
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
using System.Xml.Linq;

namespace CarWashMIS.Forms
{
    public partial class frmEditBaseService : Form
    {
        public int extraSmall { get; set; }
        public int small { get; set; }
        public int medium { get; set; }
        public int large { get; set; }
        public int extraLarge { get; set; }
        public int id { get; set; }

        public frmEditBaseService(int extraSmall, int small, int medium, int large, int extraLarge, int id)
        {
            InitializeComponent();
            this.extraSmall = extraSmall;
            this.small = small;
            this.medium = medium;
            this.large = large;
            this.extraLarge = extraLarge;
            this.id = id;

        }


        private void frmEditBS_Load(object sender, EventArgs e)
        {
            txtExtraSmall.Text = extraSmall.ToString();
            txtSmallBS.Text = small.ToString();
            txtMediumBS.Text = medium.ToString();
            txtLargeBS.Text = large.ToString();
            txtExtraLargeBS.Text = extraLarge.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSaveBS_Click(object sender, EventArgs e)
        {
            if (txtExtraSmall.Text == "" || txtSmallBS.Text == "" || txtMediumBS.Text == "" || txtLargeBS.Text == "" || txtExtraLargeBS.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    M_BaseServicesTableAdapter adp = new M_BaseServicesTableAdapter();
                    Employee.M_BaseServicesDataTable dt = new Employee.M_BaseServicesDataTable();

                    adp.UpdateQuery(Convert.ToInt32(txtExtraSmall.Text), Convert.ToInt32(txtSmallBS.Text), Convert.ToInt32(txtMediumBS.Text), Convert.ToInt32(txtLargeBS.Text), Convert.ToInt32(txtExtraLargeBS.Text), id);
                    adp.Fill(dt);

                    MessageBox.Show("Record successfully updated", "Update Base Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values for ExtraSmall, Small, Medium, Large, and ExtraLarge Prices.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

        }
    }
}
