namespace Islands
{
    partial class NewUnit
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
            this.Units = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Units)).BeginInit();
            this.SuspendLayout();
            // 
            // Units
            // 
            this.Units.AllowUserToAddRows = false;
            this.Units.AllowUserToDeleteRows = false;
            this.Units.AllowUserToResizeColumns = false;
            this.Units.AllowUserToResizeRows = false;
            this.Units.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Units.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Units.Location = new System.Drawing.Point(0, 0);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(761, 453);
            this.Units.TabIndex = 0;
            this.Units.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Units_CellContentClick);
            // 
            // NewUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 453);
            this.Controls.Add(this.Units);
            this.Name = "NewUnit";
            this.Text = "NewUnit";
            this.Load += new System.EventHandler(this.NewUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Units)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Units;
    }
}