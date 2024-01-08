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

namespace CarWashMIS.Forms
{
    public partial class frmArchives : Form
    {
        M_AddOnsTableAdapter adpAddOns = new M_AddOnsTableAdapter();
        Employee.M_AddOnsDataTable dtAddOns = new Employee.M_AddOnsDataTable();

        M_EmployeesTableAdapter adpEmployees = new M_EmployeesTableAdapter();
        Employee.M_EmployeesDataTable dtEmployees = new Employee.M_EmployeesDataTable();

        M_MaterialsTableAdapter adpMaterials = new M_MaterialsTableAdapter();
        Employee.M_MaterialsDataTable dtMaterials = new Employee.M_MaterialsDataTable();

        M_ToolsEquipmentsTableAdapter adpTE = new M_ToolsEquipmentsTableAdapter();
        Employee.M_ToolsEquipmentsDataTable dtTE = new Employee.M_ToolsEquipmentsDataTable();

        private string placeholderText = "Enter text here";

        public frmArchives()
        {
            InitializeComponent();

            SetPlaceholder();
            SetPlaceholderE();
            SetPlaceholderM();
            SetPlaceholderTE();


            adpAddOns.FillByArchive(dtAddOns);
            dgvAddOns.DataSource = dtAddOns;

            dgvAddOns.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAddOns.Columns[1].HeaderText = "Add Ons Name";


            adpEmployees.FillByArchive(dtEmployees);
            dgvEmployees.DataSource = dtEmployees;

            dgvEmployees.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEmployees.Columns[1].HeaderText = "Last Name";
            dgvEmployees.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEmployees.Columns[2].HeaderText = "First Name";
            dgvEmployees.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns[3].HeaderText = "MI";
            dgvEmployees.Columns[4].Visible = false;
            dgvEmployees.Columns[5].Visible = false;
            dgvEmployees.Columns[6].Visible = false;
            dgvEmployees.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns[10].Visible = false;
            dgvEmployees.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmployees.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            adpMaterials.FillByArchive(dtMaterials);
            dgvMaterials.DataSource = dtMaterials;

            dgvMaterials.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaterials.Columns[1].HeaderText = "Materials Name";

            adpTE.FillByArchive(dtTE);
            dgvTE.DataSource = dtTE;

            dgvTE.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTE.Columns[1].HeaderText = "Tools or Equipments Name";


        }

        private void frmArchives_Load(object sender, EventArgs e)
        {

        }

        //AddOns
        private void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to restore this record", "Restore Add Ons", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvAddOns.CurrentRow.Cells[0].Value.ToString());

                adpAddOns.RestoreQuery(id);

                adpAddOns.FillByArchive(dtAddOns);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter text here")
            {
                adpAddOns.FillByArchive(dtAddOns);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    adpAddOns.FillBySearchArchive(dtAddOns, txtSearch.Text);
                }
                else
                {
                    adpAddOns.FillByArchive(dtAddOns);
                }
            }
        }

        //Materials
        private void btnRestoreM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to restore this record", "Restore Materials", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvMaterials.CurrentRow.Cells[0].Value.ToString());

                adpMaterials.RestoreQuery(id);

                adpMaterials.FillByArchive(dtMaterials);
            }
        }

        private void btnSearchM_Click(object sender, EventArgs e)
        {
            if (txtSearchM.Text == "Enter text here")
            {
                adpMaterials.FillByArchive(dtMaterials);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearchM.Text))
                {
                    adpMaterials.FillBySearchArchive(dtMaterials, txtSearchM.Text);
                }
                else
                {
                    adpMaterials.FillByArchive(dtMaterials);
                }
            }

        }

        //Tools and Equipments
        private void btnRestoreTE_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTE.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("Do you want to restore this record", "Restore Tools and Equipments", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dgvTE.CurrentRow.Cells[0].Value.ToString());

                        // Assuming adpTE is your data adapter
                        adpTE.RestoreQuery(id);

                        adpTE.FillByArchive(dtTE);

                        MessageBox.Show("Record successfully restored", "Archive Tools and Equipments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // No need for an "else" block if there is no selected row, as nothing needs to be done in that case.
                }
                else
                {
                    MessageBox.Show("No record selected. Please select a record to restore.", "Restore Tools and Equipments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //DialogResult result = MessageBox.Show("Do you want to restore this record", "Restore Tools and Equipments", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    int id = Convert.ToInt32(dgvTE.CurrentRow.Cells[0].Value.ToString());

            //    adpTE.RestoreQuery(id);

            //    adpTE.FillByArchive(dtTE);

            //    MessageBox.Show("Record successfully restore", "Archive Tools and Equipments", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Failed to restore record", "Restore Tools and Equipments", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
        }

        private void btnSearchTE_Click(object sender, EventArgs e)
        {
            if (txtSearchTE.Text == "Enter text here")
            {
                adpTE.FillByArchive(dtTE);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearchTE.Text))
                {
                    adpTE.FillBySearchArchive(dtTE, txtSearchTE.Text);
                }
                else
                {
                    adpTE.FillByArchive(dtTE);
                }
            }

        }

        private void btnRestoreE_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to restore this record", "Restore Employees", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString());

                adpEmployees.RestoreQuery(id);

                adpEmployees.FillByArchive(dtEmployees);
            }

        }

        private void btnSearchE_Click(object sender, EventArgs e)
        {
            if (txtSearchE.Text == "Enter text here")
            {
                adpEmployees.FillByArchive(dtEmployees);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSearchE.Text))
                {
                    adpEmployees.FillBySearchArchive(dtEmployees, txtSearchE.Text);
                }
                else
                {
                    adpEmployees.FillByArchive(dtEmployees);
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

        private void txtSearchE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearchE.PerformClick();
            }
        }

        private void txtSearchM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearchM.PerformClick();
            }
        }

        private void txtSearchTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearchTE.PerformClick();
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

        private void SetPlaceholderE()
        {
            if (string.IsNullOrWhiteSpace(txtSearchE.Text) || txtSearchE.Text == placeholderText)
            {
                // Set the placeholder text and change its color
                txtSearchE.Text = placeholderText;
                txtSearchE.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void txtSearchE_Enter(object sender, EventArgs e)
        {
            if (txtSearchE.Text == placeholderText)
            {
                txtSearchE.Text = "";
                txtSearchE.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void txtSearchE_Leave(object sender, EventArgs e)
        {
            SetPlaceholderE();

        }

        private void SetPlaceholderM()
        {
            if (string.IsNullOrWhiteSpace(txtSearchM.Text) || txtSearchM.Text == placeholderText)
            {
                // Set the placeholder text and change its color
                txtSearchM.Text = placeholderText;
                txtSearchM.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void txtSearchM_Enter(object sender, EventArgs e)
        {
            if (txtSearchM.Text == placeholderText)
            {
                txtSearchM.Text = "";
                txtSearchM.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void txtSearchM_Leave(object sender, EventArgs e)
        {
            SetPlaceholderM();

        }

        private void SetPlaceholderTE()
        {
            if (string.IsNullOrWhiteSpace(txtSearchTE.Text) || txtSearchTE.Text == placeholderText)
            {
                // Set the placeholder text and change its color
                txtSearchTE.Text = placeholderText;
                txtSearchTE.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void txtSearchTE_Enter(object sender, EventArgs e)
        {
            if (txtSearchTE.Text == placeholderText)
            {
                txtSearchTE.Text = "";
                txtSearchTE.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void txtSearchTE_Leave(object sender, EventArgs e)
        {
            SetPlaceholderTE();

        }
    }
}
