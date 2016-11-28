namespace Islands
{
    partial class BuyUnit
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
            this.Unit_PB = new System.Windows.Forms.PictureBox();
            this.Unit_Name = new System.Windows.Forms.Label();
            this.BuyUnit_Btn = new System.Windows.Forms.Button();
            this.Cost_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Unit_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Unit_PB
            // 
            this.Unit_PB.Location = new System.Drawing.Point(47, 47);
            this.Unit_PB.Name = "Unit_PB";
            this.Unit_PB.Size = new System.Drawing.Size(178, 108);
            this.Unit_PB.TabIndex = 0;
            this.Unit_PB.TabStop = false;
            // 
            // Unit_Name
            // 
            this.Unit_Name.AutoSize = true;
            this.Unit_Name.Location = new System.Drawing.Point(44, 21);
            this.Unit_Name.Name = "Unit_Name";
            this.Unit_Name.Size = new System.Drawing.Size(134, 13);
            this.Unit_Name.TabIndex = 1;
            this.Unit_Name.Text = "THE NAME OF THE UNIT";
            // 
            // BuyUnit_Btn
            // 
            this.BuyUnit_Btn.Location = new System.Drawing.Point(47, 321);
            this.BuyUnit_Btn.Name = "BuyUnit_Btn";
            this.BuyUnit_Btn.Size = new System.Drawing.Size(178, 51);
            this.BuyUnit_Btn.TabIndex = 2;
            this.BuyUnit_Btn.Text = "Purchase";
            this.BuyUnit_Btn.UseVisualStyleBackColor = true;
            // 
            // Cost_lbl
            // 
            this.Cost_lbl.AutoSize = true;
            this.Cost_lbl.Location = new System.Drawing.Point(116, 305);
            this.Cost_lbl.Name = "Cost_lbl";
            this.Cost_lbl.Size = new System.Drawing.Size(19, 13);
            this.Cost_lbl.TabIndex = 3;
            this.Cost_lbl.Text = "10";
            // 
            // BuyUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 384);
            this.Controls.Add(this.Cost_lbl);
            this.Controls.Add(this.BuyUnit_Btn);
            this.Controls.Add(this.Unit_Name);
            this.Controls.Add(this.Unit_PB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BuyUnit";
            this.Text = "BuyUnit";
            ((System.ComponentModel.ISupportInitialize)(this.Unit_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Unit_PB;
        private System.Windows.Forms.Label Unit_Name;
        private System.Windows.Forms.Button BuyUnit_Btn;
        private System.Windows.Forms.Label Cost_lbl;
    }
}