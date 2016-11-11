namespace Islands
{
    partial class Form1
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
            this.Map = new System.Windows.Forms.DataGridView();
            this.MinMap = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinMap)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.AllowUserToAddRows = false;
            this.Map.AllowUserToDeleteRows = false;
            this.Map.AllowUserToResizeColumns = false;
            this.Map.AllowUserToResizeRows = false;
            this.Map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Map.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Map.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Map.ColumnHeadersVisible = false;
            this.Map.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Map.GridColor = System.Drawing.Color.White;
            this.Map.Location = new System.Drawing.Point(1, 0);
            this.Map.Name = "Map";
            this.Map.ReadOnly = true;
            this.Map.RowHeadersVisible = false;
            this.Map.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Map.ShowEditingIcon = false;
            this.Map.Size = new System.Drawing.Size(1353, 737);
            this.Map.TabIndex = 1;
            // 
            // MinMap
            // 
            this.MinMap.AllowUserToAddRows = false;
            this.MinMap.AllowUserToDeleteRows = false;
            this.MinMap.AllowUserToResizeColumns = false;
            this.MinMap.AllowUserToResizeRows = false;
            this.MinMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MinMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MinMap.Location = new System.Drawing.Point(856, 447);
            this.MinMap.Name = "MinMap";
            this.MinMap.ReadOnly = true;
            this.MinMap.Size = new System.Drawing.Size(498, 290);
            this.MinMap.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Moar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MinMap);
            this.Controls.Add(this.Map);
            this.Name = "Form1";
            this.Text = "MAP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView Map;
        private System.Windows.Forms.DataGridView MinMap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;

    }
}

