namespace Program2
{
    partial class IPCform
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
            this.Namelb = new System.Windows.Forms.Label();
            this.Agelb = new System.Windows.Forms.Label();
            this.Carlb = new System.Windows.Forms.Label();
            this.Healthlb = new System.Windows.Forms.Label();
            this.CarInsurlb = new System.Windows.Forms.Label();
            this.Smokelb = new System.Windows.Forms.Label();
            this.Accidentlb = new System.Windows.Forms.Label();
            this.GroupBd1 = new System.Windows.Forms.GroupBox();
            this.Groupbd2 = new System.Windows.Forms.GroupBox();
            this.HealthCPYlb = new System.Windows.Forms.Label();
            this.CarCPYlb = new System.Windows.Forms.Label();
            this.TotalCPYlb = new System.Windows.Forms.Label();
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.CarTB = new System.Windows.Forms.TextBox();
            this.HealthInsurCB = new System.Windows.Forms.ComboBox();
            this.CarInsurCB = new System.Windows.Forms.ComboBox();
            this.HealthCPY = new System.Windows.Forms.Label();
            this.CarCPY = new System.Windows.Forms.Label();
            this.TotalCPY = new System.Windows.Forms.Label();
            this.SmokeRBy = new System.Windows.Forms.RadioButton();
            this.SmokeRBn = new System.Windows.Forms.RadioButton();
            this.CarRBy = new System.Windows.Forms.RadioButton();
            this.CarRBn = new System.Windows.Forms.RadioButton();
            this.CalButton = new System.Windows.Forms.Button();
            this.GroupBd1.SuspendLayout();
            this.Groupbd2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Namelb
            // 
            this.Namelb.AutoSize = true;
            this.Namelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelb.Location = new System.Drawing.Point(244, 9);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(284, 15);
            this.Namelb.TabIndex = 0;
            this.Namelb.Text = "Comprehensive Insurance Policy Calculator";
            // 
            // Agelb
            // 
            this.Agelb.AutoSize = true;
            this.Agelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agelb.Location = new System.Drawing.Point(107, 39);
            this.Agelb.Name = "Agelb";
            this.Agelb.Size = new System.Drawing.Size(91, 15);
            this.Agelb.TabIndex = 1;
            this.Agelb.Text = "Enter Your Age:";
            // 
            // Carlb
            // 
            this.Carlb.AutoSize = true;
            this.Carlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carlb.Location = new System.Drawing.Point(107, 72);
            this.Carlb.Name = "Carlb";
            this.Carlb.Size = new System.Drawing.Size(134, 15);
            this.Carlb.TabIndex = 2;
            this.Carlb.Text = "Estimated Value of Car:";
            // 
            // Healthlb
            // 
            this.Healthlb.AutoSize = true;
            this.Healthlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Healthlb.Location = new System.Drawing.Point(107, 105);
            this.Healthlb.Name = "Healthlb";
            this.Healthlb.Size = new System.Drawing.Size(158, 15);
            this.Healthlb.TabIndex = 3;
            this.Healthlb.Text = "Health Insurance Coverage:";
            // 
            // CarInsurlb
            // 
            this.CarInsurlb.AutoSize = true;
            this.CarInsurlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarInsurlb.Location = new System.Drawing.Point(107, 140);
            this.CarInsurlb.Name = "CarInsurlb";
            this.CarInsurlb.Size = new System.Drawing.Size(141, 15);
            this.CarInsurlb.TabIndex = 4;
            this.CarInsurlb.Text = "Car Insurance Coverage:";
            // 
            // Smokelb
            // 
            this.Smokelb.AutoSize = true;
            this.Smokelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smokelb.Location = new System.Drawing.Point(6, 16);
            this.Smokelb.Name = "Smokelb";
            this.Smokelb.Size = new System.Drawing.Size(96, 15);
            this.Smokelb.TabIndex = 5;
            this.Smokelb.Text = "Do You Smoke?";
            // 
            // Accidentlb
            // 
            this.Accidentlb.AutoSize = true;
            this.Accidentlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accidentlb.Location = new System.Drawing.Point(6, 16);
            this.Accidentlb.Name = "Accidentlb";
            this.Accidentlb.Size = new System.Drawing.Size(170, 15);
            this.Accidentlb.TabIndex = 6;
            this.Accidentlb.Text = "Car Accident in the Past Year?";
            this.Accidentlb.Click += new System.EventHandler(this.Accidentlb_Click);
            // 
            // GroupBd1
            // 
            this.GroupBd1.Controls.Add(this.SmokeRBn);
            this.GroupBd1.Controls.Add(this.SmokeRBy);
            this.GroupBd1.Controls.Add(this.Smokelb);
            this.GroupBd1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroupBd1.Location = new System.Drawing.Point(110, 158);
            this.GroupBd1.Name = "GroupBd1";
            this.GroupBd1.Size = new System.Drawing.Size(377, 77);
            this.GroupBd1.TabIndex = 7;
            this.GroupBd1.TabStop = false;
            this.GroupBd1.Enter += new System.EventHandler(this.GroupBd1_Enter);
            // 
            // Groupbd2
            // 
            this.Groupbd2.Controls.Add(this.CarRBn);
            this.Groupbd2.Controls.Add(this.CarRBy);
            this.Groupbd2.Controls.Add(this.Accidentlb);
            this.Groupbd2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Groupbd2.Location = new System.Drawing.Point(110, 241);
            this.Groupbd2.Name = "Groupbd2";
            this.Groupbd2.Size = new System.Drawing.Size(377, 77);
            this.Groupbd2.TabIndex = 8;
            this.Groupbd2.TabStop = false;
            // 
            // HealthCPYlb
            // 
            this.HealthCPYlb.AutoSize = true;
            this.HealthCPYlb.Location = new System.Drawing.Point(116, 360);
            this.HealthCPYlb.Name = "HealthCPYlb";
            this.HealthCPYlb.Size = new System.Drawing.Size(157, 13);
            this.HealthCPYlb.TabIndex = 9;
            this.HealthCPYlb.Text = "Health Coverage Cost per Year:";
            // 
            // CarCPYlb
            // 
            this.CarCPYlb.AutoSize = true;
            this.CarCPYlb.Location = new System.Drawing.Point(116, 388);
            this.CarCPYlb.Name = "CarCPYlb";
            this.CarCPYlb.Size = new System.Drawing.Size(142, 13);
            this.CarCPYlb.TabIndex = 10;
            this.CarCPYlb.Text = "Car Coverage Cost per Year:";
            // 
            // TotalCPYlb
            // 
            this.TotalCPYlb.AutoSize = true;
            this.TotalCPYlb.Location = new System.Drawing.Point(116, 414);
            this.TotalCPYlb.Name = "TotalCPYlb";
            this.TotalCPYlb.Size = new System.Drawing.Size(132, 13);
            this.TotalCPYlb.TabIndex = 11;
            this.TotalCPYlb.Text = "Total Policy Cost per Year:";
            this.TotalCPYlb.Click += new System.EventHandler(this.TotalCPYlb_Click);
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(280, 34);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(100, 20);
            this.AgeTB.TabIndex = 12;
            this.AgeTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CarTB
            // 
            this.CarTB.Location = new System.Drawing.Point(280, 60);
            this.CarTB.Name = "CarTB";
            this.CarTB.Size = new System.Drawing.Size(100, 20);
            this.CarTB.TabIndex = 13;
            // 
            // HealthInsurCB
            // 
            this.HealthInsurCB.FormattingEnabled = true;
            this.HealthInsurCB.Items.AddRange(new object[] {
            "Preventive",
            "Hospital",
            "Prescription",
            "None"});
            this.HealthInsurCB.Location = new System.Drawing.Point(280, 99);
            this.HealthInsurCB.Name = "HealthInsurCB";
            this.HealthInsurCB.Size = new System.Drawing.Size(121, 21);
            this.HealthInsurCB.TabIndex = 14;
            // 
            // CarInsurCB
            // 
            this.CarInsurCB.FormattingEnabled = true;
            this.CarInsurCB.Items.AddRange(new object[] {
            "Full",
            "Partial",
            "None"});
            this.CarInsurCB.Location = new System.Drawing.Point(280, 134);
            this.CarInsurCB.Name = "CarInsurCB";
            this.CarInsurCB.Size = new System.Drawing.Size(121, 21);
            this.CarInsurCB.TabIndex = 15;
            // 
            // HealthCPY
            // 
            this.HealthCPY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HealthCPY.Location = new System.Drawing.Point(301, 360);
            this.HealthCPY.Name = "HealthCPY";
            this.HealthCPY.Size = new System.Drawing.Size(100, 13);
            this.HealthCPY.TabIndex = 16;
            // 
            // CarCPY
            // 
            this.CarCPY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarCPY.Location = new System.Drawing.Point(301, 387);
            this.CarCPY.Name = "CarCPY";
            this.CarCPY.Size = new System.Drawing.Size(100, 13);
            this.CarCPY.TabIndex = 17;
            // 
            // TotalCPY
            // 
            this.TotalCPY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCPY.Location = new System.Drawing.Point(301, 413);
            this.TotalCPY.Name = "TotalCPY";
            this.TotalCPY.Size = new System.Drawing.Size(100, 13);
            this.TotalCPY.TabIndex = 18;
            // 
            // SmokeRBy
            // 
            this.SmokeRBy.AutoSize = true;
            this.SmokeRBy.Location = new System.Drawing.Point(227, 14);
            this.SmokeRBy.Name = "SmokeRBy";
            this.SmokeRBy.Size = new System.Drawing.Size(43, 17);
            this.SmokeRBy.TabIndex = 19;
            this.SmokeRBy.TabStop = true;
            this.SmokeRBy.Text = "Yes";
            this.SmokeRBy.UseVisualStyleBackColor = true;
            // 
            // SmokeRBn
            // 
            this.SmokeRBn.AutoSize = true;
            this.SmokeRBn.Location = new System.Drawing.Point(227, 37);
            this.SmokeRBn.Name = "SmokeRBn";
            this.SmokeRBn.Size = new System.Drawing.Size(39, 17);
            this.SmokeRBn.TabIndex = 20;
            this.SmokeRBn.TabStop = true;
            this.SmokeRBn.Text = "No";
            this.SmokeRBn.UseVisualStyleBackColor = true;
            // 
            // CarRBy
            // 
            this.CarRBy.AutoSize = true;
            this.CarRBy.Location = new System.Drawing.Point(227, 19);
            this.CarRBy.Name = "CarRBy";
            this.CarRBy.Size = new System.Drawing.Size(43, 17);
            this.CarRBy.TabIndex = 20;
            this.CarRBy.TabStop = true;
            this.CarRBy.Text = "Yes";
            this.CarRBy.UseVisualStyleBackColor = true;
            this.CarRBy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CarRBn
            // 
            this.CarRBn.AutoSize = true;
            this.CarRBn.Location = new System.Drawing.Point(227, 42);
            this.CarRBn.Name = "CarRBn";
            this.CarRBn.Size = new System.Drawing.Size(39, 17);
            this.CarRBn.TabIndex = 21;
            this.CarRBn.TabStop = true;
            this.CarRBn.Text = "No";
            this.CarRBn.UseVisualStyleBackColor = true;
            // 
            // CalButton
            // 
            this.CalButton.Location = new System.Drawing.Point(261, 324);
            this.CalButton.Name = "CalButton";
            this.CalButton.Size = new System.Drawing.Size(140, 23);
            this.CalButton.TabIndex = 19;
            this.CalButton.Text = "Calculate Policy Premiums";
            this.CalButton.UseVisualStyleBackColor = true;
            this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
            // 
            // IPCform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalButton);
            this.Controls.Add(this.TotalCPY);
            this.Controls.Add(this.CarCPY);
            this.Controls.Add(this.HealthCPY);
            this.Controls.Add(this.CarInsurCB);
            this.Controls.Add(this.HealthInsurCB);
            this.Controls.Add(this.CarTB);
            this.Controls.Add(this.AgeTB);
            this.Controls.Add(this.TotalCPYlb);
            this.Controls.Add(this.CarCPYlb);
            this.Controls.Add(this.HealthCPYlb);
            this.Controls.Add(this.Groupbd2);
            this.Controls.Add(this.GroupBd1);
            this.Controls.Add(this.CarInsurlb);
            this.Controls.Add(this.Healthlb);
            this.Controls.Add(this.Carlb);
            this.Controls.Add(this.Agelb);
            this.Controls.Add(this.Namelb);
            this.Name = "IPCform";
            this.Text = "Insurance Policy Calculator";
            this.GroupBd1.ResumeLayout(false);
            this.GroupBd1.PerformLayout();
            this.Groupbd2.ResumeLayout(false);
            this.Groupbd2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelb;
        private System.Windows.Forms.Label Agelb;
        private System.Windows.Forms.Label Carlb;
        private System.Windows.Forms.Label Healthlb;
        private System.Windows.Forms.Label CarInsurlb;
        private System.Windows.Forms.Label Smokelb;
        private System.Windows.Forms.Label Accidentlb;
        private System.Windows.Forms.GroupBox GroupBd1;
        private System.Windows.Forms.GroupBox Groupbd2;
        private System.Windows.Forms.Label HealthCPYlb;
        private System.Windows.Forms.Label CarCPYlb;
        private System.Windows.Forms.Label TotalCPYlb;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.TextBox CarTB;
        private System.Windows.Forms.ComboBox HealthInsurCB;
        private System.Windows.Forms.ComboBox CarInsurCB;
        private System.Windows.Forms.Label HealthCPY;
        private System.Windows.Forms.Label CarCPY;
        private System.Windows.Forms.Label TotalCPY;
        private System.Windows.Forms.RadioButton SmokeRBn;
        private System.Windows.Forms.RadioButton SmokeRBy;
        private System.Windows.Forms.RadioButton CarRBy;
        private System.Windows.Forms.RadioButton CarRBn;
        private System.Windows.Forms.Button CalButton;
    }
}

