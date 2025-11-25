namespace Program3
{
    partial class ContractCal
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
            this.CaterLb = new System.Windows.Forms.Label();
            this.BusinessLb = new System.Windows.Forms.Label();
            this.ContractYearLb = new System.Windows.Forms.Label();
            this.ContractPriceLb = new System.Windows.Forms.Label();
            this.TitleLb = new System.Windows.Forms.Label();
            this.Calbutton = new System.Windows.Forms.Button();
            this.BusinessCB = new System.Windows.Forms.ComboBox();
            this.CatererCB = new System.Windows.Forms.ComboBox();
            this.ContractPriceTotal = new System.Windows.Forms.Label();
            this.ContractYearTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CaterLb
            // 
            this.CaterLb.AutoSize = true;
            this.CaterLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaterLb.Location = new System.Drawing.Point(51, 72);
            this.CaterLb.Name = "CaterLb";
            this.CaterLb.Size = new System.Drawing.Size(66, 20);
            this.CaterLb.TabIndex = 0;
            this.CaterLb.Text = "Caterer:";
            // 
            // BusinessLb
            // 
            this.BusinessLb.AutoSize = true;
            this.BusinessLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessLb.Location = new System.Drawing.Point(51, 127);
            this.BusinessLb.Name = "BusinessLb";
            this.BusinessLb.Size = new System.Drawing.Size(78, 20);
            this.BusinessLb.TabIndex = 1;
            this.BusinessLb.Text = "Business:";
            // 
            // ContractYearLb
            // 
            this.ContractYearLb.AutoSize = true;
            this.ContractYearLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractYearLb.Location = new System.Drawing.Point(51, 191);
            this.ContractYearLb.Name = "ContractYearLb";
            this.ContractYearLb.Size = new System.Drawing.Size(120, 20);
            this.ContractYearLb.TabIndex = 2;
            this.ContractYearLb.Text = "Contract Years:";
            // 
            // ContractPriceLb
            // 
            this.ContractPriceLb.AutoSize = true;
            this.ContractPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractPriceLb.Location = new System.Drawing.Point(51, 320);
            this.ContractPriceLb.Name = "ContractPriceLb";
            this.ContractPriceLb.Size = new System.Drawing.Size(113, 20);
            this.ContractPriceLb.TabIndex = 3;
            this.ContractPriceLb.Text = "Contract Price:";
            // 
            // TitleLb
            // 
            this.TitleLb.AutoSize = true;
            this.TitleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLb.Location = new System.Drawing.Point(155, 9);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(311, 25);
            this.TitleLb.TabIndex = 4;
            this.TitleLb.Text = "Catering Contract Calculator";
            // 
            // Calbutton
            // 
            this.Calbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calbutton.Location = new System.Drawing.Point(160, 251);
            this.Calbutton.Name = "Calbutton";
            this.Calbutton.Size = new System.Drawing.Size(146, 23);
            this.Calbutton.TabIndex = 5;
            this.Calbutton.Text = "Calculate";
            this.Calbutton.UseVisualStyleBackColor = true;
            this.Calbutton.Click += new System.EventHandler(this.Calbutton_Click);
            // 
            // BusinessCB
            // 
            this.BusinessCB.FormattingEnabled = true;
            this.BusinessCB.Items.AddRange(new object[] {
            "Humana",
            "KFC",
            "LGE",
            "GE",
            "Alpine Intel"});
            this.BusinessCB.Location = new System.Drawing.Point(345, 126);
            this.BusinessCB.Name = "BusinessCB";
            this.BusinessCB.Size = new System.Drawing.Size(121, 21);
            this.BusinessCB.TabIndex = 6;
            // 
            // CatererCB
            // 
            this.CatererCB.FormattingEnabled = true;
            this.CatererCB.Items.AddRange(new object[] {
            "Shalimar",
            "Bombay Grill",
            "Clay Oven",
            "Little India",
            "India Palace"});
            this.CatererCB.Location = new System.Drawing.Point(345, 72);
            this.CatererCB.Name = "CatererCB";
            this.CatererCB.Size = new System.Drawing.Size(121, 21);
            this.CatererCB.TabIndex = 7;
            // 
            // ContractPriceTotal
            // 
            this.ContractPriceTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContractPriceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContractPriceTotal.Location = new System.Drawing.Point(341, 320);
            this.ContractPriceTotal.Name = "ContractPriceTotal";
            this.ContractPriceTotal.Size = new System.Drawing.Size(120, 20);
            this.ContractPriceTotal.TabIndex = 8;
            // 
            // ContractYearTB
            // 
            this.ContractYearTB.Location = new System.Drawing.Point(341, 193);
            this.ContractYearTB.Name = "ContractYearTB";
            this.ContractYearTB.Size = new System.Drawing.Size(120, 20);
            this.ContractYearTB.TabIndex = 9;
            // 
            // ContractCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.ContractYearTB);
            this.Controls.Add(this.ContractPriceTotal);
            this.Controls.Add(this.CatererCB);
            this.Controls.Add(this.BusinessCB);
            this.Controls.Add(this.Calbutton);
            this.Controls.Add(this.TitleLb);
            this.Controls.Add(this.ContractPriceLb);
            this.Controls.Add(this.ContractYearLb);
            this.Controls.Add(this.BusinessLb);
            this.Controls.Add(this.CaterLb);
            this.Name = "ContractCal";
            this.Text = "Contract Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CaterLb;
        private System.Windows.Forms.Label BusinessLb;
        private System.Windows.Forms.Label ContractYearLb;
        private System.Windows.Forms.Label ContractPriceLb;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.Button Calbutton;
        private System.Windows.Forms.ComboBox BusinessCB;
        private System.Windows.Forms.ComboBox CatererCB;
        private System.Windows.Forms.Label ContractPriceTotal;
        private System.Windows.Forms.TextBox ContractYearTB;
    }
}

