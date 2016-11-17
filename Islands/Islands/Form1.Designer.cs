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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Map = new System.Windows.Forms.DataGridView();
            this.MinMap = new System.Windows.Forms.DataGridView();
            this.Menu_Un = new System.Windows.Forms.PictureBox();
            this.THEALLSEEINGEYE = new System.Windows.Forms.Button();
            this.SUnit_Image = new System.Windows.Forms.PictureBox();
            this.SUnit_Name = new System.Windows.Forms.Label();
            this.SUnit_Move = new System.Windows.Forms.PictureBox();
            this.SUnit_Attack1 = new System.Windows.Forms.PictureBox();
            this.SUnit_Attack2 = new System.Windows.Forms.PictureBox();
            this.SUnit_Attack3 = new System.Windows.Forms.PictureBox();
            this.SUnit_Move_lbl = new System.Windows.Forms.Label();
            this.SUnit_Attack1_lbl = new System.Windows.Forms.Label();
            this.SUnit_Attack2_lbl = new System.Windows.Forms.Label();
            this.SUnit_Attack3_lbl = new System.Windows.Forms.Label();
            this.SUnit_AttackDmg_img = new System.Windows.Forms.PictureBox();
            this.SUnit_Def_img = new System.Windows.Forms.PictureBox();
            this.SUnit_Crit_img = new System.Windows.Forms.PictureBox();
            this.SUnit_Dodge_img = new System.Windows.Forms.PictureBox();
            this.SUnit_Health = new System.Windows.Forms.ProgressBar();
            this.SUnit_AttackDmg = new System.Windows.Forms.Label();
            this.SUnit_Def = new System.Windows.Forms.Label();
            this.SUnit_Crit = new System.Windows.Forms.Label();
            this.SUnit_Dodge = new System.Windows.Forms.Label();
            this.SUnit_Weapon = new System.Windows.Forms.PictureBox();
            this.SUnit_Armor = new System.Windows.Forms.PictureBox();
            this.SUnit_Soul = new System.Windows.Forms.PictureBox();
            this.SUnit_Weapon_Name = new System.Windows.Forms.Label();
            this.SUnit_Armor_Name = new System.Windows.Forms.Label();
            this.SUnit_Soul_Name = new System.Windows.Forms.Label();
            this.SUnit_AttackDmg_Bonus = new System.Windows.Forms.Label();
            this.SUnit_Def_Bonus = new System.Windows.Forms.Label();
            this.SUnit_Crit_Bonus = new System.Windows.Forms.Label();
            this.SUnit_Dodge_Bonus = new System.Windows.Forms.Label();
            this.SUnit_Level = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_Un)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Attack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Attack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Attack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_AttackDmg_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Def_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Crit_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Dodge_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Armor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Soul)).BeginInit();
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
            this.Map.Location = new System.Drawing.Point(1, -31);
            this.Map.Name = "Map";
            this.Map.ReadOnly = true;
            this.Map.RowHeadersVisible = false;
            this.Map.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Map.ShowEditingIcon = false;
            this.Map.Size = new System.Drawing.Size(1353, 582);
            this.Map.TabIndex = 1;
            this.Map.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Map_CellClick);
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
            // Menu_Un
            // 
            this.Menu_Un.Location = new System.Drawing.Point(1, 547);
            this.Menu_Un.Name = "Menu_Un";
            this.Menu_Un.Size = new System.Drawing.Size(857, 190);
            this.Menu_Un.TabIndex = 0;
            this.Menu_Un.TabStop = false;
            // 
            // THEALLSEEINGEYE
            // 
            this.THEALLSEEINGEYE.Location = new System.Drawing.Point(783, 681);
            this.THEALLSEEINGEYE.Name = "THEALLSEEINGEYE";
            this.THEALLSEEINGEYE.Size = new System.Drawing.Size(75, 56);
            this.THEALLSEEINGEYE.TabIndex = 3;
            this.THEALLSEEINGEYE.Text = "( | )";
            this.THEALLSEEINGEYE.UseVisualStyleBackColor = true;
            this.THEALLSEEINGEYE.Click += new System.EventHandler(this.THEALLSEEINGEYE_Click);
            // 
            // SUnit_Image
            // 
            this.SUnit_Image.Image = global::Islands.Properties.Resources.BIGVOID;
            this.SUnit_Image.Location = new System.Drawing.Point(13, 566);
            this.SUnit_Image.Name = "SUnit_Image";
            this.SUnit_Image.Size = new System.Drawing.Size(170, 155);
            this.SUnit_Image.TabIndex = 4;
            this.SUnit_Image.TabStop = false;
            // 
            // SUnit_Name
            // 
            this.SUnit_Name.AutoSize = true;
            this.SUnit_Name.Location = new System.Drawing.Point(12, 550);
            this.SUnit_Name.Name = "SUnit_Name";
            this.SUnit_Name.Size = new System.Drawing.Size(35, 13);
            this.SUnit_Name.TabIndex = 5;
            this.SUnit_Name.Text = "label1";
            // 
            // SUnit_Move
            // 
            this.SUnit_Move.Image = global::Islands.Properties.Resources.BIGVOID;
            this.SUnit_Move.Location = new System.Drawing.Point(211, 586);
            this.SUnit_Move.Name = "SUnit_Move";
            this.SUnit_Move.Size = new System.Drawing.Size(86, 73);
            this.SUnit_Move.TabIndex = 6;
            this.SUnit_Move.TabStop = false;
            // 
            // SUnit_Attack1
            // 
            this.SUnit_Attack1.Image = global::Islands.Properties.Resources.BIGVOID;
            this.SUnit_Attack1.Location = new System.Drawing.Point(316, 586);
            this.SUnit_Attack1.Name = "SUnit_Attack1";
            this.SUnit_Attack1.Size = new System.Drawing.Size(86, 73);
            this.SUnit_Attack1.TabIndex = 7;
            this.SUnit_Attack1.TabStop = false;
            // 
            // SUnit_Attack2
            // 
            this.SUnit_Attack2.Image = global::Islands.Properties.Resources.BIGVOID;
            this.SUnit_Attack2.Location = new System.Drawing.Point(425, 586);
            this.SUnit_Attack2.Name = "SUnit_Attack2";
            this.SUnit_Attack2.Size = new System.Drawing.Size(86, 73);
            this.SUnit_Attack2.TabIndex = 8;
            this.SUnit_Attack2.TabStop = false;
            // 
            // SUnit_Attack3
            // 
            this.SUnit_Attack3.Image = global::Islands.Properties.Resources.BIGVOID;
            this.SUnit_Attack3.Location = new System.Drawing.Point(535, 586);
            this.SUnit_Attack3.Name = "SUnit_Attack3";
            this.SUnit_Attack3.Size = new System.Drawing.Size(86, 73);
            this.SUnit_Attack3.TabIndex = 9;
            this.SUnit_Attack3.TabStop = false;
            // 
            // SUnit_Move_lbl
            // 
            this.SUnit_Move_lbl.AutoSize = true;
            this.SUnit_Move_lbl.Location = new System.Drawing.Point(235, 671);
            this.SUnit_Move_lbl.Name = "SUnit_Move_lbl";
            this.SUnit_Move_lbl.Size = new System.Drawing.Size(35, 13);
            this.SUnit_Move_lbl.TabIndex = 10;
            this.SUnit_Move_lbl.Text = "label2";
            // 
            // SUnit_Attack1_lbl
            // 
            this.SUnit_Attack1_lbl.AutoSize = true;
            this.SUnit_Attack1_lbl.Location = new System.Drawing.Point(343, 671);
            this.SUnit_Attack1_lbl.Name = "SUnit_Attack1_lbl";
            this.SUnit_Attack1_lbl.Size = new System.Drawing.Size(35, 13);
            this.SUnit_Attack1_lbl.TabIndex = 11;
            this.SUnit_Attack1_lbl.Text = "label2";
            // 
            // SUnit_Attack2_lbl
            // 
            this.SUnit_Attack2_lbl.AutoSize = true;
            this.SUnit_Attack2_lbl.Location = new System.Drawing.Point(449, 671);
            this.SUnit_Attack2_lbl.Name = "SUnit_Attack2_lbl";
            this.SUnit_Attack2_lbl.Size = new System.Drawing.Size(35, 13);
            this.SUnit_Attack2_lbl.TabIndex = 12;
            this.SUnit_Attack2_lbl.Text = "label3";
            // 
            // SUnit_Attack3_lbl
            // 
            this.SUnit_Attack3_lbl.AutoSize = true;
            this.SUnit_Attack3_lbl.Location = new System.Drawing.Point(564, 671);
            this.SUnit_Attack3_lbl.Name = "SUnit_Attack3_lbl";
            this.SUnit_Attack3_lbl.Size = new System.Drawing.Size(35, 13);
            this.SUnit_Attack3_lbl.TabIndex = 13;
            this.SUnit_Attack3_lbl.Text = "label4";
            // 
            // SUnit_AttackDmg_img
            // 
            this.SUnit_AttackDmg_img.Image = global::Islands.Properties.Resources.VOID;
            this.SUnit_AttackDmg_img.Location = new System.Drawing.Point(211, 699);
            this.SUnit_AttackDmg_img.Name = "SUnit_AttackDmg_img";
            this.SUnit_AttackDmg_img.Size = new System.Drawing.Size(26, 22);
            this.SUnit_AttackDmg_img.TabIndex = 18;
            this.SUnit_AttackDmg_img.TabStop = false;
            // 
            // SUnit_Def_img
            // 
            this.SUnit_Def_img.Image = global::Islands.Properties.Resources.VOID;
            this.SUnit_Def_img.Location = new System.Drawing.Point(316, 699);
            this.SUnit_Def_img.Name = "SUnit_Def_img";
            this.SUnit_Def_img.Size = new System.Drawing.Size(26, 22);
            this.SUnit_Def_img.TabIndex = 19;
            this.SUnit_Def_img.TabStop = false;
            // 
            // SUnit_Crit_img
            // 
            this.SUnit_Crit_img.Image = global::Islands.Properties.Resources.VOID;
            this.SUnit_Crit_img.Location = new System.Drawing.Point(425, 699);
            this.SUnit_Crit_img.Name = "SUnit_Crit_img";
            this.SUnit_Crit_img.Size = new System.Drawing.Size(26, 22);
            this.SUnit_Crit_img.TabIndex = 20;
            this.SUnit_Crit_img.TabStop = false;
            // 
            // SUnit_Dodge_img
            // 
            this.SUnit_Dodge_img.Image = global::Islands.Properties.Resources.VOID;
            this.SUnit_Dodge_img.Location = new System.Drawing.Point(535, 699);
            this.SUnit_Dodge_img.Name = "SUnit_Dodge_img";
            this.SUnit_Dodge_img.Size = new System.Drawing.Size(26, 22);
            this.SUnit_Dodge_img.TabIndex = 21;
            this.SUnit_Dodge_img.TabStop = false;
            // 
            // SUnit_Health
            // 
            this.SUnit_Health.Location = new System.Drawing.Point(211, 557);
            this.SUnit_Health.Name = "SUnit_Health";
            this.SUnit_Health.Size = new System.Drawing.Size(410, 23);
            this.SUnit_Health.TabIndex = 22;
            // 
            // SUnit_AttackDmg
            // 
            this.SUnit_AttackDmg.AutoSize = true;
            this.SUnit_AttackDmg.Location = new System.Drawing.Point(243, 703);
            this.SUnit_AttackDmg.Name = "SUnit_AttackDmg";
            this.SUnit_AttackDmg.Size = new System.Drawing.Size(35, 13);
            this.SUnit_AttackDmg.TabIndex = 23;
            this.SUnit_AttackDmg.Text = "label5";
            // 
            // SUnit_Def
            // 
            this.SUnit_Def.AutoSize = true;
            this.SUnit_Def.Location = new System.Drawing.Point(348, 703);
            this.SUnit_Def.Name = "SUnit_Def";
            this.SUnit_Def.Size = new System.Drawing.Size(35, 13);
            this.SUnit_Def.TabIndex = 24;
            this.SUnit_Def.Text = "label6";
            // 
            // SUnit_Crit
            // 
            this.SUnit_Crit.AutoSize = true;
            this.SUnit_Crit.Location = new System.Drawing.Point(457, 703);
            this.SUnit_Crit.Name = "SUnit_Crit";
            this.SUnit_Crit.Size = new System.Drawing.Size(35, 13);
            this.SUnit_Crit.TabIndex = 25;
            this.SUnit_Crit.Text = "label7";
            // 
            // SUnit_Dodge
            // 
            this.SUnit_Dodge.AutoSize = true;
            this.SUnit_Dodge.Location = new System.Drawing.Point(567, 703);
            this.SUnit_Dodge.Name = "SUnit_Dodge";
            this.SUnit_Dodge.Size = new System.Drawing.Size(35, 13);
            this.SUnit_Dodge.TabIndex = 26;
            this.SUnit_Dodge.Text = "label8";
            // 
            // SUnit_Weapon
            // 
            this.SUnit_Weapon.Image = global::Islands.Properties.Resources.VOID;
            this.SUnit_Weapon.Location = new System.Drawing.Point(650, 566);
            this.SUnit_Weapon.Name = "SUnit_Weapon";
            this.SUnit_Weapon.Size = new System.Drawing.Size(16, 16);
            this.SUnit_Weapon.TabIndex = 27;
            this.SUnit_Weapon.TabStop = false;
            // 
            // SUnit_Armor
            // 
            this.SUnit_Armor.Image = global::Islands.Properties.Resources.VOID;
            this.SUnit_Armor.Location = new System.Drawing.Point(650, 603);
            this.SUnit_Armor.Name = "SUnit_Armor";
            this.SUnit_Armor.Size = new System.Drawing.Size(16, 16);
            this.SUnit_Armor.TabIndex = 28;
            this.SUnit_Armor.TabStop = false;
            // 
            // SUnit_Soul
            // 
            this.SUnit_Soul.Image = global::Islands.Properties.Resources.VOID;
            this.SUnit_Soul.Location = new System.Drawing.Point(650, 643);
            this.SUnit_Soul.Name = "SUnit_Soul";
            this.SUnit_Soul.Size = new System.Drawing.Size(16, 16);
            this.SUnit_Soul.TabIndex = 29;
            this.SUnit_Soul.TabStop = false;
            // 
            // SUnit_Weapon_Name
            // 
            this.SUnit_Weapon_Name.AutoSize = true;
            this.SUnit_Weapon_Name.Location = new System.Drawing.Point(673, 566);
            this.SUnit_Weapon_Name.Name = "SUnit_Weapon_Name";
            this.SUnit_Weapon_Name.Size = new System.Drawing.Size(35, 13);
            this.SUnit_Weapon_Name.TabIndex = 30;
            this.SUnit_Weapon_Name.Text = "label9";
            // 
            // SUnit_Armor_Name
            // 
            this.SUnit_Armor_Name.AutoSize = true;
            this.SUnit_Armor_Name.Location = new System.Drawing.Point(673, 606);
            this.SUnit_Armor_Name.Name = "SUnit_Armor_Name";
            this.SUnit_Armor_Name.Size = new System.Drawing.Size(41, 13);
            this.SUnit_Armor_Name.TabIndex = 31;
            this.SUnit_Armor_Name.Text = "label10";
            // 
            // SUnit_Soul_Name
            // 
            this.SUnit_Soul_Name.AutoSize = true;
            this.SUnit_Soul_Name.Location = new System.Drawing.Point(673, 643);
            this.SUnit_Soul_Name.Name = "SUnit_Soul_Name";
            this.SUnit_Soul_Name.Size = new System.Drawing.Size(41, 13);
            this.SUnit_Soul_Name.TabIndex = 32;
            this.SUnit_Soul_Name.Text = "label11";
            // 
            // SUnit_AttackDmg_Bonus
            // 
            this.SUnit_AttackDmg_Bonus.AutoSize = true;
            this.SUnit_AttackDmg_Bonus.Location = new System.Drawing.Point(243, 716);
            this.SUnit_AttackDmg_Bonus.Name = "SUnit_AttackDmg_Bonus";
            this.SUnit_AttackDmg_Bonus.Size = new System.Drawing.Size(41, 13);
            this.SUnit_AttackDmg_Bonus.TabIndex = 33;
            this.SUnit_AttackDmg_Bonus.Text = "label12";
            // 
            // SUnit_Def_Bonus
            // 
            this.SUnit_Def_Bonus.AutoSize = true;
            this.SUnit_Def_Bonus.Location = new System.Drawing.Point(348, 716);
            this.SUnit_Def_Bonus.Name = "SUnit_Def_Bonus";
            this.SUnit_Def_Bonus.Size = new System.Drawing.Size(41, 13);
            this.SUnit_Def_Bonus.TabIndex = 34;
            this.SUnit_Def_Bonus.Text = "label13";
            // 
            // SUnit_Crit_Bonus
            // 
            this.SUnit_Crit_Bonus.AutoSize = true;
            this.SUnit_Crit_Bonus.Location = new System.Drawing.Point(457, 716);
            this.SUnit_Crit_Bonus.Name = "SUnit_Crit_Bonus";
            this.SUnit_Crit_Bonus.Size = new System.Drawing.Size(41, 13);
            this.SUnit_Crit_Bonus.TabIndex = 35;
            this.SUnit_Crit_Bonus.Text = "label14";
            // 
            // SUnit_Dodge_Bonus
            // 
            this.SUnit_Dodge_Bonus.AutoSize = true;
            this.SUnit_Dodge_Bonus.Location = new System.Drawing.Point(567, 716);
            this.SUnit_Dodge_Bonus.Name = "SUnit_Dodge_Bonus";
            this.SUnit_Dodge_Bonus.Size = new System.Drawing.Size(41, 13);
            this.SUnit_Dodge_Bonus.TabIndex = 36;
            this.SUnit_Dodge_Bonus.Text = "label15";
            // 
            // SUnit_Level
            // 
            this.SUnit_Level.AutoSize = true;
            this.SUnit_Level.Location = new System.Drawing.Point(148, 550);
            this.SUnit_Level.Name = "SUnit_Level";
            this.SUnit_Level.Size = new System.Drawing.Size(35, 13);
            this.SUnit_Level.TabIndex = 37;
            this.SUnit_Level.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.SUnit_Level);
            this.Controls.Add(this.SUnit_Dodge_Bonus);
            this.Controls.Add(this.SUnit_Crit_Bonus);
            this.Controls.Add(this.SUnit_Def_Bonus);
            this.Controls.Add(this.SUnit_AttackDmg_Bonus);
            this.Controls.Add(this.SUnit_Soul_Name);
            this.Controls.Add(this.SUnit_Armor_Name);
            this.Controls.Add(this.SUnit_Weapon_Name);
            this.Controls.Add(this.SUnit_Soul);
            this.Controls.Add(this.SUnit_Armor);
            this.Controls.Add(this.SUnit_Weapon);
            this.Controls.Add(this.SUnit_Dodge);
            this.Controls.Add(this.SUnit_Crit);
            this.Controls.Add(this.SUnit_Def);
            this.Controls.Add(this.SUnit_AttackDmg);
            this.Controls.Add(this.SUnit_Health);
            this.Controls.Add(this.SUnit_Dodge_img);
            this.Controls.Add(this.SUnit_Crit_img);
            this.Controls.Add(this.SUnit_Def_img);
            this.Controls.Add(this.SUnit_AttackDmg_img);
            this.Controls.Add(this.SUnit_Attack3_lbl);
            this.Controls.Add(this.SUnit_Attack2_lbl);
            this.Controls.Add(this.SUnit_Attack1_lbl);
            this.Controls.Add(this.SUnit_Move_lbl);
            this.Controls.Add(this.SUnit_Attack3);
            this.Controls.Add(this.SUnit_Attack2);
            this.Controls.Add(this.SUnit_Attack1);
            this.Controls.Add(this.SUnit_Move);
            this.Controls.Add(this.SUnit_Name);
            this.Controls.Add(this.SUnit_Image);
            this.Controls.Add(this.THEALLSEEINGEYE);
            this.Controls.Add(this.Menu_Un);
            this.Controls.Add(this.MinMap);
            this.Controls.Add(this.Map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MAP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_Un)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Attack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Attack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Attack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_AttackDmg_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Def_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Crit_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Dodge_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Weapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Armor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUnit_Soul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView Map;
        private System.Windows.Forms.DataGridView MinMap;
        private System.Windows.Forms.PictureBox Menu_Un;
        private System.Windows.Forms.Button THEALLSEEINGEYE;
        private System.Windows.Forms.PictureBox SUnit_Image;
        private System.Windows.Forms.Label SUnit_Name;
        private System.Windows.Forms.PictureBox SUnit_Move;
        private System.Windows.Forms.PictureBox SUnit_Attack1;
        private System.Windows.Forms.PictureBox SUnit_Attack2;
        private System.Windows.Forms.PictureBox SUnit_Attack3;
        private System.Windows.Forms.Label SUnit_Move_lbl;
        private System.Windows.Forms.Label SUnit_Attack1_lbl;
        private System.Windows.Forms.Label SUnit_Attack2_lbl;
        private System.Windows.Forms.Label SUnit_Attack3_lbl;
        private System.Windows.Forms.PictureBox SUnit_AttackDmg_img;
        private System.Windows.Forms.PictureBox SUnit_Def_img;
        private System.Windows.Forms.PictureBox SUnit_Crit_img;
        private System.Windows.Forms.PictureBox SUnit_Dodge_img;
        private System.Windows.Forms.ProgressBar SUnit_Health;
        private System.Windows.Forms.Label SUnit_AttackDmg;
        private System.Windows.Forms.Label SUnit_Def;
        private System.Windows.Forms.Label SUnit_Crit;
        private System.Windows.Forms.Label SUnit_Dodge;
        private System.Windows.Forms.PictureBox SUnit_Weapon;
        private System.Windows.Forms.PictureBox SUnit_Armor;
        private System.Windows.Forms.PictureBox SUnit_Soul;
        private System.Windows.Forms.Label SUnit_Weapon_Name;
        private System.Windows.Forms.Label SUnit_Armor_Name;
        private System.Windows.Forms.Label SUnit_Soul_Name;
        private System.Windows.Forms.Label SUnit_AttackDmg_Bonus;
        private System.Windows.Forms.Label SUnit_Def_Bonus;
        private System.Windows.Forms.Label SUnit_Crit_Bonus;
        private System.Windows.Forms.Label SUnit_Dodge_Bonus;
        private System.Windows.Forms.Label SUnit_Level;

    }
}

