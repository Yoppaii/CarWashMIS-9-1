using CarWashMIS.DataSets.EmployeeTableAdapters;
using CarWashMIS.DataSets;
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
    public partial class frmEditVehicleLists : Form
    {
        private M_VehicleListTableAdapter adpV = new M_VehicleListTableAdapter();
        private Employee.M_VehicleListDataTable dtV = new Employee.M_VehicleListDataTable();

        private string placeholderText = "Enter text here";

        public frmEditVehicleLists()
        {
            InitializeComponent();

            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            SetPlaceholder();

        }

        private void frmEditVehicleLists_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee.M_VehicleList' table. You can move, or remove it, as needed.
            this.m_VehicleListTableAdapter.Fill(this.employee.M_VehicleList);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || cmbSize.Text == "")
            {
                MessageBox.Show("Please fill up all fields", "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    adpV.InsertQuery(txtName.Text, cmbSize.Text);
                    this.m_VehicleListTableAdapter.Fill(this.employee.M_VehicleList);
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.mVehicleListBindingSource.RemoveCurrent();
            this.m_VehicleListTableAdapter.Update(this.employee.M_VehicleList);

        }

        private void lbVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Clear()
        {
            txtName.Text = "";
            cmbSize.SelectedText = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter text here")
            {
                this.m_VehicleListTableAdapter.Fill(this.employee.M_VehicleList);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.m_VehicleListTableAdapter.FillBySearch(this.employee.M_VehicleList, txtSearch.Text);

                }
                else
                {
                    this.m_VehicleListTableAdapter.Fill(this.employee.M_VehicleList);

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
