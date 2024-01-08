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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarWashMIS.Forms
{
    public partial class frmTE : Form
    {
        private string placeholderText = "Enter text here";

        public frmTE()
        {
            InitializeComponent();

            SetPlaceholder();

        }

        private void frmTE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee.M_ToolsEquipments' table. You can move, or remove it, as needed.
            this.m_ToolsEquipmentsTableAdapter.Fill(this.employee.M_ToolsEquipments);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRegisterTE rte = new frmRegisterTE();
            rte.ShowDialog();

            this.m_ToolsEquipmentsTableAdapter.Fill(this.employee.M_ToolsEquipments);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to archive record?", "Archive Tools and Equipments", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvTE.CurrentRow.Cells[0].Value.ToString());

                M_ToolsEquipmentsTableAdapter adp = new M_ToolsEquipmentsTableAdapter();

                adp.ArchiveQuery(id);

                this.m_ToolsEquipmentsTableAdapter.Fill(this.employee.M_ToolsEquipments);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTE.CurrentRow.Cells[0].Value.ToString());
            string name = dgvTE.CurrentRow.Cells["TEName"].Value.ToString();
            string type = dgvTE.CurrentRow.Cells["Type"].Value.ToString();
            int quantity = Convert.ToInt32(dgvTE.CurrentRow.Cells["Quantity"].Value.ToString());
            string category = dgvTE.CurrentRow.Cells["Category"].Value.ToString();

            frmEditTE te = new frmEditTE(name, type, quantity, category, id);
            te.ShowDialog();

            this.m_ToolsEquipmentsTableAdapter.Fill(this.employee.M_ToolsEquipments);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter text here")
            {
                this.m_ToolsEquipmentsTableAdapter.Fill(this.employee.M_ToolsEquipments);
            }
            else
            {
                PopulateGrid();

            }
        }

        private void PopulateGrid()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                this.m_ToolsEquipmentsTableAdapter.FillBySearch(this.employee.M_ToolsEquipments, txtSearch.Text);

            }
            else
            {
                this.m_ToolsEquipmentsTableAdapter.Fill(this.employee.M_ToolsEquipments);

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
            // Check if the TextBox is empty or contains the placeholder text
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
