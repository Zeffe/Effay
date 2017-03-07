namespace Effay
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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Effay = new Xenon.ThirteenForm();
            this.tabDriver = new Xenon.ThirteenTabControl();
            this.Drivers = new System.Windows.Forms.TabPage();
            this.listDrivers = new System.Windows.Forms.ListBox();
            this.thirteenControlBox1 = new Xenon.ThirteenControlBox();
            this.thirteenTabControl1 = new Xenon.ThirteenTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new Xenon.ThirteenButton();
            this.txtLoaded = new Xenon.ThirteenTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Effay.SuspendLayout();
            this.tabDriver.SuspendLayout();
            this.Drivers.SuspendLayout();
            this.thirteenTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // thirteenTabControl1
            // 
            this.thirteenTabControl1.AccentColor = System.Drawing.Color.HotPink;
            this.thirteenTabControl1.ClearColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenTabControl1.ColorScheme = Xenon.ThirteenTabControl.ColorSchemes.Dark;
            this.thirteenTabControl1.Controls.Add(this.tabPage1);
            this.thirteenTabControl1.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xlsx";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel Files | *.xlsx";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 307);
            this.Controls.Add(this.Effay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Text = "Effay";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Effay.ResumeLayout(false);
            this.tabDriver.ResumeLayout(false);
            this.Drivers.ResumeLayout(false);
            this.thirteenTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}

