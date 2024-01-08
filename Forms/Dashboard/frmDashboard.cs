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
    public partial class frmDashboard : Form
    {
        private M_AverageTimeTableAdapter adpAvg = new M_AverageTimeTableAdapter();
        private Employee.M_AverageTimeDataTable dtAvg = new Employee.M_AverageTimeDataTable();

        private M_EmployeesTableAdapter adpE = new M_EmployeesTableAdapter();
        private Employee.M_EmployeesDataTable dtE = new Employee.M_EmployeesDataTable();

        private M_MaterialsTableAdapter adpM = new M_MaterialsTableAdapter();
        private Employee.M_MaterialsDataTable dtM = new Employee.M_MaterialsDataTable();

        private M_ToolsEquipmentsTableAdapter adpTE = new M_ToolsEquipmentsTableAdapter();
        private Employee.M_ToolsEquipmentsDataTable dtTE = new Employee.M_ToolsEquipmentsDataTable();

        public frmDashboard()
        {
            InitializeComponent();

            
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            dtAvg = adpAvg.GetData();

            lblXs.Text = dtAvg.Rows[0]["ExtraSmall"].ToString();
            lblS.Text = dtAvg.Rows[0]["Small"].ToString();
            lblM.Text = dtAvg.Rows[0]["Medium"].ToString();
            lblL.Text = dtAvg.Rows[0]["Large"].ToString();
            lblXl.Text = dtAvg.Rows[0]["ExtraLarge"].ToString();


            lblECount.Text = adpE.EmployeesCount().ToString();

            lblMCount.Text = adpM.MaterialsCount().ToString();

            lblTCount.Text = adpTE.ToolsCount().ToString();

            lblEqCount.Text = adpTE.EquipmentsCount().ToString();
        }
    }
}
