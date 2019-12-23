namespace Q_Learning
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridSize = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.agentBtn = new MetroFramework.Controls.MetroRadioButton();
            this.cheeseBtn = new MetroFramework.Controls.MetroRadioButton();
            this.wallBtn = new MetroFramework.Controls.MetroRadioButton();
            this.catBtn = new MetroFramework.Controls.MetroRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Gamma = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.Episodes = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.Steps = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.startBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.EpsilonDecayRate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.Epsilon = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.trainingTimer = new System.Windows.Forms.Timer(this.components);
            this.episodeLabel = new System.Windows.Forms.Label();
            this.stopTrainingBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exploitBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exploitTimer = new System.Windows.Forms.Timer(this.components);
            this.QGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 41);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Q-LEARNING";
            // 
            // gridSize
            // 
            this.gridSize.FormattingEnabled = true;
            this.gridSize.ItemHeight = 23;
            this.gridSize.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10"});
            this.gridSize.Location = new System.Drawing.Point(99, 54);
            this.gridSize.Name = "gridSize";
            this.gridSize.Size = new System.Drawing.Size(121, 29);
            this.gridSize.TabIndex = 2;
            this.gridSize.SelectionChangeCommitted += new System.EventHandler(this.gridSize_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "GRID SIZE";
            // 
            // formEllipse
            // 
            this.formEllipse.ElipseRadius = 15;
            this.formEllipse.TargetControl = this;
            // 
            // agentBtn
            // 
            this.agentBtn.AutoSize = true;
            this.agentBtn.BackColor = System.Drawing.Color.Transparent;
            this.agentBtn.ForeColor = System.Drawing.Color.White;
            this.agentBtn.Location = new System.Drawing.Point(640, 92);
            this.agentBtn.Name = "agentBtn";
            this.agentBtn.Size = new System.Drawing.Size(63, 15);
            this.agentBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.agentBtn.TabIndex = 5;
            this.agentBtn.Text = "MOUSE";
            this.agentBtn.UseVisualStyleBackColor = false;
            // 
            // cheeseBtn
            // 
            this.cheeseBtn.AutoSize = true;
            this.cheeseBtn.BackColor = System.Drawing.Color.Transparent;
            this.cheeseBtn.ForeColor = System.Drawing.Color.White;
            this.cheeseBtn.Location = new System.Drawing.Point(709, 92);
            this.cheeseBtn.Name = "cheeseBtn";
            this.cheeseBtn.Size = new System.Drawing.Size(64, 15);
            this.cheeseBtn.TabIndex = 6;
            this.cheeseBtn.Text = "CHEESE";
            this.cheeseBtn.UseVisualStyleBackColor = false;
            // 
            // wallBtn
            // 
            this.wallBtn.AutoSize = true;
            this.wallBtn.BackColor = System.Drawing.Color.Transparent;
            this.wallBtn.ForeColor = System.Drawing.Color.White;
            this.wallBtn.Location = new System.Drawing.Point(779, 92);
            this.wallBtn.Name = "wallBtn";
            this.wallBtn.Size = new System.Drawing.Size(54, 15);
            this.wallBtn.TabIndex = 7;
            this.wallBtn.Text = "WALL";
            this.wallBtn.UseVisualStyleBackColor = false;
            // 
            // catBtn
            // 
            this.catBtn.AutoSize = true;
            this.catBtn.BackColor = System.Drawing.Color.Transparent;
            this.catBtn.ForeColor = System.Drawing.Color.White;
            this.catBtn.Location = new System.Drawing.Point(839, 92);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(45, 15);
            this.catBtn.TabIndex = 8;
            this.catBtn.Text = "CAT";
            this.catBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "DISCOUNT FACTOR (GAMMA)";
            // 
            // Gamma
            // 
            this.Gamma.BorderColorFocused = System.Drawing.Color.Blue;
            this.Gamma.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gamma.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Gamma.BorderThickness = 3;
            this.Gamma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gamma.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Gamma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gamma.isPassword = false;
            this.Gamma.Location = new System.Drawing.Point(636, 328);
            this.Gamma.Margin = new System.Windows.Forms.Padding(4);
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(260, 32);
            this.Gamma.TabIndex = 11;
            this.Gamma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "EPISODES";
            // 
            // Episodes
            // 
            this.Episodes.BorderColorFocused = System.Drawing.Color.Blue;
            this.Episodes.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Episodes.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Episodes.BorderThickness = 3;
            this.Episodes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Episodes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Episodes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Episodes.isPassword = false;
            this.Episodes.Location = new System.Drawing.Point(636, 385);
            this.Episodes.Margin = new System.Windows.Forms.Padding(4);
            this.Episodes.Name = "Episodes";
            this.Episodes.Size = new System.Drawing.Size(260, 32);
            this.Episodes.TabIndex = 13;
            this.Episodes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "STEPS";
            // 
            // Steps
            // 
            this.Steps.BorderColorFocused = System.Drawing.Color.Blue;
            this.Steps.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Steps.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Steps.BorderThickness = 3;
            this.Steps.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Steps.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Steps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Steps.isPassword = false;
            this.Steps.Location = new System.Drawing.Point(636, 444);
            this.Steps.Margin = new System.Windows.Forms.Padding(4);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(260, 32);
            this.Steps.TabIndex = 15;
            this.Steps.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // startBtn
            // 
            this.startBtn.ActiveBorderThickness = 2;
            this.startBtn.ActiveCornerRadius = 20;
            this.startBtn.ActiveFillColor = System.Drawing.Color.Blue;
            this.startBtn.ActiveForecolor = System.Drawing.Color.White;
            this.startBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startBtn.BackgroundImage")));
            this.startBtn.ButtonText = "START TRANING";
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.startBtn.IdleBorderThickness = 2;
            this.startBtn.IdleCornerRadius = 20;
            this.startBtn.IdleFillColor = System.Drawing.Color.Navy;
            this.startBtn.IdleForecolor = System.Drawing.Color.White;
            this.startBtn.IdleLineColor = System.Drawing.Color.Black;
            this.startBtn.Location = new System.Drawing.Point(678, 475);
            this.startBtn.Margin = new System.Windows.Forms.Padding(5);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(181, 41);
            this.startBtn.TabIndex = 17;
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "EPSILON DECAY RATE";
            // 
            // EpsilonDecayRate
            // 
            this.EpsilonDecayRate.BorderColorFocused = System.Drawing.Color.Blue;
            this.EpsilonDecayRate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EpsilonDecayRate.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.EpsilonDecayRate.BorderThickness = 3;
            this.EpsilonDecayRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EpsilonDecayRate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EpsilonDecayRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EpsilonDecayRate.isPassword = false;
            this.EpsilonDecayRate.Location = new System.Drawing.Point(636, 269);
            this.EpsilonDecayRate.Margin = new System.Windows.Forms.Padding(4);
            this.EpsilonDecayRate.Name = "EpsilonDecayRate";
            this.EpsilonDecayRate.Size = new System.Drawing.Size(260, 32);
            this.EpsilonDecayRate.TabIndex = 18;
            this.EpsilonDecayRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(632, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "EPSILON";
            // 
            // Epsilon
            // 
            this.Epsilon.BorderColorFocused = System.Drawing.Color.Blue;
            this.Epsilon.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Epsilon.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Epsilon.BorderThickness = 3;
            this.Epsilon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Epsilon.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Epsilon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Epsilon.isPassword = false;
            this.Epsilon.Location = new System.Drawing.Point(636, 210);
            this.Epsilon.Margin = new System.Windows.Forms.Padding(4);
            this.Epsilon.Name = "Epsilon";
            this.Epsilon.Size = new System.Drawing.Size(260, 32);
            this.Epsilon.TabIndex = 20;
            this.Epsilon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // trainingTimer
            // 
            this.trainingTimer.Tick += new System.EventHandler(this.trainingTimer_Tick);
            // 
            // episodeLabel
            // 
            this.episodeLabel.AutoSize = true;
            this.episodeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeLabel.Location = new System.Drawing.Point(1067, 64);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Size = new System.Drawing.Size(83, 19);
            this.episodeLabel.TabIndex = 24;
            this.episodeLabel.Text = "EPISODE 0";
            // 
            // stopTrainingBtn
            // 
            this.stopTrainingBtn.ActiveBorderThickness = 2;
            this.stopTrainingBtn.ActiveCornerRadius = 20;
            this.stopTrainingBtn.ActiveFillColor = System.Drawing.Color.Red;
            this.stopTrainingBtn.ActiveForecolor = System.Drawing.Color.White;
            this.stopTrainingBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.stopTrainingBtn.BackColor = System.Drawing.Color.White;
            this.stopTrainingBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopTrainingBtn.BackgroundImage")));
            this.stopTrainingBtn.ButtonText = "STOP TRANING";
            this.stopTrainingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopTrainingBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopTrainingBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.stopTrainingBtn.IdleBorderThickness = 2;
            this.stopTrainingBtn.IdleCornerRadius = 20;
            this.stopTrainingBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopTrainingBtn.IdleForecolor = System.Drawing.Color.White;
            this.stopTrainingBtn.IdleLineColor = System.Drawing.Color.Black;
            this.stopTrainingBtn.Location = new System.Drawing.Point(678, 526);
            this.stopTrainingBtn.Margin = new System.Windows.Forms.Padding(5);
            this.stopTrainingBtn.Name = "stopTrainingBtn";
            this.stopTrainingBtn.Size = new System.Drawing.Size(181, 41);
            this.stopTrainingBtn.TabIndex = 25;
            this.stopTrainingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stopTrainingBtn.Click += new System.EventHandler(this.stopTrainingBtn_Click);
            // 
            // exploitBtn
            // 
            this.exploitBtn.ActiveBorderThickness = 2;
            this.exploitBtn.ActiveCornerRadius = 20;
            this.exploitBtn.ActiveFillColor = System.Drawing.Color.Blue;
            this.exploitBtn.ActiveForecolor = System.Drawing.Color.White;
            this.exploitBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.exploitBtn.BackColor = System.Drawing.Color.White;
            this.exploitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exploitBtn.BackgroundImage")));
            this.exploitBtn.ButtonText = "EXPLOIT";
            this.exploitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exploitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exploitBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.exploitBtn.IdleBorderThickness = 2;
            this.exploitBtn.IdleCornerRadius = 20;
            this.exploitBtn.IdleFillColor = System.Drawing.Color.Navy;
            this.exploitBtn.IdleForecolor = System.Drawing.Color.White;
            this.exploitBtn.IdleLineColor = System.Drawing.Color.Black;
            this.exploitBtn.Location = new System.Drawing.Point(678, 577);
            this.exploitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exploitBtn.Name = "exploitBtn";
            this.exploitBtn.Size = new System.Drawing.Size(181, 41);
            this.exploitBtn.TabIndex = 26;
            this.exploitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exploitBtn.Click += new System.EventHandler(this.exploitBtn_Click);
            // 
            // exploitTimer
            // 
            this.exploitTimer.Tick += new System.EventHandler(this.exploitTimer_Tick);
            // 
            // QGrid
            // 
            this.QGrid.AllowUserToAddRows = false;
            this.QGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.QGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.QGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.QGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.QGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.QGrid.DoubleBuffered = true;
            this.QGrid.EnableHeadersVisualStyles = false;
            this.QGrid.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.QGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.QGrid.Location = new System.Drawing.Point(910, 92);
            this.QGrid.Name = "QGrid";
            this.QGrid.ReadOnly = true;
            this.QGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.QGrid.Size = new System.Drawing.Size(417, 596);
            this.QGrid.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STATE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "LEFT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RIGHT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "UP";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DOWN";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1339, 700);
            this.Controls.Add(this.QGrid);
            this.Controls.Add(this.exploitBtn);
            this.Controls.Add(this.stopTrainingBtn);
            this.Controls.Add(this.episodeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Epsilon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EpsilonDecayRate);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Steps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Episodes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Gamma);
            this.Controls.Add(this.catBtn);
            this.Controls.Add(this.wallBtn);
            this.Controls.Add(this.cheeseBtn);
            this.Controls.Add(this.agentBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridSize);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox gridSize;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse formEllipse;
        private MetroFramework.Controls.MetroRadioButton wallBtn;
        private MetroFramework.Controls.MetroRadioButton cheeseBtn;
        private MetroFramework.Controls.MetroRadioButton agentBtn;
        private MetroFramework.Controls.MetroRadioButton catBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox Episodes;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox Gamma;
        private Bunifu.Framework.UI.BunifuThinButton2 startBtn;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox Steps;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox Epsilon;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox EpsilonDecayRate;
        private System.Windows.Forms.Timer trainingTimer;
        private System.Windows.Forms.Label episodeLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 stopTrainingBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 exploitBtn;
        private System.Windows.Forms.Timer exploitTimer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid QGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

