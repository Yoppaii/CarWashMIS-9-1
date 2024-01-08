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
    public partial class frmMaterials : Form
    {
        private string placeholderText = "Enter text here";

        public frmMaterials()
        {
            InitializeComponent();

            SetPlaceholder();

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            dgvMaterials.DataSource = mMaterialsBindingSource;
            // TODO: This line of code loads data into the 'employee.M_Materials' table. You can move, or remove it, as needed.
            this.m_MaterialsTableAdapter.Fill(this.employee.M_Materials);

        }

        //-----------------------------------MATERIALS---------------------------------------------------------------------
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRegisterMaterials re = new frmRegisterMaterials();
            re.ShowDialog();

            this.m_MaterialsTableAdapter.Fill(this.employee.M_Materials);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to archive record?", "Archive Materials", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvMaterials.CurrentRow.Cells[0].Value.ToString());

                M_MaterialsTableAdapter adp = new M_MaterialsTableAdapter();

                adp.ArchiveQuery(id);

                this.m_MaterialsTableAdapter.Fill(this.employee.M_Materials);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvMaterials.CurrentRow.Cells[0].Value.ToString());
            string name = dgvMaterials.CurrentRow.Cells[1].Value.ToString();
            string type = dgvMaterials.CurrentRow.Cells[2].Value.ToString();
            string unit = dgvMaterials.CurrentRow.Cells[3].Value.ToString();
            int price = Convert.ToInt32(dgvMaterials.CurrentRow.Cells[4].Value.ToString());
            int quantity = Convert.ToInt32(dgvMaterials.CurrentRow.Cells[5].Value.ToString());
            string acquisition = dgvMaterials.CurrentRow.Cells[6].Value.ToString();
            string expiration = dgvMaterials.CurrentRow.Cells[7].Value.ToString();


            frmEditMaterials em = new frmEditMaterials(name, type, unit, price, quantity, acquisition, expiration, id);
            em.ShowDialog();

            this.m_MaterialsTableAdapter.Fill(this.employee.M_Materials);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter text here")
            {
                this.m_MaterialsTableAdapter.Fill(this.employee.M_Materials);
            }
            else
            {
                PopulateGrid();

            }
        }

        private void PopulateGrid()
        {
            if(!string.IsNullOrEmpty(txtSearch.Text))
            {
                this.m_MaterialsTableAdapter.FillBySearch(this.employee.M_Materials, txtSearch.Text);

            }
            else
            {
                this.m_MaterialsTableAdapter.Fill(this.employee.M_Materials);
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
