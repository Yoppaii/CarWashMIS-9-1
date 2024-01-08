namespace CarWashMIS.Forms
{
    partial class frmArchives
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchives));
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.AddOns = new System.Windows.Forms.TabPage();
            this.pnlAO1 = new System.Windows.Forms.Panel();
            this.pnlAO2 = new System.Windows.Forms.Panel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAddOns = new System.Windows.Forms.DataGridView();
            this.Employees = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSearchE = new System.Windows.Forms.Button();
            this.btnRestoreE = new System.Windows.Forms.Button();
            this.txtSearchE = new System.Windows.Forms.TextBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.Materials = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchM = new System.Windows.Forms.Button();
            this.btnRestoreM = new System.Windows.Forms.Button();
            this.txtSearchM = new System.Windows.Forms.TextBox();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.ToolsEquipments = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearchTE = new System.Windows.Forms.Button();
            this.btnRestoreTE = new System.Windows.Forms.Button();
            this.txtSearchTE = new System.Windows.Forms.TextBox();
            this.dgvTE = new System.Windows.Forms.DataGridView();
            this.tabcontrol.SuspendLayout();
            this.AddOns.SuspendLayout();
            this.pnlAO1.SuspendLayout();
            this.pnlAO2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddOns)).BeginInit();
            this.Employees.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.Materials.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.ToolsEquipments.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTE)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.AddOns);
            this.tabcontrol.Controls.Add(this.Employees);
            this.tabcontrol.Controls.Add(this.Materials);
            this.tabcontrol.Controls.Add(this.ToolsEquipments);
            this.tabcontrol.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1370, 800);
            this.tabcontrol.TabIndex = 1;
            // 
            // AddOns
            // 
            this.AddOns.BackColor = System.Drawing.Color.White;
            this.AddOns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddOns.Controls.Add(this.pnlAO1);
            this.AddOns.Location = new System.Drawing.Point(4, 30);
            this.AddOns.Name = "AddOns";
            this.AddOns.Padding = new System.Windows.Forms.Padding(3);
            this.AddOns.Size = new System.Drawing.Size(1362, 766);
            this.AddOns.TabIndex = 0;
            this.AddOns.Text = "     Add Ons     ";
            // 
            // pnlAO1
            // 
            this.pnlAO1.BackColor = System.Drawing.Color.White;
            this.pnlAO1.Controls.Add(this.pnlAO2);
            this.pnlAO1.Controls.Add(this.dgvAddOns);
            this.pnlAO1.Location = new System.Drawing.Point(7, 6);
            this.pnlAO1.Name = "pnlAO1";
            this.pnlAO1.Size = new System.Drawing.Size(1347, 751);
            this.pnlAO1.TabIndex = 2;
            // 
            // pnlAO2
            // 
            this.pnlAO2.Controls.Add(this.btnRestore);
            this.pnlAO2.Controls.Add(this.txtSearch);
            this.pnlAO2.Controls.Add(this.btnSearch);
            this.pnlAO2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAO2.Location = new System.Drawing.Point(0, 0);
            this.pnlAO2.Name = "pnlAO2";
            this.pnlAO2.Size = new System.Drawing.Size(1347, 70);
            this.pnlAO2.TabIndex = 0;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(977, 9);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(100, 50);
            this.btnRestore.TabIndex = 13;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(267, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 29);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(553, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 29);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvAddOns
            // 
            this.dgvAddOns.AllowUserToAddRows = false;
            this.dgvAddOns.AllowUserToDeleteRows = false;
            this.dgvAddOns.AllowUserToResizeColumns = false;
            this.dgvAddOns.AllowUserToResizeRows = false;
            this.dgvAddOns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAddOns.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddOns.ColumnHeadersHeight = 30;
            this.dgvAddOns.Location = new System.Drawing.Point(267, 76);
            this.dgvAddOns.Name = "dgvAddOns";
            this.dgvAddOns.RowHeadersVisible = false;
            this.dgvAddOns.RowTemplate.Height = 25;
            this.dgvAddOns.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddOns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddOns.Size = new System.Drawing.Size(810, 662);
            this.dgvAddOns.TabIndex = 1;
            // 
            // Employees
            // 
            this.Employees.BackColor = System.Drawing.Color.White;
            this.Employees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Employees.Controls.Add(this.panel5);
            this.Employees.Controls.Add(this.dgvEmployees);
            this.Employees.Location = new System.Drawing.Point(4, 30);
            this.Employees.Name = "Employees";
            this.Employees.Padding = new System.Windows.Forms.Padding(3);
            this.Employees.Size = new System.Drawing.Size(1362, 766);
            this.Employees.TabIndex = 1;
            this.Employees.Text = "  Employees  ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSearchE);
            this.panel5.Controls.Add(this.btnRestoreE);
            this.panel5.Controls.Add(this.txtSearchE);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1354, 70);
            this.panel5.TabIndex = 2;
            // 
            // btnSearchE
            // 
            this.btnSearchE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchE.BackgroundImage")));
            this.btnSearchE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchE.Location = new System.Drawing.Point(301, 21);
            this.btnSearchE.Name = "btnSearchE";
            this.btnSearchE.Size = new System.Drawing.Size(42, 29);
            this.btnSearchE.TabIndex = 14;
            this.btnSearchE.UseVisualStyleBackColor = true;
            this.btnSearchE.Click += new System.EventHandler(this.btnSearchE_Click);
            // 
            // btnRestoreE
            // 
            this.btnRestoreE.Location = new System.Drawing.Point(1240, 9);
            this.btnRestoreE.Name = "btnRestoreE";
            this.btnRestoreE.Size = new System.Drawing.Size(100, 50);
            this.btnRestoreE.TabIndex = 13;
            this.btnRestoreE.Text = "Restore";
            this.btnRestoreE.UseVisualStyleBackColor = true;
            this.btnRestoreE.Click += new System.EventHandler(this.btnRestoreE_Click);
            // 
            // txtSearchE
            // 
            this.txtSearchE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchE.ForeColor = System.Drawing.Color.Black;
            this.txtSearchE.Location = new System.Drawing.Point(15, 21);
            this.txtSearchE.Name = "txtSearchE";
            this.txtSearchE.Size = new System.Drawing.Size(280, 29);
            this.txtSearchE.TabIndex = 11;
            this.txtSearchE.Enter += new System.EventHandler(this.txtSearchE_Enter);
            this.txtSearchE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchE_KeyPress);
            this.txtSearchE.Leave += new System.EventHandler(this.txtSearchE_Leave);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeColumns = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersHeight = 30;
            this.dgvEmployees.Location = new System.Drawing.Point(18, 92);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowTemplate.Height = 25;
            this.dgvEmployees.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1325, 658);
            this.dgvEmployees.TabIndex = 3;
            // 
            // Materials
            // 
            this.Materials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Materials.Controls.Add(this.panel1);
            this.Materials.Location = new System.Drawing.Point(4, 30);
            this.Materials.Name = "Materials";
            this.Materials.Size = new System.Drawing.Size(1362, 766);
            this.Materials.TabIndex = 2;
            this.Materials.Text = "    Materials    ";
            this.Materials.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvMaterials);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 758);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearchM);
            this.panel3.Controls.Add(this.btnRestoreM);
            this.panel3.Controls.Add(this.txtSearchM);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1355, 70);
            this.panel3.TabIndex = 4;
            // 
            // btnSearchM
            // 
            this.btnSearchM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchM.BackgroundImage")));
            this.btnSearchM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchM.Location = new System.Drawing.Point(553, 20);
            this.btnSearchM.Name = "btnSearchM";
            this.btnSearchM.Size = new System.Drawing.Size(42, 29);
            this.btnSearchM.TabIndex = 14;
            this.btnSearchM.UseVisualStyleBackColor = true;
            this.btnSearchM.Click += new System.EventHandler(this.btnSearchM_Click);
            // 
            // btnRestoreM
            // 
            this.btnRestoreM.Location = new System.Drawing.Point(977, 9);
            this.btnRestoreM.Name = "btnRestoreM";
            this.btnRestoreM.Size = new System.Drawing.Size(100, 50);
            this.btnRestoreM.TabIndex = 13;
            this.btnRestoreM.Text = "Restore";
            this.btnRestoreM.UseVisualStyleBackColor = true;
            this.btnRestoreM.Click += new System.EventHandler(this.btnRestoreM_Click);
            // 
            // txtSearchM
            // 
            this.txtSearchM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchM.ForeColor = System.Drawing.Color.Black;
            this.txtSearchM.Location = new System.Drawing.Point(267, 21);
            this.txtSearchM.Name = "txtSearchM";
            this.txtSearchM.Size = new System.Drawing.Size(280, 29);
            this.txtSearchM.TabIndex = 11;
            this.txtSearchM.Enter += new System.EventHandler(this.txtSearchM_Enter);
            this.txtSearchM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchM_KeyPress);
            this.txtSearchM.Leave += new System.EventHandler(this.txtSearchM_Leave);
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AllowUserToAddRows = false;
            this.dgvMaterials.AllowUserToDeleteRows = false;
            this.dgvMaterials.AllowUserToResizeColumns = false;
            this.dgvMaterials.AllowUserToResizeRows = false;
            this.dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMaterials.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterials.ColumnHeadersHeight = 30;
            this.dgvMaterials.Location = new System.Drawing.Point(267, 93);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.RowHeadersVisible = false;
            this.dgvMaterials.RowTemplate.Height = 25;
            this.dgvMaterials.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterials.Size = new System.Drawing.Size(810, 662);
            this.dgvMaterials.TabIndex = 5;
            // 
            // ToolsEquipments
            // 
            this.ToolsEquipments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolsEquipments.Controls.Add(this.panel2);
            this.ToolsEquipments.Location = new System.Drawing.Point(4, 30);
            this.ToolsEquipments.Name = "ToolsEquipments";
            this.ToolsEquipments.Size = new System.Drawing.Size(1362, 766);
            this.ToolsEquipments.TabIndex = 3;
            this.ToolsEquipments.Text = "Tools And Equipments";
            this.ToolsEquipments.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvTE);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1355, 758);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearchTE);
            this.panel4.Controls.Add(this.btnRestoreTE);
            this.panel4.Controls.Add(this.txtSearchTE);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1355, 70);
            this.panel4.TabIndex = 4;
            // 
            // btnSearchTE
            // 
            this.btnSearchTE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchTE.BackgroundImage")));
            this.btnSearchTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchTE.Location = new System.Drawing.Point(528, 21);
            this.btnSearchTE.Name = "btnSearchTE";
            this.btnSearchTE.Size = new System.Drawing.Size(42, 29);
            this.btnSearchTE.TabIndex = 14;
            this.btnSearchTE.UseVisualStyleBackColor = true;
            this.btnSearchTE.Click += new System.EventHandler(this.btnSearchTE_Click);
            // 
            // btnRestoreTE
            // 
            this.btnRestoreTE.Location = new System.Drawing.Point(1031, 9);
            this.btnRestoreTE.Name = "btnRestoreTE";
            this.btnRestoreTE.Size = new System.Drawing.Size(100, 50);
            this.btnRestoreTE.TabIndex = 13;
            this.btnRestoreTE.Text = "Restore";
            this.btnRestoreTE.UseVisualStyleBackColor = true;
            this.btnRestoreTE.Click += new System.EventHandler(this.btnRestoreTE_Click);
            // 
            // txtSearchTE
            // 
            this.txtSearchTE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTE.ForeColor = System.Drawing.Color.Black;
            this.txtSearchTE.Location = new System.Drawing.Point(242, 21);
            this.txtSearchTE.Name = "txtSearchTE";
            this.txtSearchTE.Size = new System.Drawing.Size(280, 29);
            this.txtSearchTE.TabIndex = 11;
            this.txtSearchTE.Enter += new System.EventHandler(this.txtSearchTE_Enter);
            this.txtSearchTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchTE_KeyPress);
            this.txtSearchTE.Leave += new System.EventHandler(this.txtSearchTE_Leave);
            // 
            // dgvTE
            // 
            this.dgvTE.AllowUserToAddRows = false;
            this.dgvTE.AllowUserToDeleteRows = false;
            this.dgvTE.AllowUserToResizeColumns = false;
            this.dgvTE.AllowUserToResizeRows = false;
            this.dgvTE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTE.BackgroundColor = System.Drawing.Color.White;
            this.dgvTE.ColumnHeadersHeight = 30;
            this.dgvTE.Location = new System.Drawing.Point(242, 76);
            this.dgvTE.Name = "dgvTE";
            this.dgvTE.RowHeadersVisible = false;
            this.dgvTE.RowTemplate.Height = 25;
            this.dgvTE.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTE.Size = new System.Drawing.Size(889, 678);
            this.dgvTE.TabIndex = 5;
            // 
            // frmArchives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 800);
            this.Controls.Add(this.tabcontrol);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmArchives";
            this.Text = "Archives";
            this.Load += new System.EventHandler(this.frmArchives_Load);
            this.tabcontrol.ResumeLayout(false);
            this.AddOns.ResumeLayout(false);
            this.pnlAO1.ResumeLayout(false);
            this.pnlAO2.ResumeLayout(false);
            this.pnlAO2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddOns)).EndInit();
            this.Employees.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.Materials.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.ToolsEquipments.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage AddOns;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.DataGridView dgvAddOns;
        private System.Windows.Forms.TabPage Materials;
        private System.Windows.Forms.TabPage ToolsEquipments;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlAO1;
        private System.Windows.Forms.Panel pnlAO2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRestoreM;
        private System.Windows.Forms.TextBox txtSearchM;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRestoreTE;
        private System.Windows.Forms.TextBox txtSearchTE;
        private System.Windows.Forms.DataGridView dgvTE;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRestoreE;
        private System.Windows.Forms.TextBox txtSearchE;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnSearchE;
        private System.Windows.Forms.Button btnSearchM;
        private System.Windows.Forms.Button btnSearchTE;
    }
}