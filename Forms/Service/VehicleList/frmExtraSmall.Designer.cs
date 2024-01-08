namespace CarWashMIS.Forms.Service
{
    partial class frmViewVehicleLists
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbXs = new System.Windows.Forms.ListBox();
            this.employee = new CarWashMIS.DataSets.Employee();
            this.mVehicleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_VehicleListTableAdapter = new CarWashMIS.DataSets.EmployeeTableAdapters.M_VehicleListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVehicleListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbXs
            // 
            this.lbXs.DataSource = this.mVehicleListBindingSource;
            this.lbXs.DisplayMember = "Name";
            this.lbXs.FormattingEnabled = true;
            this.lbXs.ItemHeight = 20;
            this.lbXs.Location = new System.Drawing.Point(30, 148);
            this.lbXs.Name = "lbXs";
            this.lbXs.Size = new System.Drawing.Size(261, 324);
            this.lbXs.TabIndex = 0;
            // 
            // employee
            // 
            this.employee.DataSetName = "Employee";
            this.employee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mVehicleListBindingSource
            // 
            this.mVehicleListBindingSource.DataMember = "M_VehicleList";
            this.mVehicleListBindingSource.DataSource = this.employee;
            // 
            // m_VehicleListTableAdapter
            // 
            this.m_VehicleListTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewVehicleLists
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 500);
            this.Controls.Add(this.lbXs);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewVehicleLists";
            this.Load += new System.EventHandler(this.frmViewVehicleLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVehicleListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxXS;
        private System.Windows.Forms.TextBox txtXs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddXs;
        private System.Windows.Forms.Button btnRemoveXs;
        private DataSets.EmployeeTableAdapters.M_VehicleListTableAdapter m_VehicleListTableAdapter1;
        private System.Windows.Forms.ListBox lbXs;
        private DataSets.Employee employee;
        private System.Windows.Forms.BindingSource mVehicleListBindingSource;
        private DataSets.EmployeeTableAdapters.M_VehicleListTableAdapter m_VehicleListTableAdapter;
    }
}