﻿namespace Effay
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Effay = new Xenon.ThirteenForm();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.thirteenTabControl1 = new Xenon.ThirteenTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoaded = new Xenon.ThirteenTextBox();
            this.btnBrowse = new Xenon.ThirteenButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReset = new Xenon.ThirteenButton();
            this.checkAll = new Xenon.ThirteenCheckBox();
            this.nmModel = new System.Windows.Forms.NumericUpDown();
            this.checkOneAndTwo = new Xenon.ThirteenCheckBox();
            this.checkAvgCdt = new Xenon.ThirteenCheckBox();
            this.checkCdt30 = new Xenon.ThirteenCheckBox();
            this.checkAvgRun = new Xenon.ThirteenCheckBox();
            this.checkAvgOtd = new Xenon.ThirteenCheckBox();
            this.checkOtd20 = new Xenon.ThirteenCheckBox();
            this.checkOtd15 = new Xenon.ThirteenCheckBox();
            this.checkNegWait = new Xenon.ThirteenCheckBox();
            this.checkAvgWait = new Xenon.ThirteenCheckBox();
            this.checkAvgLeg = new Xenon.ThirteenCheckBox();
            this.checkAvgRack = new Xenon.ThirteenCheckBox();
            this.checkRackStore = new Xenon.ThirteenCheckBox();
            this.checkRackIn = new Xenon.ThirteenCheckBox();
            this.nmMinimum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtEfficiency = new Xenon.ThirteenTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAverage = new Xenon.ThirteenTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDriver = new Xenon.ThirteenTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAttribute = new Xenon.ThirteenComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblSelected2 = new System.Windows.Forms.Label();
            this.tabDriver = new Xenon.ThirteenTabControl();
            this.Drivers = new System.Windows.Forms.TabPage();
            this.listDrivers = new System.Windows.Forms.ListBox();
            this.thirteenControlBox1 = new Xenon.ThirteenControlBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Effay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.thirteenTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinimum)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabDriver.SuspendLayout();
            this.Drivers.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Registrant";
            this.columnHeader5.Width = 163;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Employee";
            this.columnHeader6.Width = 153;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Registrant";
            this.columnHeader2.Width = 163;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Employee";
            this.columnHeader3.Width = 153;
            // 
            // Effay
            // 
            this.Effay.AccentColor = System.Drawing.Color.HotPink;
            this.Effay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Effay.ColorScheme = Xenon.ThirteenForm.ColorSchemes.Dark;
            this.Effay.Controls.Add(this.btnRefresh);
            this.Effay.Controls.Add(this.thirteenTabControl1);
            this.Effay.Controls.Add(this.tabDriver);
            this.Effay.Controls.Add(this.thirteenControlBox1);
            this.Effay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Effay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Effay.ForeColor = System.Drawing.Color.White;
            this.Effay.Location = new System.Drawing.Point(0, 0);
            this.Effay.Name = "Effay";
            this.Effay.Size = new System.Drawing.Size(496, 307);
            this.Effay.TabIndex = 0;
            this.Effay.Text = "Effay";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Effay.Properties.Resources.refresh_button;
            this.btnRefresh.Location = new System.Drawing.Point(207, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 26);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseEnter += new System.EventHandler(this.btnRefresh_MouseEnter);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            // 
            // thirteenTabControl1
            // 
            this.thirteenTabControl1.AccentColor = System.Drawing.Color.HotPink;
            this.thirteenTabControl1.ClearColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenTabControl1.ColorScheme = Xenon.ThirteenTabControl.ColorSchemes.Dark;
            this.thirteenTabControl1.Controls.Add(this.tabPage1);
            this.thirteenTabControl1.Controls.Add(this.tabPage2);
            this.thirteenTabControl1.Controls.Add(this.tabPage3);
            this.thirteenTabControl1.ForeColor = System.Drawing.Color.White;
            this.thirteenTabControl1.Location = new System.Drawing.Point(240, 44);
            this.thirteenTabControl1.Name = "thirteenTabControl1";
            this.thirteenTabControl1.SelectedIndex = 0;
            this.thirteenTabControl1.Size = new System.Drawing.Size(244, 251);
            this.thirteenTabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtLoaded);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Browse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loaded:";
            // 
            // txtLoaded
            // 
            this.txtLoaded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtLoaded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoaded.ColorScheme = Xenon.ThirteenTextBox.ColorSchemes.Dark;
            this.txtLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtLoaded.ForeColor = System.Drawing.Color.White;
            this.txtLoaded.Location = new System.Drawing.Point(6, 184);
            this.txtLoaded.Name = "txtLoaded";
            this.txtLoaded.ReadOnly = true;
            this.txtLoaded.Size = new System.Drawing.Size(224, 22);
            this.txtLoaded.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccentColor = System.Drawing.Color.HotPink;
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBrowse.ColorScheme = Xenon.ThirteenButton.ColorSchemes.Dark;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(65, 105);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(111, 29);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Download an excel version of the\r\nreport from thewizardline.com \r\nand browse to i" +
    "t here.";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.checkAll);
            this.tabPage2.Controls.Add(this.nmModel);
            this.tabPage2.Controls.Add(this.checkOneAndTwo);
            this.tabPage2.Controls.Add(this.checkAvgCdt);
            this.tabPage2.Controls.Add(this.checkCdt30);
            this.tabPage2.Controls.Add(this.checkAvgRun);
            this.tabPage2.Controls.Add(this.checkAvgOtd);
            this.tabPage2.Controls.Add(this.checkOtd20);
            this.tabPage2.Controls.Add(this.checkOtd15);
            this.tabPage2.Controls.Add(this.checkNegWait);
            this.tabPage2.Controls.Add(this.checkAvgWait);
            this.tabPage2.Controls.Add(this.checkAvgLeg);
            this.tabPage2.Controls.Add(this.checkAvgRack);
            this.tabPage2.Controls.Add(this.checkRackStore);
            this.tabPage2.Controls.Add(this.checkRackIn);
            this.tabPage2.Controls.Add(this.nmMinimum);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // btnReset
            // 
            this.btnReset.AccentColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReset.ColorScheme = Xenon.ThirteenButton.ColorSchemes.Dark;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(138, 42);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // checkAll
            // 
            this.checkAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.checkAll.Checked = true;
            this.checkAll.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkAll.ForeColor = System.Drawing.Color.White;
            this.checkAll.Location = new System.Drawing.Point(15, 43);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(23, 17);
            this.checkAll.TabIndex = 17;
            this.checkAll.CheckedChanged += new Xenon.ThirteenCheckBox.CheckedChangedEventHandler(this.checkAll_CheckedChanged);
            // 
            // nmModel
            // 
            this.nmModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.nmModel.DecimalPlaces = 2;
            this.nmModel.ForeColor = System.Drawing.Color.White;
            this.nmModel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmModel.Location = new System.Drawing.Point(138, -6);
            this.nmModel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmModel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmModel.Name = "nmModel";
            this.nmModel.Size = new System.Drawing.Size(74, 22);
            this.nmModel.TabIndex = 16;
            this.nmModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmModel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmModel.Visible = false;
            // 
            // checkOneAndTwo
            // 
            this.checkOneAndTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkOneAndTwo.Checked = true;
            this.checkOneAndTwo.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkOneAndTwo.ForeColor = System.Drawing.Color.White;
            this.checkOneAndTwo.Location = new System.Drawing.Point(15, 342);
            this.checkOneAndTwo.Name = "checkOneAndTwo";
            this.checkOneAndTwo.Size = new System.Drawing.Size(66, 17);
            this.checkOneAndTwo.TabIndex = 15;
            this.checkOneAndTwo.Text = "% 1 & 2";
            // 
            // checkAvgCdt
            // 
            this.checkAvgCdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkAvgCdt.Checked = true;
            this.checkAvgCdt.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkAvgCdt.ForeColor = System.Drawing.Color.White;
            this.checkAvgCdt.Location = new System.Drawing.Point(15, 319);
            this.checkAvgCdt.Name = "checkAvgCdt";
            this.checkAvgCdt.Size = new System.Drawing.Size(72, 17);
            this.checkAvgCdt.TabIndex = 14;
            this.checkAvgCdt.Text = "Avg CDT";
            // 
            // checkCdt30
            // 
            this.checkCdt30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkCdt30.Checked = true;
            this.checkCdt30.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkCdt30.ForeColor = System.Drawing.Color.White;
            this.checkCdt30.Location = new System.Drawing.Point(15, 296);
            this.checkCdt30.Name = "checkCdt30";
            this.checkCdt30.Size = new System.Drawing.Size(88, 17);
            this.checkCdt30.TabIndex = 13;
            this.checkCdt30.Text = "% CDT < 30";
            // 
            // checkAvgRun
            // 
            this.checkAvgRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkAvgRun.Checked = true;
            this.checkAvgRun.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkAvgRun.ForeColor = System.Drawing.Color.White;
            this.checkAvgRun.Location = new System.Drawing.Point(15, 273);
            this.checkAvgRun.Name = "checkAvgRun";
            this.checkAvgRun.Size = new System.Drawing.Size(70, 17);
            this.checkAvgRun.TabIndex = 12;
            this.checkAvgRun.Text = "Avg Run";
            // 
            // checkAvgOtd
            // 
            this.checkAvgOtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkAvgOtd.Checked = true;
            this.checkAvgOtd.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkAvgOtd.ForeColor = System.Drawing.Color.White;
            this.checkAvgOtd.Location = new System.Drawing.Point(15, 250);
            this.checkAvgOtd.Name = "checkAvgOtd";
            this.checkAvgOtd.Size = new System.Drawing.Size(73, 17);
            this.checkAvgOtd.TabIndex = 10;
            this.checkAvgOtd.Text = "Avg OTD";
            // 
            // checkOtd20
            // 
            this.checkOtd20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkOtd20.Checked = true;
            this.checkOtd20.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkOtd20.ForeColor = System.Drawing.Color.White;
            this.checkOtd20.Location = new System.Drawing.Point(15, 227);
            this.checkOtd20.Name = "checkOtd20";
            this.checkOtd20.Size = new System.Drawing.Size(89, 17);
            this.checkOtd20.TabIndex = 9;
            this.checkOtd20.Text = "% OTD < 20";
            // 
            // checkOtd15
            // 
            this.checkOtd15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkOtd15.Checked = true;
            this.checkOtd15.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkOtd15.ForeColor = System.Drawing.Color.White;
            this.checkOtd15.Location = new System.Drawing.Point(15, 204);
            this.checkOtd15.Name = "checkOtd15";
            this.checkOtd15.Size = new System.Drawing.Size(89, 17);
            this.checkOtd15.TabIndex = 8;
            this.checkOtd15.Text = "% OTD < 15";
            // 
            // checkNegWait
            // 
            this.checkNegWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkNegWait.Checked = true;
            this.checkNegWait.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkNegWait.ForeColor = System.Drawing.Color.White;
            this.checkNegWait.Location = new System.Drawing.Point(15, 181);
            this.checkNegWait.Name = "checkNegWait";
            this.checkNegWait.Size = new System.Drawing.Size(86, 17);
            this.checkNegWait.TabIndex = 7;
            this.checkNegWait.Text = "% Neg Wait";
            // 
            // checkAvgWait
            // 
            this.checkAvgWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkAvgWait.Checked = true;
            this.checkAvgWait.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkAvgWait.ForeColor = System.Drawing.Color.White;
            this.checkAvgWait.Location = new System.Drawing.Point(15, 158);
            this.checkAvgWait.Name = "checkAvgWait";
            this.checkAvgWait.Size = new System.Drawing.Size(72, 17);
            this.checkAvgWait.TabIndex = 6;
            this.checkAvgWait.Text = "Avg Wait";
            // 
            // checkAvgLeg
            // 
            this.checkAvgLeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkAvgLeg.Checked = true;
            this.checkAvgLeg.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkAvgLeg.ForeColor = System.Drawing.Color.White;
            this.checkAvgLeg.Location = new System.Drawing.Point(15, 135);
            this.checkAvgLeg.Name = "checkAvgLeg";
            this.checkAvgLeg.Size = new System.Drawing.Size(68, 17);
            this.checkAvgLeg.TabIndex = 5;
            this.checkAvgLeg.Text = "Avg Leg";
            // 
            // checkAvgRack
            // 
            this.checkAvgRack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkAvgRack.Checked = true;
            this.checkAvgRack.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkAvgRack.ForeColor = System.Drawing.Color.White;
            this.checkAvgRack.Location = new System.Drawing.Point(15, 112);
            this.checkAvgRack.Name = "checkAvgRack";
            this.checkAvgRack.Size = new System.Drawing.Size(103, 17);
            this.checkAvgRack.TabIndex = 4;
            this.checkAvgRack.Text = "Avg Total Rack";
            // 
            // checkRackStore
            // 
            this.checkRackStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkRackStore.Checked = true;
            this.checkRackStore.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkRackStore.ForeColor = System.Drawing.Color.White;
            this.checkRackStore.Location = new System.Drawing.Point(15, 89);
            this.checkRackStore.Name = "checkRackStore";
            this.checkRackStore.Size = new System.Drawing.Size(96, 17);
            this.checkRackStore.TabIndex = 3;
            this.checkRackStore.Text = "Rack In-Store";
            // 
            // checkRackIn
            // 
            this.checkRackIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.checkRackIn.Checked = true;
            this.checkRackIn.ColorScheme = Xenon.ThirteenCheckBox.ColorSchemes.Dark;
            this.checkRackIn.ForeColor = System.Drawing.Color.White;
            this.checkRackIn.Location = new System.Drawing.Point(15, 66);
            this.checkRackIn.Name = "checkRackIn";
            this.checkRackIn.Size = new System.Drawing.Size(86, 17);
            this.checkRackIn.TabIndex = 2;
            this.checkRackIn.Text = "Rack In/Out";
            // 
            // nmMinimum
            // 
            this.nmMinimum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.nmMinimum.ForeColor = System.Drawing.Color.White;
            this.nmMinimum.Location = new System.Drawing.Point(138, 10);
            this.nmMinimum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmMinimum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMinimum.Name = "nmMinimum";
            this.nmMinimum.Size = new System.Drawing.Size(74, 22);
            this.nmMinimum.TabIndex = 1;
            this.nmMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmMinimum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Minimum Runs: ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage3.Controls.Add(this.txtEfficiency);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtAverage);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtDriver);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cmbAttribute);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblStore);
            this.tabPage3.Controls.Add(this.lblSelected);
            this.tabPage3.Controls.Add(this.lblSelected2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(236, 222);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Driver Info";
            // 
            // txtEfficiency
            // 
            this.txtEfficiency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtEfficiency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEfficiency.ColorScheme = Xenon.ThirteenTextBox.ColorSchemes.Dark;
            this.txtEfficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEfficiency.ForeColor = System.Drawing.Color.White;
            this.txtEfficiency.Location = new System.Drawing.Point(102, 193);
            this.txtEfficiency.Name = "txtEfficiency";
            this.txtEfficiency.ReadOnly = true;
            this.txtEfficiency.Size = new System.Drawing.Size(128, 22);
            this.txtEfficiency.TabIndex = 12;
            this.txtEfficiency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Efficiency:";
            // 
            // txtAverage
            // 
            this.txtAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAverage.ColorScheme = Xenon.ThirteenTextBox.ColorSchemes.Dark;
            this.txtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAverage.ForeColor = System.Drawing.Color.White;
            this.txtAverage.Location = new System.Drawing.Point(102, 166);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(128, 22);
            this.txtAverage.TabIndex = 10;
            this.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Average:";
            // 
            // txtDriver
            // 
            this.txtDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDriver.ColorScheme = Xenon.ThirteenTextBox.ColorSchemes.Dark;
            this.txtDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDriver.ForeColor = System.Drawing.Color.White;
            this.txtDriver.Location = new System.Drawing.Point(102, 139);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.ReadOnly = true;
            this.txtDriver.Size = new System.Drawing.Size(128, 22);
            this.txtDriver.TabIndex = 8;
            this.txtDriver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Driver:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Numbers:";
            // 
            // cmbAttribute
            // 
            this.cmbAttribute.AccentColor = System.Drawing.Color.HotPink;
            this.cmbAttribute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbAttribute.ColorScheme = Xenon.ThirteenComboBox.ColorSchemes.Dark;
            this.cmbAttribute.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAttribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbAttribute.ForeColor = System.Drawing.Color.White;
            this.cmbAttribute.FormattingEnabled = true;
            this.cmbAttribute.Items.AddRange(new object[] {
            "Rack In/Out",
            "Rack In-Store",
            "Avg Total Rack",
            "Avg Leg",
            "Avg Wait",
            "% Neg Wait",
            "% OTD < 15",
            "% OTD < 20",
            "Avg OTD",
            "Avg Run",
            "% CDT < 30",
            "Avg CDT",
            "% 1 & 2",
            "Run Count"});
            this.cmbAttribute.Location = new System.Drawing.Point(102, 100);
            this.cmbAttribute.Name = "cmbAttribute";
            this.cmbAttribute.Size = new System.Drawing.Size(128, 23);
            this.cmbAttribute.TabIndex = 5;
            this.cmbAttribute.SelectedIndexChanged += new System.EventHandler(this.cmbAttribute_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 2);
            this.label4.TabIndex = 4;
            // 
            // lblStore
            // 
            this.lblStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStore.Location = new System.Drawing.Point(0, 52);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(236, 23);
            this.lblStore.TabIndex = 3;
            this.lblStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelected
            // 
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(0, 29);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(236, 23);
            this.lblSelected.TabIndex = 2;
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelected2
            // 
            this.lblSelected2.Location = new System.Drawing.Point(0, 10);
            this.lblSelected2.Name = "lblSelected2";
            this.lblSelected2.Size = new System.Drawing.Size(236, 16);
            this.lblSelected2.TabIndex = 1;
            this.lblSelected2.Text = "Selected Driver:";
            this.lblSelected2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDriver
            // 
            this.tabDriver.AccentColor = System.Drawing.Color.HotPink;
            this.tabDriver.ClearColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabDriver.ColorScheme = Xenon.ThirteenTabControl.ColorSchemes.Dark;
            this.tabDriver.Controls.Add(this.Drivers);
            this.tabDriver.ForeColor = System.Drawing.Color.White;
            this.tabDriver.Location = new System.Drawing.Point(12, 44);
            this.tabDriver.Name = "tabDriver";
            this.tabDriver.SelectedIndex = 0;
            this.tabDriver.Size = new System.Drawing.Size(222, 251);
            this.tabDriver.TabIndex = 30;
            // 
            // Drivers
            // 
            this.Drivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Drivers.Controls.Add(this.listDrivers);
            this.Drivers.Location = new System.Drawing.Point(4, 25);
            this.Drivers.Name = "Drivers";
            this.Drivers.Padding = new System.Windows.Forms.Padding(3);
            this.Drivers.Size = new System.Drawing.Size(214, 222);
            this.Drivers.TabIndex = 0;
            this.Drivers.Text = "Drivers";
            // 
            // listDrivers
            // 
            this.listDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.listDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDrivers.ForeColor = System.Drawing.Color.White;
            this.listDrivers.FormattingEnabled = true;
            this.listDrivers.ItemHeight = 16;
            this.listDrivers.Location = new System.Drawing.Point(6, 6);
            this.listDrivers.Name = "listDrivers";
            this.listDrivers.Size = new System.Drawing.Size(202, 212);
            this.listDrivers.TabIndex = 29;
            this.listDrivers.Tag = "history";
            this.listDrivers.SelectedIndexChanged += new System.EventHandler(this.listDrivers_SelectedIndexChanged);
            // 
            // thirteenControlBox1
            // 
            this.thirteenControlBox1.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thirteenControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenControlBox1.ColorScheme = Xenon.ThirteenControlBox.ColorSchemes.Dark;
            this.thirteenControlBox1.ForeColor = System.Drawing.Color.White;
            this.thirteenControlBox1.Location = new System.Drawing.Point(393, 3);
            this.thirteenControlBox1.Name = "thirteenControlBox1";
            this.thirteenControlBox1.Size = new System.Drawing.Size(100, 25);
            this.thirteenControlBox1.TabIndex = 0;
            this.thirteenControlBox1.Text = "thirteenControlBox1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xlsx";
            this.openFileDialog1.FileName = "Driver Detail";
            this.openFileDialog1.Filter = "Excel Files | *.xlsx";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 307);
            this.Controls.Add(this.Effay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Effay";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Effay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.thirteenTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinimum)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabDriver.ResumeLayout(false);
            this.Drivers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Xenon.ThirteenForm Effay;
        private Xenon.ThirteenControlBox thirteenControlBox1;
        private Xenon.ThirteenTabControl tabDriver;
        private System.Windows.Forms.TabPage Drivers;
        private System.Windows.Forms.ListBox listDrivers;
        private Xenon.ThirteenTabControl thirteenTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private Xenon.ThirteenTextBox txtLoaded;
        private Xenon.ThirteenButton btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown nmMinimum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnRefresh;
        private Xenon.ThirteenCheckBox checkOtd20;
        private Xenon.ThirteenCheckBox checkOtd15;
        private Xenon.ThirteenCheckBox checkNegWait;
        private Xenon.ThirteenCheckBox checkAvgWait;
        private Xenon.ThirteenCheckBox checkAvgLeg;
        private Xenon.ThirteenCheckBox checkAvgRack;
        private Xenon.ThirteenCheckBox checkRackStore;
        private Xenon.ThirteenCheckBox checkRackIn;
        private Xenon.ThirteenCheckBox checkAvgRun;
        private Xenon.ThirteenCheckBox checkAvgOtd;
        private Xenon.ThirteenCheckBox checkOneAndTwo;
        private Xenon.ThirteenCheckBox checkAvgCdt;
        private Xenon.ThirteenCheckBox checkCdt30;
        private System.Windows.Forms.NumericUpDown nmModel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblSelected2;
        private Xenon.ThirteenCheckBox checkAll;
        private Xenon.ThirteenButton btnReset;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label label5;
        private Xenon.ThirteenComboBox cmbAttribute;
        private System.Windows.Forms.Label label4;
        private Xenon.ThirteenTextBox txtEfficiency;
        private System.Windows.Forms.Label label8;
        private Xenon.ThirteenTextBox txtAverage;
        private System.Windows.Forms.Label label7;
        private Xenon.ThirteenTextBox txtDriver;
        private System.Windows.Forms.Label label6;
    }
}

