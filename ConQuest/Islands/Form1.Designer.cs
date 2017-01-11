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
            Map = new System.Windows.Forms.DataGridView();
            InUse_lbl = new System.Windows.Forms.DataGridView();
            Menu_Un = new System.Windows.Forms.PictureBox();
            THEALLSEEINGEYE = new System.Windows.Forms.Button();
            SUnit_Image = new System.Windows.Forms.PictureBox();
            SUnit_Name = new System.Windows.Forms.Label();
            SUnit_Move = new System.Windows.Forms.PictureBox();
            SUnit_Attack1 = new System.Windows.Forms.PictureBox();
            SUnit_Attack2 = new System.Windows.Forms.PictureBox();
            SUnit_Attack3 = new System.Windows.Forms.PictureBox();
            SUnit_Move_lbl = new System.Windows.Forms.Label();
            SUnit_Attack1_lbl = new System.Windows.Forms.Label();
            SUnit_Attack2_lbl = new System.Windows.Forms.Label();
            SUnit_Attack3_lbl = new System.Windows.Forms.Label();
            SUnit_AttackDmg_img = new System.Windows.Forms.PictureBox();
            SUnit_Def_img = new System.Windows.Forms.PictureBox();
            SUnit_Crit_img = new System.Windows.Forms.PictureBox();
            SUnit_Dodge_img = new System.Windows.Forms.PictureBox();
            SUnit_Health = new System.Windows.Forms.ProgressBar();
            SUnit_AttackDmg = new System.Windows.Forms.Label();
            SUnit_Def = new System.Windows.Forms.Label();
            SUnit_Crit = new System.Windows.Forms.Label();
            SUnit_Dodge = new System.Windows.Forms.Label();
            SUnit_Weapon = new System.Windows.Forms.PictureBox();
            SUnit_Armor = new System.Windows.Forms.PictureBox();
            SUnit_Soul = new System.Windows.Forms.PictureBox();
            SUnit_Weapon_Name = new System.Windows.Forms.Label();
            SUnit_Armor_Name = new System.Windows.Forms.Label();
            SUnit_Soul_Name = new System.Windows.Forms.Label();
            SUnit_AttackDmg_Bonus = new System.Windows.Forms.Label();
            SUnit_Def_Bonus = new System.Windows.Forms.Label();
            SUnit_Crit_Bonus = new System.Windows.Forms.Label();
            SUnit_Dodge_Bonus = new System.Windows.Forms.Label();
            SUnit_Level = new System.Windows.Forms.Label();
            SUnit_Class = new System.Windows.Forms.Label();
            TopMenu = new System.Windows.Forms.PictureBox();
            Gold_Img = new System.Windows.Forms.PictureBox();
            Gold_lbl = new System.Windows.Forms.Label();
            Movesleft_img = new System.Windows.Forms.PictureBox();
            Movesleft = new System.Windows.Forms.Label();
            SUnit_aff = new System.Windows.Forms.Label();
            Influence_img = new System.Windows.Forms.PictureBox();
            SUnit_Inf = new System.Windows.Forms.Label();
            NextTurn = new System.Windows.Forms.Button();
            Debug = new System.Windows.Forms.Label();
            SUnit_MovesLeft = new System.Windows.Forms.Label();
            Production_img = new System.Windows.Forms.PictureBox();
            production = new System.Windows.Forms.Label();
            Shop_btn = new System.Windows.Forms.Button();
            Armory_Btn = new System.Windows.Forms.Button();
            InUse = new System.Windows.Forms.Label();
            MessageBox_LB = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(InUse_lbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Menu_Un)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Attack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Attack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Attack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_AttackDmg_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Def_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Crit_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Dodge_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Armor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Soul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(TopMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Gold_Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Movesleft_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Influence_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Production_img)).BeginInit();
            SuspendLayout();
            // 
            // Map
            // 
            Map.AllowUserToAddRows = false;
            Map.AllowUserToDeleteRows = false;
            Map.AllowUserToResizeColumns = false;
            Map.AllowUserToResizeRows = false;
            Map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            Map.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            Map.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Map.ColumnHeadersVisible = false;
            Map.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            Map.GridColor = System.Drawing.Color.White;
            Map.Location = new System.Drawing.Point(1, -31);
            Map.Name = "Map";
            Map.ReadOnly = true;
            Map.RowHeadersVisible = false;
            Map.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            Map.ShowEditingIcon = false;
            Map.Size = new System.Drawing.Size(1271, 578);
            Map.TabIndex = 1;
            Map.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(Map_CellClick);
            Map.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(Map_CellContentClick);
            Map.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(Map_CellMouseEnter);
            // 
            // InUse_lbl
            // 
            InUse_lbl.AllowUserToAddRows = false;
            InUse_lbl.AllowUserToDeleteRows = false;
            InUse_lbl.AllowUserToResizeColumns = false;
            InUse_lbl.AllowUserToResizeRows = false;
            InUse_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            InUse_lbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InUse_lbl.Location = new System.Drawing.Point(774, 443);
            InUse_lbl.Name = "InUse_lbl";
            InUse_lbl.ReadOnly = true;
            InUse_lbl.Size = new System.Drawing.Size(498, 290);
            InUse_lbl.TabIndex = 2;
            // 
            // Menu_Un
            // 
            Menu_Un.Location = new System.Drawing.Point(1, 547);
            Menu_Un.Name = "Menu_Un";
            Menu_Un.Size = new System.Drawing.Size(857, 190);
            Menu_Un.TabIndex = 0;
            Menu_Un.TabStop = false;
            // 
            // THEALLSEEINGEYE
            // 
            THEALLSEEINGEYE.Location = new System.Drawing.Point(783, 681);
            THEALLSEEINGEYE.Name = "THEALLSEEINGEYE";
            THEALLSEEINGEYE.Size = new System.Drawing.Size(75, 56);
            THEALLSEEINGEYE.TabIndex = 3;
            THEALLSEEINGEYE.Text = "( | )";
            THEALLSEEINGEYE.UseVisualStyleBackColor = true;
            THEALLSEEINGEYE.Click += new System.EventHandler(THEALLSEEINGEYE_Click);
            // 
            // SUnit_Image
            // 
            SUnit_Image.Image = global::Islands.Properties.Resources.BIGVOID;
            SUnit_Image.Location = new System.Drawing.Point(13, 566);
            SUnit_Image.Name = "SUnit_Image";
            SUnit_Image.Size = new System.Drawing.Size(170, 155);
            SUnit_Image.TabIndex = 4;
            SUnit_Image.TabStop = false;
            // 
            // SUnit_Name
            // 
            SUnit_Name.AutoSize = true;
            SUnit_Name.Location = new System.Drawing.Point(12, 550);
            SUnit_Name.Name = "SUnit_Name";
            SUnit_Name.Size = new System.Drawing.Size(35, 13);
            SUnit_Name.TabIndex = 5;
            SUnit_Name.Text = "label1";
            // 
            // SUnit_Move
            // 
            SUnit_Move.Image = global::Islands.Properties.Resources.BIGVOID;
            SUnit_Move.Location = new System.Drawing.Point(211, 586);
            SUnit_Move.Name = "SUnit_Move";
            SUnit_Move.Size = new System.Drawing.Size(86, 73);
            SUnit_Move.TabIndex = 6;
            SUnit_Move.TabStop = false;
            SUnit_Move.Click += new System.EventHandler(SUnit_Move_Click);
            // 
            // SUnit_Attack1
            // 
            SUnit_Attack1.Image = global::Islands.Properties.Resources.BIGVOID;
            SUnit_Attack1.Location = new System.Drawing.Point(316, 586);
            SUnit_Attack1.Name = "SUnit_Attack1";
            SUnit_Attack1.Size = new System.Drawing.Size(86, 73);
            SUnit_Attack1.TabIndex = 7;
            SUnit_Attack1.TabStop = false;
            SUnit_Attack1.Click += new System.EventHandler(SUnit_Attack1_Click);
            // 
            // SUnit_Attack2
            // 
            SUnit_Attack2.Image = global::Islands.Properties.Resources.BIGVOID;
            SUnit_Attack2.Location = new System.Drawing.Point(425, 586);
            SUnit_Attack2.Name = "SUnit_Attack2";
            SUnit_Attack2.Size = new System.Drawing.Size(86, 73);
            SUnit_Attack2.TabIndex = 8;
            SUnit_Attack2.TabStop = false;
            // 
            // SUnit_Attack3
            // 
            SUnit_Attack3.Image = global::Islands.Properties.Resources.BIGVOID;
            SUnit_Attack3.Location = new System.Drawing.Point(535, 586);
            SUnit_Attack3.Name = "SUnit_Attack3";
            SUnit_Attack3.Size = new System.Drawing.Size(86, 73);
            SUnit_Attack3.TabIndex = 9;
            SUnit_Attack3.TabStop = false;
            // 
            // SUnit_Move_lbl
            // 
            SUnit_Move_lbl.AutoSize = true;
            SUnit_Move_lbl.Location = new System.Drawing.Point(235, 671);
            SUnit_Move_lbl.Name = "SUnit_Move_lbl";
            SUnit_Move_lbl.Size = new System.Drawing.Size(34, 13);
            SUnit_Move_lbl.TabIndex = 10;
            SUnit_Move_lbl.Text = "Move";
            // 
            // SUnit_Attack1_lbl
            // 
            SUnit_Attack1_lbl.AutoSize = true;
            SUnit_Attack1_lbl.Location = new System.Drawing.Point(343, 671);
            SUnit_Attack1_lbl.Name = "SUnit_Attack1_lbl";
            SUnit_Attack1_lbl.Size = new System.Drawing.Size(35, 13);
            SUnit_Attack1_lbl.TabIndex = 11;
            SUnit_Attack1_lbl.Text = "label2";
            // 
            // SUnit_Attack2_lbl
            // 
            SUnit_Attack2_lbl.AutoSize = true;
            SUnit_Attack2_lbl.Location = new System.Drawing.Point(449, 671);
            SUnit_Attack2_lbl.Name = "SUnit_Attack2_lbl";
            SUnit_Attack2_lbl.Size = new System.Drawing.Size(35, 13);
            SUnit_Attack2_lbl.TabIndex = 12;
            SUnit_Attack2_lbl.Text = "label3";
            // 
            // SUnit_Attack3_lbl
            // 
            SUnit_Attack3_lbl.AutoSize = true;
            SUnit_Attack3_lbl.Location = new System.Drawing.Point(564, 671);
            SUnit_Attack3_lbl.Name = "SUnit_Attack3_lbl";
            SUnit_Attack3_lbl.Size = new System.Drawing.Size(35, 13);
            SUnit_Attack3_lbl.TabIndex = 13;
            SUnit_Attack3_lbl.Text = "label4";
            // 
            // SUnit_AttackDmg_img
            // 
            SUnit_AttackDmg_img.Image = global::Islands.Properties.Resources.VOID;
            SUnit_AttackDmg_img.Location = new System.Drawing.Point(211, 699);
            SUnit_AttackDmg_img.Name = "SUnit_AttackDmg_img";
            SUnit_AttackDmg_img.Size = new System.Drawing.Size(26, 22);
            SUnit_AttackDmg_img.TabIndex = 18;
            SUnit_AttackDmg_img.TabStop = false;
            // 
            // SUnit_Def_img
            // 
            SUnit_Def_img.Image = global::Islands.Properties.Resources.VOID;
            SUnit_Def_img.Location = new System.Drawing.Point(316, 699);
            SUnit_Def_img.Name = "SUnit_Def_img";
            SUnit_Def_img.Size = new System.Drawing.Size(26, 22);
            SUnit_Def_img.TabIndex = 19;
            SUnit_Def_img.TabStop = false;
            // 
            // SUnit_Crit_img
            // 
            SUnit_Crit_img.Image = global::Islands.Properties.Resources.VOID;
            SUnit_Crit_img.Location = new System.Drawing.Point(425, 699);
            SUnit_Crit_img.Name = "SUnit_Crit_img";
            SUnit_Crit_img.Size = new System.Drawing.Size(26, 22);
            SUnit_Crit_img.TabIndex = 20;
            SUnit_Crit_img.TabStop = false;
            // 
            // SUnit_Dodge_img
            // 
            SUnit_Dodge_img.Image = global::Islands.Properties.Resources.VOID;
            SUnit_Dodge_img.Location = new System.Drawing.Point(535, 699);
            SUnit_Dodge_img.Name = "SUnit_Dodge_img";
            SUnit_Dodge_img.Size = new System.Drawing.Size(26, 22);
            SUnit_Dodge_img.TabIndex = 21;
            SUnit_Dodge_img.TabStop = false;
            // 
            // SUnit_Health
            // 
            SUnit_Health.Location = new System.Drawing.Point(211, 557);
            SUnit_Health.Name = "SUnit_Health";
            SUnit_Health.Size = new System.Drawing.Size(410, 23);
            SUnit_Health.TabIndex = 22;
            // 
            // SUnit_AttackDmg
            // 
            SUnit_AttackDmg.AutoSize = true;
            SUnit_AttackDmg.Location = new System.Drawing.Point(243, 703);
            SUnit_AttackDmg.Name = "SUnit_AttackDmg";
            SUnit_AttackDmg.Size = new System.Drawing.Size(35, 13);
            SUnit_AttackDmg.TabIndex = 23;
            SUnit_AttackDmg.Text = "label5";
            // 
            // SUnit_Def
            // 
            SUnit_Def.AutoSize = true;
            SUnit_Def.Location = new System.Drawing.Point(348, 703);
            SUnit_Def.Name = "SUnit_Def";
            SUnit_Def.Size = new System.Drawing.Size(35, 13);
            SUnit_Def.TabIndex = 24;
            SUnit_Def.Text = "label6";
            // 
            // SUnit_Crit
            // 
            SUnit_Crit.AutoSize = true;
            SUnit_Crit.Location = new System.Drawing.Point(457, 703);
            SUnit_Crit.Name = "SUnit_Crit";
            SUnit_Crit.Size = new System.Drawing.Size(35, 13);
            SUnit_Crit.TabIndex = 25;
            SUnit_Crit.Text = "label7";
            // 
            // SUnit_Dodge
            // 
            SUnit_Dodge.AutoSize = true;
            SUnit_Dodge.Location = new System.Drawing.Point(567, 703);
            SUnit_Dodge.Name = "SUnit_Dodge";
            SUnit_Dodge.Size = new System.Drawing.Size(35, 13);
            SUnit_Dodge.TabIndex = 26;
            SUnit_Dodge.Text = "label8";
            // 
            // SUnit_Weapon
            // 
            SUnit_Weapon.Image = global::Islands.Properties.Resources.VOID;
            SUnit_Weapon.Location = new System.Drawing.Point(650, 566);
            SUnit_Weapon.Name = "SUnit_Weapon";
            SUnit_Weapon.Size = new System.Drawing.Size(16, 16);
            SUnit_Weapon.TabIndex = 27;
            SUnit_Weapon.TabStop = false;
            // 
            // SUnit_Armor
            // 
            SUnit_Armor.Image = global::Islands.Properties.Resources.VOID;
            SUnit_Armor.Location = new System.Drawing.Point(650, 603);
            SUnit_Armor.Name = "SUnit_Armor";
            SUnit_Armor.Size = new System.Drawing.Size(16, 16);
            SUnit_Armor.TabIndex = 28;
            SUnit_Armor.TabStop = false;
            // 
            // SUnit_Soul
            // 
            SUnit_Soul.Image = global::Islands.Properties.Resources.VOID;
            SUnit_Soul.Location = new System.Drawing.Point(650, 643);
            SUnit_Soul.Name = "SUnit_Soul";
            SUnit_Soul.Size = new System.Drawing.Size(16, 16);
            SUnit_Soul.TabIndex = 29;
            SUnit_Soul.TabStop = false;
            // 
            // SUnit_Weapon_Name
            // 
            SUnit_Weapon_Name.AutoSize = true;
            SUnit_Weapon_Name.Location = new System.Drawing.Point(673, 566);
            SUnit_Weapon_Name.Name = "SUnit_Weapon_Name";
            SUnit_Weapon_Name.Size = new System.Drawing.Size(35, 13);
            SUnit_Weapon_Name.TabIndex = 30;
            SUnit_Weapon_Name.Text = "label9";
            // 
            // SUnit_Armor_Name
            // 
            SUnit_Armor_Name.AutoSize = true;
            SUnit_Armor_Name.Location = new System.Drawing.Point(673, 606);
            SUnit_Armor_Name.Name = "SUnit_Armor_Name";
            SUnit_Armor_Name.Size = new System.Drawing.Size(41, 13);
            SUnit_Armor_Name.TabIndex = 31;
            SUnit_Armor_Name.Text = "label10";
            // 
            // SUnit_Soul_Name
            // 
            SUnit_Soul_Name.AutoSize = true;
            SUnit_Soul_Name.Location = new System.Drawing.Point(673, 643);
            SUnit_Soul_Name.Name = "SUnit_Soul_Name";
            SUnit_Soul_Name.Size = new System.Drawing.Size(41, 13);
            SUnit_Soul_Name.TabIndex = 32;
            SUnit_Soul_Name.Text = "label11";
            // 
            // SUnit_AttackDmg_Bonus
            // 
            SUnit_AttackDmg_Bonus.AutoSize = true;
            SUnit_AttackDmg_Bonus.Location = new System.Drawing.Point(243, 716);
            SUnit_AttackDmg_Bonus.Name = "SUnit_AttackDmg_Bonus";
            SUnit_AttackDmg_Bonus.Size = new System.Drawing.Size(41, 13);
            SUnit_AttackDmg_Bonus.TabIndex = 33;
            SUnit_AttackDmg_Bonus.Text = "label12";
            // 
            // SUnit_Def_Bonus
            // 
            SUnit_Def_Bonus.AutoSize = true;
            SUnit_Def_Bonus.Location = new System.Drawing.Point(348, 716);
            SUnit_Def_Bonus.Name = "SUnit_Def_Bonus";
            SUnit_Def_Bonus.Size = new System.Drawing.Size(41, 13);
            SUnit_Def_Bonus.TabIndex = 34;
            SUnit_Def_Bonus.Text = "label13";
            // 
            // SUnit_Crit_Bonus
            // 
            SUnit_Crit_Bonus.AutoSize = true;
            SUnit_Crit_Bonus.Location = new System.Drawing.Point(457, 716);
            SUnit_Crit_Bonus.Name = "SUnit_Crit_Bonus";
            SUnit_Crit_Bonus.Size = new System.Drawing.Size(41, 13);
            SUnit_Crit_Bonus.TabIndex = 35;
            SUnit_Crit_Bonus.Text = "label14";
            // 
            // SUnit_Dodge_Bonus
            // 
            SUnit_Dodge_Bonus.AutoSize = true;
            SUnit_Dodge_Bonus.Location = new System.Drawing.Point(567, 716);
            SUnit_Dodge_Bonus.Name = "SUnit_Dodge_Bonus";
            SUnit_Dodge_Bonus.Size = new System.Drawing.Size(41, 13);
            SUnit_Dodge_Bonus.TabIndex = 36;
            SUnit_Dodge_Bonus.Text = "label15";
            // 
            // SUnit_Level
            // 
            SUnit_Level.AutoSize = true;
            SUnit_Level.Location = new System.Drawing.Point(148, 550);
            SUnit_Level.Name = "SUnit_Level";
            SUnit_Level.Size = new System.Drawing.Size(35, 13);
            SUnit_Level.TabIndex = 37;
            SUnit_Level.Text = "label1";
            // 
            // SUnit_Class
            // 
            SUnit_Class.AutoSize = true;
            SUnit_Class.Location = new System.Drawing.Point(94, 550);
            SUnit_Class.Name = "SUnit_Class";
            SUnit_Class.Size = new System.Drawing.Size(35, 13);
            SUnit_Class.TabIndex = 38;
            SUnit_Class.Text = "label1";
            // 
            // TopMenu
            // 
            TopMenu.Location = new System.Drawing.Point(1, -1);
            TopMenu.Name = "TopMenu";
            TopMenu.Size = new System.Drawing.Size(1353, 27);
            TopMenu.TabIndex = 39;
            TopMenu.TabStop = false;
            // 
            // Gold_Img
            // 
            Gold_Img.Image = global::Islands.Properties.Resources.VOID;
            Gold_Img.Location = new System.Drawing.Point(13, 10);
            Gold_Img.Name = "Gold_Img";
            Gold_Img.Size = new System.Drawing.Size(25, 25);
            Gold_Img.TabIndex = 40;
            Gold_Img.TabStop = false;
            // 
            // Gold_lbl
            // 
            Gold_lbl.AutoSize = true;
            Gold_lbl.Location = new System.Drawing.Point(44, 13);
            Gold_lbl.Name = "Gold_lbl";
            Gold_lbl.Size = new System.Drawing.Size(35, 13);
            Gold_lbl.TabIndex = 41;
            Gold_lbl.Text = "label1";
            // 
            // Movesleft_img
            // 
            Movesleft_img.Image = global::Islands.Properties.Resources.VOID;
            Movesleft_img.Location = new System.Drawing.Point(104, 10);
            Movesleft_img.Name = "Movesleft_img";
            Movesleft_img.Size = new System.Drawing.Size(25, 25);
            Movesleft_img.TabIndex = 42;
            Movesleft_img.TabStop = false;
            // 
            // Movesleft
            // 
            Movesleft.AutoSize = true;
            Movesleft.Location = new System.Drawing.Point(148, 13);
            Movesleft.Name = "Movesleft";
            Movesleft.Size = new System.Drawing.Size(35, 13);
            Movesleft.TabIndex = 43;
            Movesleft.Text = "label1";
            // 
            // SUnit_aff
            // 
            SUnit_aff.AutoSize = true;
            SUnit_aff.Location = new System.Drawing.Point(12, 716);
            SUnit_aff.Name = "SUnit_aff";
            SUnit_aff.Size = new System.Drawing.Size(35, 13);
            SUnit_aff.TabIndex = 44;
            SUnit_aff.Text = "label1";
            // 
            // Influence_img
            // 
            Influence_img.Location = new System.Drawing.Point(740, 569);
            Influence_img.Name = "Influence_img";
            Influence_img.Size = new System.Drawing.Size(86, 50);
            Influence_img.TabIndex = 45;
            Influence_img.TabStop = false;
            // 
            // SUnit_Inf
            // 
            SUnit_Inf.AutoSize = true;
            SUnit_Inf.Location = new System.Drawing.Point(764, 643);
            SUnit_Inf.Name = "SUnit_Inf";
            SUnit_Inf.Size = new System.Drawing.Size(35, 13);
            SUnit_Inf.TabIndex = 46;
            SUnit_Inf.Text = "label9";
            // 
            // NextTurn
            // 
            NextTurn.Location = new System.Drawing.Point(634, 673);
            NextTurn.Name = "NextTurn";
            NextTurn.Size = new System.Drawing.Size(143, 56);
            NextTurn.TabIndex = 47;
            NextTurn.Text = "NEXT TURN";
            NextTurn.UseVisualStyleBackColor = true;
            NextTurn.Click += new System.EventHandler(NextTurn_Click);
            // 
            // Debug
            // 
            Debug.AutoSize = true;
            Debug.Location = new System.Drawing.Point(1251, -1);
            Debug.Name = "Debug";
            Debug.Size = new System.Drawing.Size(35, 13);
            Debug.TabIndex = 48;
            Debug.Text = "label1";
            // 
            // SUnit_MovesLeft
            // 
            SUnit_MovesLeft.AutoSize = true;
            SUnit_MovesLeft.Location = new System.Drawing.Point(148, 716);
            SUnit_MovesLeft.Name = "SUnit_MovesLeft";
            SUnit_MovesLeft.Size = new System.Drawing.Size(35, 13);
            SUnit_MovesLeft.TabIndex = 49;
            SUnit_MovesLeft.Text = "label1";
            // 
            // Production_img
            // 
            Production_img.Image = global::Islands.Properties.Resources.VOID;
            Production_img.Location = new System.Drawing.Point(202, 10);
            Production_img.Name = "Production_img";
            Production_img.Size = new System.Drawing.Size(25, 25);
            Production_img.TabIndex = 50;
            Production_img.TabStop = false;
            // 
            // production
            // 
            production.AutoSize = true;
            production.Location = new System.Drawing.Point(249, 13);
            production.Name = "production";
            production.Size = new System.Drawing.Size(35, 13);
            production.TabIndex = 51;
            production.Text = "label1";
            // 
            // Shop_btn
            // 
            Shop_btn.Location = new System.Drawing.Point(417, 3);
            Shop_btn.Name = "Shop_btn";
            Shop_btn.Size = new System.Drawing.Size(75, 23);
            Shop_btn.TabIndex = 52;
            Shop_btn.Text = "Shop";
            Shop_btn.UseVisualStyleBackColor = true;
            Shop_btn.Visible = false;
            // 
            // Armory_Btn
            // 
            Armory_Btn.Location = new System.Drawing.Point(524, 3);
            Armory_Btn.Name = "Armory_Btn";
            Armory_Btn.Size = new System.Drawing.Size(75, 23);
            Armory_Btn.TabIndex = 53;
            Armory_Btn.Text = "Armory";
            Armory_Btn.UseVisualStyleBackColor = true;
            Armory_Btn.Visible = false;
            Armory_Btn.Click += new System.EventHandler(Armory_Btn_Click);
            // 
            // InUse
            // 
            InUse.AutoSize = true;
            InUse.Location = new System.Drawing.Point(334, 8);
            InUse.Name = "InUse";
            InUse.Size = new System.Drawing.Size(39, 13);
            InUse.TabIndex = 55;
            InUse.Text = "In use:";
            InUse.Visible = false;
            // 
            // MessageBox_LB
            // 
            MessageBox_LB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            MessageBox_LB.FormattingEnabled = true;
            MessageBox_LB.Location = new System.Drawing.Point(952, -1);
            MessageBox_LB.Name = "MessageBox_LB";
            MessageBox_LB.Size = new System.Drawing.Size(320, 95);
            MessageBox_LB.TabIndex = 56;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1272, 729);
            Controls.Add(MessageBox_LB);
            Controls.Add(InUse);
            Controls.Add(Armory_Btn);
            Controls.Add(Shop_btn);
            Controls.Add(production);
            Controls.Add(Production_img);
            Controls.Add(SUnit_MovesLeft);
            Controls.Add(Debug);
            Controls.Add(NextTurn);
            Controls.Add(SUnit_Inf);
            Controls.Add(Influence_img);
            Controls.Add(SUnit_aff);
            Controls.Add(Movesleft);
            Controls.Add(Movesleft_img);
            Controls.Add(Gold_lbl);
            Controls.Add(Gold_Img);
            Controls.Add(TopMenu);
            Controls.Add(SUnit_Class);
            Controls.Add(SUnit_Level);
            Controls.Add(SUnit_Dodge_Bonus);
            Controls.Add(SUnit_Crit_Bonus);
            Controls.Add(SUnit_Def_Bonus);
            Controls.Add(SUnit_AttackDmg_Bonus);
            Controls.Add(SUnit_Soul_Name);
            Controls.Add(SUnit_Armor_Name);
            Controls.Add(SUnit_Weapon_Name);
            Controls.Add(SUnit_Soul);
            Controls.Add(SUnit_Armor);
            Controls.Add(SUnit_Weapon);
            Controls.Add(SUnit_Dodge);
            Controls.Add(SUnit_Crit);
            Controls.Add(SUnit_Def);
            Controls.Add(SUnit_AttackDmg);
            Controls.Add(SUnit_Health);
            Controls.Add(SUnit_Dodge_img);
            Controls.Add(SUnit_Crit_img);
            Controls.Add(SUnit_Def_img);
            Controls.Add(SUnit_AttackDmg_img);
            Controls.Add(SUnit_Attack3_lbl);
            Controls.Add(SUnit_Attack2_lbl);
            Controls.Add(SUnit_Attack1_lbl);
            Controls.Add(SUnit_Move_lbl);
            Controls.Add(SUnit_Attack3);
            Controls.Add(SUnit_Attack2);
            Controls.Add(SUnit_Attack1);
            Controls.Add(SUnit_Move);
            Controls.Add(SUnit_Name);
            Controls.Add(SUnit_Image);
            Controls.Add(THEALLSEEINGEYE);
            Controls.Add(Menu_Un);
            Controls.Add(InUse_lbl);
            Controls.Add(Map);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            Name = "Form1";
            Text = "MAP";
            Load += new System.EventHandler(Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(InUse_lbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Menu_Un)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Attack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Attack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Attack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_AttackDmg_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Def_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Crit_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Dodge_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Weapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Armor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SUnit_Soul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(TopMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Gold_Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Movesleft_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Influence_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Production_img)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        static public System.Windows.Forms.DataGridView InUse_lbl;
        static public System.Windows.Forms.PictureBox Menu_Un;
        static public System.Windows.Forms.Button THEALLSEEINGEYE;
        static public System.Windows.Forms.PictureBox SUnit_Image;
        static public System.Windows.Forms.Label SUnit_Name;
        static public System.Windows.Forms.PictureBox SUnit_Move;
        static public System.Windows.Forms.PictureBox SUnit_Attack1;
        static public System.Windows.Forms.PictureBox SUnit_Attack2;
        static public System.Windows.Forms.PictureBox SUnit_Attack3;
        static public System.Windows.Forms.Label SUnit_Move_lbl;
        static public System.Windows.Forms.Label SUnit_Attack1_lbl;
        static public System.Windows.Forms.Label SUnit_Attack2_lbl;
        static public System.Windows.Forms.Label SUnit_Attack3_lbl;
        static public System.Windows.Forms.PictureBox SUnit_AttackDmg_img;
        static public System.Windows.Forms.PictureBox SUnit_Def_img;
        static public System.Windows.Forms.PictureBox SUnit_Crit_img;
        static public System.Windows.Forms.PictureBox SUnit_Dodge_img;
        static public System.Windows.Forms.ProgressBar SUnit_Health;
        static public System.Windows.Forms.Label SUnit_AttackDmg;
        static public System.Windows.Forms.Label SUnit_Def;
        static public System.Windows.Forms.Label SUnit_Crit;
        static public System.Windows.Forms.Label SUnit_Dodge;
        static public System.Windows.Forms.PictureBox SUnit_Weapon;
        static public System.Windows.Forms.PictureBox SUnit_Armor;
        static public System.Windows.Forms.PictureBox SUnit_Soul;
        static public System.Windows.Forms.Label SUnit_Weapon_Name;
        static public System.Windows.Forms.Label SUnit_Armor_Name;
        static public System.Windows.Forms.Label SUnit_Soul_Name;
        static public System.Windows.Forms.Label SUnit_AttackDmg_Bonus;
        static public System.Windows.Forms.Label SUnit_Def_Bonus;
        static public System.Windows.Forms.Label SUnit_Crit_Bonus;
        static public System.Windows.Forms.Label SUnit_Dodge_Bonus;
        static public System.Windows.Forms.Label SUnit_Level;
        static public System.Windows.Forms.Label SUnit_Class;
        static public System.Windows.Forms.PictureBox TopMenu;
        static public System.Windows.Forms.PictureBox Gold_Img;
        static public System.Windows.Forms.PictureBox Movesleft_img;
        static public System.Windows.Forms.Label SUnit_aff;
        static public System.Windows.Forms.PictureBox Influence_img;
        static public System.Windows.Forms.Label SUnit_Inf;
        static public System.Windows.Forms.Button NextTurn;
        static public System.Windows.Forms.Label Debug;
        static public System.Windows.Forms.Label SUnit_MovesLeft;
        static public System.Windows.Forms.PictureBox Production_img;
        static public System.Windows.Forms.Button Shop_btn;
        static public System.Windows.Forms.Button Armory_Btn;
        static public System.Windows.Forms.Label InUse;
        static public System.Windows.Forms.ListBox MessageBox_LB;
        static public System.Windows.Forms.DataGridView Map;
        static public System.Windows.Forms.Label Gold_lbl;
        static public System.Windows.Forms.Label Movesleft;
        static public System.Windows.Forms.Label production;

    }
}

