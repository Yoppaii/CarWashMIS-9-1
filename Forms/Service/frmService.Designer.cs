namespace CarWashMIS.Forms
{
    partial class frmService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmService));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateCarWash = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnXS = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnXL = new System.Windows.Forms.Button();
            this.lblExtraLarge = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlExtraLarge = new System.Windows.Forms.Panel();
            this.btnL = new System.Windows.Forms.Button();
            this.lblLarge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelLarge = new System.Windows.Forms.Panel();
            this.btnM = new System.Windows.Forms.Button();
            this.lblMedium = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelMedium = new System.Windows.Forms.Panel();
            this.btnS = new System.Windows.Forms.Button();
            this.lblSmall = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSmall = new System.Windows.Forms.Panel();
            this.lblExtraSmall = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvAddOns = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddOnsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraSmall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Small = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Large = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraLarge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAddOnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee = new CarWashMIS.DataSets.Employee();
            this.m_BaseServicesTableAdapter1 = new CarWashMIS.DataSets.EmployeeTableAdapters.M_BaseServicesTableAdapter();
            this.m_AddOnsTableAdapter = new CarWashMIS.DataSets.EmployeeTableAdapters.M_AddOnsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlExtraLarge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelLarge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelMedium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSmall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddOns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAddOnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 48);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(926, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 47);
            this.label11.TabIndex = 5;
            this.label11.Text = "Other Services";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 47);
            this.label10.TabIndex = 4;
            this.label10.Text = "Basic Car Wash";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnUpdateCarWash);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnArchive);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 70);
            this.panel2.TabIndex = 1;
            // 
            // btnUpdateCarWash
            // 
            this.btnUpdateCarWash.Location = new System.Drawing.Point(18, 12);
            this.btnUpdateCarWash.Name = "btnUpdateCarWash";
            this.btnUpdateCarWash.Size = new System.Drawing.Size(100, 50);
            this.btnUpdateCarWash.TabIndex = 11;
            this.btnUpdateCarWash.Text = "Update Price";
            this.btnUpdateCarWash.UseVisualStyleBackColor = true;
            this.btnUpdateCarWash.Click += new System.EventHandler(this.btnUpdateCarWash_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(846, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1035, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 50);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1152, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(1258, 12);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(100, 50);
            this.btnArchive.TabIndex = 7;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(560, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 29);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnXS
            // 
            this.btnXS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXS.Location = new System.Drawing.Point(446, 0);
            this.btnXS.Name = "btnXS";
            this.btnXS.Size = new System.Drawing.Size(84, 45);
            this.btnXS.TabIndex = 12;
            this.btnXS.Text = "Extra Small List";
            this.btnXS.UseVisualStyleBackColor = true;
            this.btnXS.Click += new System.EventHandler(this.btnXS_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.pnlExtraLarge);
            this.panel3.Controls.Add(this.panelLarge);
            this.panel3.Controls.Add(this.panelMedium);
            this.panel3.Controls.Add(this.panelSmall);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 682);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnXL);
            this.panel6.Controls.Add(this.lblExtraLarge);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 540);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 135);
            this.panel6.TabIndex = 12;
            // 
            // btnXL
            // 
            this.btnXL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXL.Location = new System.Drawing.Point(446, 0);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(84, 45);
            this.btnXL.TabIndex = 16;
            this.btnXL.Text = "Extra Large List";
            this.btnXL.UseVisualStyleBackColor = true;
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // lblExtraLarge
            // 
            this.lblExtraLarge.AutoSize = true;
            this.lblExtraLarge.BackColor = System.Drawing.Color.Transparent;
            this.lblExtraLarge.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraLarge.Location = new System.Drawing.Point(85, 49);
            this.lblExtraLarge.Name = "lblExtraLarge";
            this.lblExtraLarge.Size = new System.Drawing.Size(0, 65);
            this.lblExtraLarge.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 65);
            this.label12.TabIndex = 5;
            this.label12.Text = "₱";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 45);
            this.label13.TabIndex = 4;
            this.label13.Text = "Extra Large";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Location = new System.Drawing.Point(173, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(357, 135);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pnlExtraLarge
            // 
            this.pnlExtraLarge.BackColor = System.Drawing.Color.White;
            this.pnlExtraLarge.Controls.Add(this.btnL);
            this.pnlExtraLarge.Controls.Add(this.lblLarge);
            this.pnlExtraLarge.Controls.Add(this.label4);
            this.pnlExtraLarge.Controls.Add(this.label7);
            this.pnlExtraLarge.Controls.Add(this.pictureBox4);
            this.pnlExtraLarge.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExtraLarge.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlExtraLarge.Location = new System.Drawing.Point(0, 405);
            this.pnlExtraLarge.Name = "pnlExtraLarge";
            this.pnlExtraLarge.Size = new System.Drawing.Size(530, 135);
            this.pnlExtraLarge.TabIndex = 11;
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(446, 0);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(84, 45);
            this.btnL.TabIndex = 15;
            this.btnL.Text = "Large List";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.BackColor = System.Drawing.Color.Transparent;
            this.lblLarge.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(85, 49);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(0, 65);
            this.lblLarge.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 65);
            this.label4.TabIndex = 5;
            this.label4.Text = "₱";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 45);
            this.label7.TabIndex = 4;
            this.label7.Text = "Large";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Location = new System.Drawing.Point(173, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(357, 135);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // panelLarge
            // 
            this.panelLarge.BackColor = System.Drawing.Color.White;
            this.panelLarge.Controls.Add(this.btnM);
            this.panelLarge.Controls.Add(this.lblMedium);
            this.panelLarge.Controls.Add(this.label8);
            this.panelLarge.Controls.Add(this.label9);
            this.panelLarge.Controls.Add(this.pictureBox3);
            this.panelLarge.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLarge.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLarge.Location = new System.Drawing.Point(0, 270);
            this.panelLarge.Name = "panelLarge";
            this.panelLarge.Size = new System.Drawing.Size(530, 135);
            this.panelLarge.TabIndex = 10;
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(446, 0);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(84, 45);
            this.btnM.TabIndex = 14;
            this.btnM.Text = "Medium List";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.BackColor = System.Drawing.Color.Transparent;
            this.lblMedium.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.Location = new System.Drawing.Point(85, 46);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(0, 65);
            this.lblMedium.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 65);
            this.label8.TabIndex = 5;
            this.label8.Text = "₱";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 45);
            this.label9.TabIndex = 4;
            this.label9.Text = "Medium";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Location = new System.Drawing.Point(173, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(357, 135);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panelMedium
            // 
            this.panelMedium.BackColor = System.Drawing.Color.White;
            this.panelMedium.Controls.Add(this.btnS);
            this.panelMedium.Controls.Add(this.lblSmall);
            this.panelMedium.Controls.Add(this.label5);
            this.panelMedium.Controls.Add(this.label6);
            this.panelMedium.Controls.Add(this.pictureBox2);
            this.panelMedium.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedium.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMedium.Location = new System.Drawing.Point(0, 135);
            this.panelMedium.Name = "panelMedium";
            this.panelMedium.Size = new System.Drawing.Size(530, 135);
            this.panelMedium.TabIndex = 9;
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(446, 0);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(84, 45);
            this.btnS.TabIndex = 13;
            this.btnS.Text = "Small List";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // lblSmall
            // 
            this.lblSmall.AutoSize = true;
            this.lblSmall.BackColor = System.Drawing.Color.Transparent;
            this.lblSmall.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmall.Location = new System.Drawing.Point(85, 49);
            this.lblSmall.Name = "lblSmall";
            this.lblSmall.Size = new System.Drawing.Size(0, 65);
            this.lblSmall.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 65);
            this.label5.TabIndex = 5;
            this.label5.Text = "₱";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 45);
            this.label6.TabIndex = 4;
            this.label6.Text = "Small";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(173, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(357, 135);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelSmall
            // 
            this.panelSmall.BackColor = System.Drawing.Color.White;
            this.panelSmall.Controls.Add(this.btnXS);
            this.panelSmall.Controls.Add(this.lblExtraSmall);
            this.panelSmall.Controls.Add(this.label2);
            this.panelSmall.Controls.Add(this.label1);
            this.panelSmall.Controls.Add(this.pictureBox1);
            this.panelSmall.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSmall.Location = new System.Drawing.Point(0, 0);
            this.panelSmall.Name = "panelSmall";
            this.panelSmall.Size = new System.Drawing.Size(530, 135);
            this.panelSmall.TabIndex = 8;
            // 
            // lblExtraSmall
            // 
            this.lblExtraSmall.AutoSize = true;
            this.lblExtraSmall.BackColor = System.Drawing.Color.Transparent;
            this.lblExtraSmall.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraSmall.Location = new System.Drawing.Point(85, 46);
            this.lblExtraSmall.Name = "lblExtraSmall";
            this.lblExtraSmall.Size = new System.Drawing.Size(0, 65);
            this.lblExtraSmall.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "₱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Extra Small";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(173, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(530, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 682);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvAddOns);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(560, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(810, 682);
            this.panel5.TabIndex = 4;
            // 
            // dgvAddOns
            // 
            this.dgvAddOns.AllowUserToAddRows = false;
            this.dgvAddOns.AllowUserToDeleteRows = false;
            this.dgvAddOns.AllowUserToResizeColumns = false;
            this.dgvAddOns.AllowUserToResizeRows = false;
            this.dgvAddOns.AutoGenerateColumns = false;
            this.dgvAddOns.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddOns.ColumnHeadersHeight = 30;
            this.dgvAddOns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.AddOnsName,
            this.ExtraSmall,
            this.Small,
            this.Medium,
            this.Large,
            this.ExtraLarge});
            this.dgvAddOns.DataSource = this.mAddOnsBindingSource;
            this.dgvAddOns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddOns.Location = new System.Drawing.Point(0, 0);
            this.dgvAddOns.Name = "dgvAddOns";
            this.dgvAddOns.RowHeadersVisible = false;
            this.dgvAddOns.RowTemplate.Height = 25;
            this.dgvAddOns.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddOns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddOns.Size = new System.Drawing.Size(810, 682);
            this.dgvAddOns.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 47;
            // 
            // AddOnsName
            // 
            this.AddOnsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddOnsName.DataPropertyName = "Name";
            this.AddOnsName.HeaderText = "Add Ons Name";
            this.AddOnsName.Name = "AddOnsName";
            // 
            // ExtraSmall
            // 
            this.ExtraSmall.DataPropertyName = "ExtraSmall";
            this.ExtraSmall.HeaderText = "Extra Small";
            this.ExtraSmall.Name = "ExtraSmall";
            this.ExtraSmall.Width = 115;
            // 
            // Small
            // 
            this.Small.DataPropertyName = "Small";
            this.Small.HeaderText = "Small";
            this.Small.Name = "Small";
            // 
            // Medium
            // 
            this.Medium.DataPropertyName = "Medium";
            this.Medium.HeaderText = "Medium";
            this.Medium.Name = "Medium";
            // 
            // Large
            // 
            this.Large.DataPropertyName = "Large";
            this.Large.HeaderText = "Large";
            this.Large.Name = "Large";
            // 
            // ExtraLarge
            // 
            this.ExtraLarge.DataPropertyName = "ExtraLarge";
            this.ExtraLarge.HeaderText = "Extra Large";
            this.ExtraLarge.Name = "ExtraLarge";
            this.ExtraLarge.Width = 115;
            // 
            // mAddOnsBindingSource
            // 
            this.mAddOnsBindingSource.DataMember = "M_AddOns";
            this.mAddOnsBindingSource.DataSource = this.employee;
            // 
            // employee
            // 
            this.employee.DataSetName = "Employee";
            this.employee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_BaseServicesTableAdapter1
            // 
            this.m_BaseServicesTableAdapter1.ClearBeforeFill = true;
            // 
            // m_AddOnsTableAdapter
            // 
            this.m_AddOnsTableAdapter.ClearBeforeFill = true;
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 800);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmService";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.frmService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlExtraLarge.ResumeLayout(false);
            this.pnlExtraLarge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelLarge.ResumeLayout(false);
            this.panelLarge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelMedium.ResumeLayout(false);
            this.panelMedium.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSmall.ResumeLayout(false);
            this.panelSmall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddOns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAddOnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlExtraLarge;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelLarge;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelMedium;
        private System.Windows.Forms.Label lblSmall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSmall;
        private System.Windows.Forms.Label lblExtraSmall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvAddOns;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdateCarWash;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblExtraLarge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox5;
        private DataSets.EmployeeTableAdapters.M_BaseServicesTableAdapter m_BaseServicesTableAdapter1;
        private DataSets.Employee employee;
        private System.Windows.Forms.BindingSource mAddOnsBindingSource;
        private DataSets.EmployeeTableAdapters.M_AddOnsTableAdapter m_AddOnsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddOnsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraSmall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Small;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medium;
        private System.Windows.Forms.DataGridViewTextBoxColumn Large;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraLarge;
        private System.Windows.Forms.Button btnXS;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnXL;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnM;
    }
}