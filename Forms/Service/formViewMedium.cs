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
    public partial class formViewMedium : Form
    {
        private string placeholderText = "Enter text here";

        public formViewMedium()
        {
            InitializeComponent();
            SetPlaceholder();

        }

        private void formViewMedium_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee.M_VehicleList' table. You can move, or remove it, as needed.
            this.m_VehicleListTableAdapter.FillByMedium(this.employee.M_VehicleList);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter text here")
            {
                this.m_VehicleListTableAdapter.FillByMedium(this.employee.M_VehicleList);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.m_VehicleListTableAdapter.FillBySearchM(this.employee.M_VehicleList, txtSearch.Text);

                }
                else
                {
                    this.m_VehicleListTableAdapter.FillByMedium(this.employee.M_VehicleList);

                }
            }

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text == placeholderText)
            {
                // Set the placeholder text and change its color
                txtSearch.Text = placeholderText;
                txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholderText)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();

        }
    }
}
