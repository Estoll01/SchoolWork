namespace Program1_EthanTolliver
{
    partial class QuoteCal
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
            this.CompName = new System.Windows.Forms.Label();
            this.CliNameLb = new System.Windows.Forms.Label();
            this.LocationLb = new System.Windows.Forms.Label();
            this.NOSLb = new System.Windows.Forms.Label();
            this.HWLb = new System.Windows.Forms.Label();
            this.StaffLb = new System.Windows.Forms.Label();
            this.FTDLb = new System.Windows.Forms.Label();
            this.CalButton = new System.Windows.Forms.Button();
            this.CliNameTb = new System.Windows.Forms.TextBox();
            this.LocationTb = new System.Windows.Forms.TextBox();
            this.NOSTb = new System.Windows.Forms.TextBox();
            this.HWTb = new System.Windows.Forms.TextBox();
            this.StaffTb = new System.Windows.Forms.TextBox();
            this.FirstTimeTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientNameTotal = new System.Windows.Forms.Label();
            this.LocationTotal = new System.Windows.Forms.Label();
            this.TotalCostTotal = new System.Windows.Forms.Label();
            this.NameFin = new System.Windows.Forms.Label();
            this.LocationFin = new System.Windows.Forms.Label();
            this.TotalCostFin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompName
            // 
            this.CompName.AutoSize = true;
            this.CompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompName.Location = new System.Drawing.Point(12, 39);
            this.CompName.Name = "CompName";
            this.CompName.Size = new System.Drawing.Size(234, 24);
            this.CompName.TabIndex = 0;
            this.CompName.Text = "Finish Line Renovations";
            this.CompName.Click += new System.EventHandler(this.label1_Click);
            // 
            // CliNameLb
            // 
            this.CliNameLb.AutoSize = true;
            this.CliNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CliNameLb.Location = new System.Drawing.Point(128, 82);
            this.CliNameLb.Name = "CliNameLb";
            this.CliNameLb.Size = new System.Drawing.Size(95, 16);
            this.CliNameLb.TabIndex = 1;
            this.CliNameLb.Text = "Client Name:";
            // 
            // LocationLb
            // 
            this.LocationLb.AutoSize = true;
            this.LocationLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLb.Location = new System.Drawing.Point(153, 108);
            this.LocationLb.Name = "LocationLb";
            this.LocationLb.Size = new System.Drawing.Size(70, 16);
            this.LocationLb.TabIndex = 2;
            this.LocationLb.Text = "Location:";
            // 
            // NOSLb
            // 
            this.NOSLb.AutoSize = true;
            this.NOSLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOSLb.Location = new System.Drawing.Point(110, 135);
            this.NOSLb.Name = "NOSLb";
            this.NOSLb.Size = new System.Drawing.Size(113, 16);
            this.NOSLb.TabIndex = 3;
            this.NOSLb.Text = "Number of Sqft:";
            // 
            // HWLb
            // 
            this.HWLb.AutoSize = true;
            this.HWLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWLb.Location = new System.Drawing.Point(113, 161);
            this.HWLb.Name = "HWLb";
            this.HWLb.Size = new System.Drawing.Size(110, 16);
            this.HWLb.TabIndex = 4;
            this.HWLb.Text = "Hours Worked:";
            // 
            // StaffLb
            // 
            this.StaffLb.AutoSize = true;
            this.StaffLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLb.Location = new System.Drawing.Point(112, 188);
            this.StaffLb.Name = "StaffLb";
            this.StaffLb.Size = new System.Drawing.Size(111, 16);
            this.StaffLb.TabIndex = 5;
            this.StaffLb.Text = "Staff Assigned:";
            this.StaffLb.Click += new System.EventHandler(this.label4_Click);
            // 
            // FTDLb
            // 
            this.FTDLb.AutoSize = true;
            this.FTDLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTDLb.Location = new System.Drawing.Point(27, 216);
            this.FTDLb.Name = "FTDLb";
            this.FTDLb.Size = new System.Drawing.Size(196, 16);
            this.FTDLb.TabIndex = 6;
            this.FTDLb.Text = "First Time Discount (0 or 1):";
            // 
            // CalButton
            // 
            this.CalButton.Location = new System.Drawing.Point(148, 249);
            this.CalButton.Name = "CalButton";
            this.CalButton.Size = new System.Drawing.Size(75, 23);
            this.CalButton.TabIndex = 7;
            this.CalButton.Text = "Calculate";
            this.CalButton.UseVisualStyleBackColor = true;
            this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
            // 
            // CliNameTb
            // 
            this.CliNameTb.Location = new System.Drawing.Point(229, 82);
            this.CliNameTb.Name = "CliNameTb";
            this.CliNameTb.Size = new System.Drawing.Size(100, 20);
            this.CliNameTb.TabIndex = 8;
            // 
            // LocationTb
            // 
            this.LocationTb.Location = new System.Drawing.Point(229, 108);
            this.LocationTb.Name = "LocationTb";
            this.LocationTb.Size = new System.Drawing.Size(100, 20);
            this.LocationTb.TabIndex = 9;
            // 
            // NOSTb
            // 
            this.NOSTb.Location = new System.Drawing.Point(229, 135);
            this.NOSTb.Name = "NOSTb";
            this.NOSTb.Size = new System.Drawing.Size(100, 20);
            this.NOSTb.TabIndex = 10;
            // 
            // HWTb
            // 
            this.HWTb.Location = new System.Drawing.Point(229, 161);
            this.HWTb.Name = "HWTb";
            this.HWTb.Size = new System.Drawing.Size(100, 20);
            this.HWTb.TabIndex = 11;
            // 
            // StaffTb
            // 
            this.StaffTb.Location = new System.Drawing.Point(229, 188);
            this.StaffTb.Name = "StaffTb";
            this.StaffTb.Size = new System.Drawing.Size(100, 20);
            this.StaffTb.TabIndex = 12;
            // 
            // FirstTimeTb
            // 
            this.FirstTimeTb.Location = new System.Drawing.Point(229, 214);
            this.FirstTimeTb.Name = "FirstTimeTb";
            this.FirstTimeTb.Size = new System.Drawing.Size(100, 20);
            this.FirstTimeTb.TabIndex = 13;
            this.FirstTimeTb.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Your Quote";
            // 
            // ClientNameTotal
            // 
            this.ClientNameTotal.AutoSize = true;
            this.ClientNameTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameTotal.Location = new System.Drawing.Point(128, 326);
            this.ClientNameTotal.Name = "ClientNameTotal";
            this.ClientNameTotal.Size = new System.Drawing.Size(95, 16);
            this.ClientNameTotal.TabIndex = 15;
            this.ClientNameTotal.Text = "Client Name:";
            // 
            // LocationTotal
            // 
            this.LocationTotal.AutoSize = true;
            this.LocationTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTotal.Location = new System.Drawing.Point(153, 357);
            this.LocationTotal.Name = "LocationTotal";
            this.LocationTotal.Size = new System.Drawing.Size(70, 16);
            this.LocationTotal.TabIndex = 16;
            this.LocationTotal.Text = "Location:";
            // 
            // TotalCostTotal
            // 
            this.TotalCostTotal.AutoSize = true;
            this.TotalCostTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostTotal.Location = new System.Drawing.Point(141, 388);
            this.TotalCostTotal.Name = "TotalCostTotal";
            this.TotalCostTotal.Size = new System.Drawing.Size(82, 16);
            this.TotalCostTotal.TabIndex = 17;
            this.TotalCostTotal.Text = "Total Cost:";
            this.TotalCostTotal.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // NameFin
            // 
            this.NameFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameFin.Location = new System.Drawing.Point(229, 319);
            this.NameFin.Name = "NameFin";
            this.NameFin.Size = new System.Drawing.Size(100, 23);
            this.NameFin.TabIndex = 18;
            this.NameFin.Click += new System.EventHandler(this.NameFin_Click);
            // 
            // LocationFin
            // 
            this.LocationFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationFin.Location = new System.Drawing.Point(229, 350);
            this.LocationFin.Name = "LocationFin";
            this.LocationFin.Size = new System.Drawing.Size(100, 23);
            this.LocationFin.TabIndex = 19;
            // 
            // TotalCostFin
            // 
            this.TotalCostFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCostFin.Location = new System.Drawing.Point(229, 381);
            this.TotalCostFin.Name = "TotalCostFin";
            this.TotalCostFin.Size = new System.Drawing.Size(100, 23);
            this.TotalCostFin.TabIndex = 20;
            // 
            // QuoteCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalCostFin);
            this.Controls.Add(this.LocationFin);
            this.Controls.Add(this.NameFin);
            this.Controls.Add(this.TotalCostTotal);
            this.Controls.Add(this.LocationTotal);
            this.Controls.Add(this.ClientNameTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstTimeTb);
            this.Controls.Add(this.StaffTb);
            this.Controls.Add(this.HWTb);
            this.Controls.Add(this.NOSTb);
            this.Controls.Add(this.LocationTb);
            this.Controls.Add(this.CliNameTb);
            this.Controls.Add(this.CalButton);
            this.Controls.Add(this.FTDLb);
            this.Controls.Add(this.StaffLb);
            this.Controls.Add(this.HWLb);
            this.Controls.Add(this.NOSLb);
            this.Controls.Add(this.LocationLb);
            this.Controls.Add(this.CliNameLb);
            this.Controls.Add(this.CompName);
            this.Name = "QuoteCal";
            this.Text = "Quote Calculator";
            this.Load += new System.EventHandler(this.Program1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompName;
        private System.Windows.Forms.Label CliNameLb;
        private System.Windows.Forms.Label LocationLb;
        private System.Windows.Forms.Label NOSLb;
        private System.Windows.Forms.Label HWLb;
        private System.Windows.Forms.Label StaffLb;
        private System.Windows.Forms.Label FTDLb;
        private System.Windows.Forms.Button CalButton;
        private System.Windows.Forms.TextBox CliNameTb;
        private System.Windows.Forms.TextBox LocationTb;
        private System.Windows.Forms.TextBox NOSTb;
        private System.Windows.Forms.TextBox HWTb;
        private System.Windows.Forms.TextBox StaffTb;
        private System.Windows.Forms.TextBox FirstTimeTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClientNameTotal;
        private System.Windows.Forms.Label LocationTotal;
        private System.Windows.Forms.Label TotalCostTotal;
        private System.Windows.Forms.Label NameFin;
        private System.Windows.Forms.Label LocationFin;
        private System.Windows.Forms.Label TotalCostFin;
    }
}

