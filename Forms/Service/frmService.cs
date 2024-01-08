using CarWashMIS.DataSets;
using CarWashMIS.DataSets.EmployeeTableAdapters;
using CarWashMIS.Forms;
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
    public partial class frmService : Form
    {
        private M_BaseServicesTableAdapter adp;
        private Employee.M_BaseServicesDataTable dt;
        //private Table_BaseServiceTableAdapter adpBaseService;
        //private Employee.Table_BaseServiceDataTable dtBaseService;

        private string placeholderText = "Enter text here";

        public frmService()
        {
            InitializeComponent();

            SetPlaceholder();

            //adpBaseService = new Table_BaseServiceTableAdapter();
            //dtBaseService = new Employee.Table_BaseServiceDataTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee.M_AddOns' table. You can move, or remove it, as needed.
            this.m_AddOnsTableAdapter.Fill(this.employee.M_AddOns);
            // TODO: This line of code loads data into the 'employee.M_AddOns' table. You can move, or remove it, as needed.
            this.m_AddOnsTableAdapter.Fill(this.employee.M_AddOns);
            // TODO: This line of code loads data into the 'employee.M_AddOns' table. You can move, or remove it, as needed.
            //// TODO: This line of code loads data into the 'employee.Table_Service' table. You can move, or remove it, as needed.
            //this.table_ServiceTableAdapter.FillService(this.employee.Table_Service);

            //Employee.Table_BaseServiceDataTable dtBaseService = adpBaseService.GetService();

            //if (dtBaseService.Rows.Count > 0)
            //{
            //    lblSmall.Text = dtBaseService.Rows[0]["Small"].ToString();
            //    lblMedium.Text = dtBaseService.Rows[0]["Medium"].ToString();
            //    lblLarge.Text = dtBaseService.Rows[0]["Large"].ToString();
            //}

            adp = new M_BaseServicesTableAdapter();
            dt = new Employee.M_BaseServicesDataTable();

            dt = adp.GetData();
            lblExtraSmall.Text = dt.Rows[0]["ExtraSmall"].ToString();
            lblSmall.Text = dt.Rows[0]["Small"].ToString();
            lblMedium.Text = dt.Rows[0]["Medium"].ToString();
            lblLarge.Text = dt.Rows[0]["Large"].ToString();
            lblExtraLarge.Text = dt.Rows[0]["ExtraLarge"].ToString();

        }

        private void btnUpdateCarWash_Click(object sender, EventArgs e)
        {
            int id = 1;

            frmEditBaseService bs = new frmEditBaseService(Convert.ToInt32(lblExtraSmall.Text), Convert.ToInt32(lblSmall.Text), Convert.ToInt32(lblMedium.Text), Convert.ToInt32(lblLarge.Text), Convert.ToInt32(lblExtraLarge.Text), id);
            bs.ShowDialog();

            adp = new M_BaseServicesTableAdapter();
            dt = new Employee.M_BaseServicesDataTable();

            dt = adp.GetData();

            lblExtraSmall.Text = dt.Rows[0]["ExtraSmall"].ToString();
            lblSmall.Text = dt.Rows[0]["Small"].ToString();
            lblMedium.Text = dt.Rows[0]["Medium"].ToString();
            lblLarge.Text = dt.Rows[0]["Large"].ToString();
            lblExtraLarge.Text = dt.Rows[0]["ExtraLarge"].ToString();

            this.m_BaseServicesTableAdapter1.Fill(this.employee.M_BaseServices);

            //int id = 1;
            //frmEditBS bs = new frmEditBS(Convert.ToInt32(lblSmall.Text), id);
            //bs.ShowDialog();

            //dtBaseService = adpBaseService.GetService();

            //lblSmall.Text = dtBaseService.Rows[0]["Small"].ToString();
            //lblMedium.Text = dtBaseService.Rows[0]["Medium"].ToString();
            //lblLarge.Text = dtBaseService.Rows[0]["Large"].ToString();


            //this.table_BaseServiceTableAdapter1.FillService(this.employee.Table_BaseService);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(dgvService.CurrentRow.Cells[0].Value.ToString());
            //string name = dgvService.CurrentRow.Cells["NameS"].Value.ToString();
            //int price = Convert.ToInt32(dgvService.CurrentRow.Cells["Small"].Value.ToString());


            //frmEditService es = new frmEditService(name, price, id);
            //es.ShowDialog();

            //this.table_ServiceTableAdapter.FillService(this.employee.Table_Service);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DialogResult result = MessageBox.Show("Do you want to delete this record?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //    if (result == DialogResult.OK)
            //    {
            //        int id = Convert.ToInt32(dgvService.CurrentRow.Cells[0].Value.ToString());

            //        Table_ServiceTableAdapter adpService = new Table_ServiceTableAdapter();

            //        adpService.DeleteService(id);

            //        this.table_ServiceTableAdapter.FillService(this.employee.Table_Service);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        //-------------------------------BASESERVICE------------------------------------------------
        private void btnEditBS_Click(object sender, EventArgs e)
        {
            //int id = 1;
            //frmEditBS bs = new frmEditBS(Convert.ToInt32(lblSmall.Text), id);
            //bs.ShowDialog();

            //dtBaseService = adpBaseService.GetService();

            //lblSmall.Text = dtBaseService.Rows[0]["Small"].ToString();
            //lblMedium.Text = dtBaseService.Rows[0]["Medium"].ToString();
            //lblLarge.Text = dtBaseService.Rows[0]["Large"].ToString();


            //this.table_BaseServiceTableAdapter1.FillService(this.employee.Table_BaseService);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter text here")
            {
                this.m_AddOnsTableAdapter.Fill(this.employee.M_AddOns);
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
                this.m_AddOnsTableAdapter.FillBySearch(this.employee.M_AddOns, txtSearch.Text);

            }
            else
            {
                this.m_AddOnsTableAdapter.Fill(this.employee.M_AddOns);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRegisterAddOns re = new frmRegisterAddOns();
            re.ShowDialog();

            this.m_AddOnsTableAdapter.Fill(this.employee.M_AddOns);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvAddOns.CurrentRow.Cells[0].Value);
            string name = dgvAddOns.CurrentRow.Cells["AddOnsName"].Value.ToString();
            int extraSmall = Convert.ToInt32(dgvAddOns.CurrentRow.Cells["ExtraSmall"].Value);
            int small = Convert.ToInt32(dgvAddOns.CurrentRow.Cells["Small"].Value);
            int medium = Convert.ToInt32(dgvAddOns.CurrentRow.Cells["Medium"].Value);
            int large = Convert.ToInt32(dgvAddOns.CurrentRow.Cells["Large"].Value);
            int extraLarge = Convert.ToInt32(dgvAddOns.CurrentRow.Cells["ExtraLarge"].Value);

            frmEditAddOns es = new frmEditAddOns(name,extraSmall, small, medium, large, extraLarge, id);
            es.ShowDialog();

            this.m_AddOnsTableAdapter.Fill(this.employee.M_AddOns);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to archive record?", "Archive Tools and Equipments", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvAddOns.CurrentRow.Cells[0].Value);

                M_AddOnsTableAdapter adp = new M_AddOnsTableAdapter();
                adp.ArchiveQuery(id);

                this.m_AddOnsTableAdapter.Fill(this.employee.M_AddOns);
            }

        }

        private void btnXS_Click(object sender, EventArgs e)
        {
            frmViewExtraSmall xs = new frmViewExtraSmall();
            xs.ShowDialog();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            frmViewSmall s = new frmViewSmall();
            s.ShowDialog();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            formViewMedium m = new formViewMedium();
            m.ShowDialog();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            frmViewLarge l = new frmViewLarge();
            l.ShowDialog();
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            frmViewExtraSmall xl = new frmViewExtraSmall();
            xl.ShowDialog();
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
