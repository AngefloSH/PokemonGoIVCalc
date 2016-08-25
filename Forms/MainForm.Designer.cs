namespace PokémonGoManager
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBestAtk = new System.Windows.Forms.CheckBox();
            this.chkBestDef = new System.Windows.Forms.CheckBox();
            this.chkBestHP = new System.Windows.Forms.CheckBox();
            this.cboStatLevel = new System.Windows.Forms.ComboBox();
            this.cboOverall = new System.Windows.Forms.ComboBox();
            this.lblStatsLevel = new System.Windows.Forms.Label();
            this.lblBestStats = new System.Windows.Forms.Label();
            this.lblOverall = new System.Windows.Forms.Label();
            this.chkAppraise = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkHatched = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPokemon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCP = new System.Windows.Forms.NumericUpDown();
            this.nudHP = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.françaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamMysticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamIntuitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.cmdCalculate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblResults);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(734, 414);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBestAtk);
            this.groupBox2.Controls.Add(this.chkBestDef);
            this.groupBox2.Controls.Add(this.chkBestHP);
            this.groupBox2.Controls.Add(this.cboStatLevel);
            this.groupBox2.Controls.Add(this.cboOverall);
            this.groupBox2.Controls.Add(this.lblStatsLevel);
            this.groupBox2.Controls.Add(this.lblBestStats);
            this.groupBox2.Controls.Add(this.lblOverall);
            this.groupBox2.Controls.Add(this.chkAppraise);
            this.groupBox2.Location = new System.Drawing.Point(3, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 179);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // chkBestAtk
            // 
            this.chkBestAtk.AutoSize = true;
            this.chkBestAtk.Enabled = false;
            this.chkBestAtk.Location = new System.Drawing.Point(156, 94);
            this.chkBestAtk.Name = "chkBestAtk";
            this.chkBestAtk.Size = new System.Drawing.Size(57, 17);
            this.chkBestAtk.TabIndex = 7;
            this.chkBestAtk.Text = "Attack";
            this.chkBestAtk.UseVisualStyleBackColor = true;
            // 
            // chkBestDef
            // 
            this.chkBestDef.AutoSize = true;
            this.chkBestDef.Enabled = false;
            this.chkBestDef.Location = new System.Drawing.Point(273, 94);
            this.chkBestDef.Name = "chkBestDef";
            this.chkBestDef.Size = new System.Drawing.Size(66, 17);
            this.chkBestDef.TabIndex = 8;
            this.chkBestDef.Text = "Defense";
            this.chkBestDef.UseVisualStyleBackColor = true;
            // 
            // chkBestHP
            // 
            this.chkBestHP.AutoSize = true;
            this.chkBestHP.Enabled = false;
            this.chkBestHP.Location = new System.Drawing.Point(55, 94);
            this.chkBestHP.Name = "chkBestHP";
            this.chkBestHP.Size = new System.Drawing.Size(41, 17);
            this.chkBestHP.TabIndex = 6;
            this.chkBestHP.Text = "HP";
            this.chkBestHP.UseVisualStyleBackColor = true;
            // 
            // cboStatLevel
            // 
            this.cboStatLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatLevel.Enabled = false;
            this.cboStatLevel.FormattingEnabled = true;
            this.cboStatLevel.Location = new System.Drawing.Point(35, 130);
            this.cboStatLevel.Name = "cboStatLevel";
            this.cboStatLevel.Size = new System.Drawing.Size(377, 21);
            this.cboStatLevel.TabIndex = 9;
            // 
            // cboOverall
            // 
            this.cboOverall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOverall.Enabled = false;
            this.cboOverall.FormattingEnabled = true;
            this.cboOverall.Location = new System.Drawing.Point(35, 45);
            this.cboOverall.Name = "cboOverall";
            this.cboOverall.Size = new System.Drawing.Size(377, 21);
            this.cboOverall.TabIndex = 5;
            // 
            // lblStatsLevel
            // 
            this.lblStatsLevel.AutoSize = true;
            this.lblStatsLevel.Enabled = false;
            this.lblStatsLevel.Location = new System.Drawing.Point(19, 114);
            this.lblStatsLevel.Name = "lblStatsLevel";
            this.lblStatsLevel.Size = new System.Drawing.Size(86, 13);
            this.lblStatsLevel.TabIndex = 1;
            this.lblStatsLevel.Text = "Best Stat(s) level";
            // 
            // lblBestStats
            // 
            this.lblBestStats.AutoSize = true;
            this.lblBestStats.Enabled = false;
            this.lblBestStats.Location = new System.Drawing.Point(19, 71);
            this.lblBestStats.Name = "lblBestStats";
            this.lblBestStats.Size = new System.Drawing.Size(61, 13);
            this.lblBestStats.TabIndex = 1;
            this.lblBestStats.Text = "Best Stat(s)";
            // 
            // lblOverall
            // 
            this.lblOverall.AutoSize = true;
            this.lblOverall.Enabled = false;
            this.lblOverall.Location = new System.Drawing.Point(19, 29);
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.Size = new System.Drawing.Size(40, 13);
            this.lblOverall.TabIndex = 1;
            this.lblOverall.Text = "Overall";
            // 
            // chkAppraise
            // 
            this.chkAppraise.AutoSize = true;
            this.chkAppraise.Location = new System.Drawing.Point(6, 0);
            this.chkAppraise.Name = "chkAppraise";
            this.chkAppraise.Size = new System.Drawing.Size(67, 17);
            this.chkAppraise.TabIndex = 4;
            this.chkAppraise.Text = "Appraise";
            this.chkAppraise.UseVisualStyleBackColor = true;
            this.chkAppraise.CheckedChanged += new System.EventHandler(this.chkAppraise_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHatched);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboPokemon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudLevel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudCP);
            this.groupBox1.Controls.Add(this.nudHP);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 155);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic information";
            // 
            // chkHatched
            // 
            this.chkHatched.AutoSize = true;
            this.chkHatched.Location = new System.Drawing.Point(161, 125);
            this.chkHatched.Name = "chkHatched";
            this.chkHatched.Size = new System.Drawing.Size(127, 17);
            this.chkHatched.TabIndex = 6;
            this.chkHatched.Text = "Hatched from an Egg";
            this.toolTip1.SetToolTip(this.chkHatched, "Every Pokémon hatched from Eggs have all IVs of 10 or above.");
            this.chkHatched.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pokémon Species";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "HP";
            // 
            // cboPokemon
            // 
            this.cboPokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPokemon.FormattingEnabled = true;
            this.cboPokemon.Location = new System.Drawing.Point(80, 41);
            this.cboPokemon.Name = "cboPokemon";
            this.cboPokemon.Size = new System.Drawing.Size(152, 21);
            this.cboPokemon.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Combat Points";
            // 
            // nudLevel
            // 
            this.nudLevel.DecimalPlaces = 1;
            this.nudLevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudLevel.Location = new System.Drawing.Point(312, 42);
            this.nudLevel.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(70, 20);
            this.nudLevel.TabIndex = 1;
            this.nudLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Enter += new System.EventHandler(this.nudLevel_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Level";
            // 
            // nudCP
            // 
            this.nudCP.Location = new System.Drawing.Point(80, 91);
            this.nudCP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudCP.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCP.Name = "nudCP";
            this.nudCP.Size = new System.Drawing.Size(70, 20);
            this.nudCP.TabIndex = 2;
            this.nudCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCP.Enter += new System.EventHandler(this.nudCP_Enter);
            // 
            // nudHP
            // 
            this.nudHP.Location = new System.Drawing.Point(312, 91);
            this.nudHP.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudHP.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHP.Name = "nudHP";
            this.nudHP.Size = new System.Drawing.Size(70, 20);
            this.nudHP.TabIndex = 3;
            this.nudHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHP.Enter += new System.EventHandler(this.nudHP_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refine →";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(360, 349);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
            this.cmdCalculate.TabIndex = 10;
            this.cmdCalculate.Text = "Calculate →";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // lblResults
            // 
            this.lblResults.Location = new System.Drawing.Point(3, 349);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(281, 65);
            this.lblResults.TabIndex = 100;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAttack,
            this.colDefense,
            this.colHP});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(281, 340);
            this.dataGridView1.TabIndex = 99;
            // 
            // colAttack
            // 
            this.colAttack.HeaderText = "Attack";
            this.colAttack.Name = "colAttack";
            this.colAttack.ReadOnly = true;
            this.colAttack.Width = 60;
            // 
            // colDefense
            // 
            this.colDefense.HeaderText = "Defense";
            this.colDefense.Name = "colDefense";
            this.colDefense.ReadOnly = true;
            this.colDefense.Width = 60;
            // 
            // colHP
            // 
            this.colHP.HeaderText = "HP";
            this.colHP.Name = "colHP";
            this.colHP.ReadOnly = true;
            this.colHP.Width = 60;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.teamToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.françaisToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // françaisToolStripMenuItem
            // 
            this.françaisToolStripMenuItem.Name = "françaisToolStripMenuItem";
            this.françaisToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.françaisToolStripMenuItem.Text = "Français";
            this.françaisToolStripMenuItem.Click += new System.EventHandler(this.françaisToolStripMenuItem_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamMysticToolStripMenuItem,
            this.teamValorToolStripMenuItem,
            this.teamIntuitionToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // teamMysticToolStripMenuItem
            // 
            this.teamMysticToolStripMenuItem.Name = "teamMysticToolStripMenuItem";
            this.teamMysticToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.teamMysticToolStripMenuItem.Text = "Team Mystic";
            this.teamMysticToolStripMenuItem.Click += new System.EventHandler(this.teamMysticToolStripMenuItem_Click);
            // 
            // teamValorToolStripMenuItem
            // 
            this.teamValorToolStripMenuItem.Name = "teamValorToolStripMenuItem";
            this.teamValorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.teamValorToolStripMenuItem.Text = "Team Valor";
            this.teamValorToolStripMenuItem.Click += new System.EventHandler(this.teamValorToolStripMenuItem_Click);
            // 
            // teamIntuitionToolStripMenuItem
            // 
            this.teamIntuitionToolStripMenuItem.Name = "teamIntuitionToolStripMenuItem";
            this.teamIntuitionToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.teamIntuitionToolStripMenuItem.Text = "Team Instinct";
            this.teamIntuitionToolStripMenuItem.Click += new System.EventHandler(this.teamIntuitionToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 457);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokémon GO IV Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.ComboBox cboPokemon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHP;
        private System.Windows.Forms.NumericUpDown nudCP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBestAtk;
        private System.Windows.Forms.CheckBox chkBestDef;
        private System.Windows.Forms.CheckBox chkBestHP;
        private System.Windows.Forms.ComboBox cboStatLevel;
        private System.Windows.Forms.ComboBox cboOverall;
        private System.Windows.Forms.Label lblStatsLevel;
        private System.Windows.Forms.Label lblBestStats;
        private System.Windows.Forms.Label lblOverall;
        private System.Windows.Forms.CheckBox chkAppraise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem françaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamMysticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamValorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamIntuitionToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkHatched;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblResults;
    }
}

