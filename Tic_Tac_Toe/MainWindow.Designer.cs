namespace Tic_Tac_Toe
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Action_Label = new System.Windows.Forms.Label();
            this.Play_Btn = new System.Windows.Forms.Button();
            this.About_Btn = new System.Windows.Forms.Button();
            this.Cross_Choose_Btn = new System.Windows.Forms.RadioButton();
            this.Zero_Choose_Btn = new System.Windows.Forms.RadioButton();
            this.Btn_2_2 = new System.Windows.Forms.Button();
            this.Btn_2_1 = new System.Windows.Forms.Button();
            this.Btn_2_0 = new System.Windows.Forms.Button();
            this.Btn_0_0 = new System.Windows.Forms.Button();
            this.Btn_0_1 = new System.Windows.Forms.Button();
            this.Btn_1_2 = new System.Windows.Forms.Button();
            this.Btn_1_1 = new System.Windows.Forms.Button();
            this.Btn_1_0 = new System.Windows.Forms.Button();
            this.Btn_0_2 = new System.Windows.Forms.Button();
            this.About_Label = new System.Windows.Forms.Label();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.ControllerPanel = new System.Windows.Forms.Panel();
            this.Stat_Btn = new System.Windows.Forms.Button();
            this.HardDifficultBtn = new System.Windows.Forms.RadioButton();
            this.MediumDifficult_Btn = new System.Windows.Forms.RadioButton();
            this.EasyDifficult_Btn = new System.Windows.Forms.RadioButton();
            this.PlayAgain_Btn = new System.Windows.Forms.Button();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.StyleBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.Back_Btn = new System.Windows.Forms.Button();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.StatPanel = new System.Windows.Forms.Panel();
            this.BackStat_Btn = new System.Windows.Forms.Button();
            this.HardLoseCount = new System.Windows.Forms.Label();
            this.HardLoseLabel = new System.Windows.Forms.Label();
            this.HardWinCount = new System.Windows.Forms.Label();
            this.HardWinLabel = new System.Windows.Forms.Label();
            this.HardLabel = new System.Windows.Forms.Label();
            this.MediumLoseCount = new System.Windows.Forms.Label();
            this.MediumLoseLabel = new System.Windows.Forms.Label();
            this.MediumWinCount = new System.Windows.Forms.Label();
            this.MediumWinLabel = new System.Windows.Forms.Label();
            this.MediumLabel = new System.Windows.Forms.Label();
            this.EasyLoseCount = new System.Windows.Forms.Label();
            this.EasyLoseLabel = new System.Windows.Forms.Label();
            this.EasyWinCount = new System.Windows.Forms.Label();
            this.EasyWinLabel = new System.Windows.Forms.Label();
            this.EasyLabel = new System.Windows.Forms.Label();
            this.ActionPanel.SuspendLayout();
            this.ControllerPanel.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.StatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Action_Label
            // 
            this.Action_Label.AutoSize = true;
            this.Action_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Action_Label.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Action_Label.Location = new System.Drawing.Point(59, 24);
            this.Action_Label.MinimumSize = new System.Drawing.Size(0, 20);
            this.Action_Label.Name = "Action_Label";
            this.Action_Label.Size = new System.Drawing.Size(130, 20);
            this.Action_Label.TabIndex = 0;
            this.Action_Label.Text = "Выберите сторону";
            // 
            // Play_Btn
            // 
            this.Play_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Play_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_Btn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play_Btn.Location = new System.Drawing.Point(33, 106);
            this.Play_Btn.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Play_Btn.Name = "Play_Btn";
            this.Play_Btn.Size = new System.Drawing.Size(194, 23);
            this.Play_Btn.TabIndex = 0;
            this.Play_Btn.Text = "Играть";
            this.Play_Btn.UseVisualStyleBackColor = true;
            this.Play_Btn.Click += new System.EventHandler(this.Play_Btn_Click);
            // 
            // About_Btn
            // 
            this.About_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.About_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_Btn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About_Btn.Location = new System.Drawing.Point(33, 205);
            this.About_Btn.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.About_Btn.Name = "About_Btn";
            this.About_Btn.Size = new System.Drawing.Size(194, 23);
            this.About_Btn.TabIndex = 1;
            this.About_Btn.Text = "Об игре";
            this.About_Btn.UseVisualStyleBackColor = true;
            this.About_Btn.Click += new System.EventHandler(this.About_Btn_Click);
            // 
            // Cross_Choose_Btn
            // 
            this.Cross_Choose_Btn.AutoSize = true;
            this.Cross_Choose_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cross_Choose_Btn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cross_Choose_Btn.Location = new System.Drawing.Point(36, 56);
            this.Cross_Choose_Btn.Name = "Cross_Choose_Btn";
            this.Cross_Choose_Btn.Size = new System.Drawing.Size(67, 18);
            this.Cross_Choose_Btn.TabIndex = 1;
            this.Cross_Choose_Btn.Text = "Крестик";
            this.Cross_Choose_Btn.UseVisualStyleBackColor = true;
            this.Cross_Choose_Btn.CheckedChanged += new System.EventHandler(this.Cross_Choose_Btn_CheckedChanged);
            // 
            // Zero_Choose_Btn
            // 
            this.Zero_Choose_Btn.AutoSize = true;
            this.Zero_Choose_Btn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zero_Choose_Btn.Location = new System.Drawing.Point(134, 56);
            this.Zero_Choose_Btn.Name = "Zero_Choose_Btn";
            this.Zero_Choose_Btn.Size = new System.Drawing.Size(55, 18);
            this.Zero_Choose_Btn.TabIndex = 2;
            this.Zero_Choose_Btn.Text = "Нолик";
            this.Zero_Choose_Btn.UseVisualStyleBackColor = true;
            this.Zero_Choose_Btn.CheckedChanged += new System.EventHandler(this.Zero_Choose_Btn_CheckedChanged);
            // 
            // Btn_2_2
            // 
            this.Btn_2_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_2_2.BackColor = System.Drawing.Color.White;
            this.Btn_2_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_2_2.BackgroundImage")));
            this.Btn_2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_2_2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_2_2.Location = new System.Drawing.Point(310, 248);
            this.Btn_2_2.MinimumSize = new System.Drawing.Size(130, 100);
            this.Btn_2_2.Name = "Btn_2_2";
            this.Btn_2_2.Size = new System.Drawing.Size(130, 100);
            this.Btn_2_2.TabIndex = 8;
            this.Btn_2_2.UseVisualStyleBackColor = false;
            this.Btn_2_2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_2_1
            // 
            this.Btn_2_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_2_1.BackColor = System.Drawing.Color.White;
            this.Btn_2_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_2_1.BackgroundImage")));
            this.Btn_2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_2_1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_2_1.Location = new System.Drawing.Point(175, 248);
            this.Btn_2_1.MinimumSize = new System.Drawing.Size(130, 100);
            this.Btn_2_1.Name = "Btn_2_1";
            this.Btn_2_1.Size = new System.Drawing.Size(130, 100);
            this.Btn_2_1.TabIndex = 7;
            this.Btn_2_1.UseVisualStyleBackColor = false;
            this.Btn_2_1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_2_0
            // 
            this.Btn_2_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_2_0.BackColor = System.Drawing.Color.White;
            this.Btn_2_0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_2_0.BackgroundImage")));
            this.Btn_2_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_2_0.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_2_0.Location = new System.Drawing.Point(39, 248);
            this.Btn_2_0.MinimumSize = new System.Drawing.Size(130, 100);
            this.Btn_2_0.Name = "Btn_2_0";
            this.Btn_2_0.Size = new System.Drawing.Size(130, 100);
            this.Btn_2_0.TabIndex = 6;
            this.Btn_2_0.UseVisualStyleBackColor = false;
            this.Btn_2_0.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_0_0
            // 
            this.Btn_0_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_0_0.BackColor = System.Drawing.Color.White;
            this.Btn_0_0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_0_0.BackgroundImage")));
            this.Btn_0_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_0_0.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_0_0.Location = new System.Drawing.Point(39, 36);
            this.Btn_0_0.MinimumSize = new System.Drawing.Size(130, 100);
            this.Btn_0_0.Name = "Btn_0_0";
            this.Btn_0_0.Size = new System.Drawing.Size(130, 100);
            this.Btn_0_0.TabIndex = 0;
            this.Btn_0_0.UseVisualStyleBackColor = false;
            this.Btn_0_0.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_0_1
            // 
            this.Btn_0_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_0_1.BackColor = System.Drawing.Color.White;
            this.Btn_0_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_0_1.BackgroundImage")));
            this.Btn_0_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_0_1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_0_1.Location = new System.Drawing.Point(175, 36);
            this.Btn_0_1.MinimumSize = new System.Drawing.Size(130, 100);
            this.Btn_0_1.Name = "Btn_0_1";
            this.Btn_0_1.Size = new System.Drawing.Size(130, 100);
            this.Btn_0_1.TabIndex = 1;
            this.Btn_0_1.UseVisualStyleBackColor = false;
            this.Btn_0_1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_1_2
            // 
            this.Btn_1_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_1_2.BackColor = System.Drawing.Color.White;
            this.Btn_1_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_1_2.BackgroundImage")));
            this.Btn_1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_1_2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_1_2.Location = new System.Drawing.Point(310, 142);
            this.Btn_1_2.MinimumSize = new System.Drawing.Size(130, 100);
            this.Btn_1_2.Name = "Btn_1_2";
            this.Btn_1_2.Size = new System.Drawing.Size(130, 100);
            this.Btn_1_2.TabIndex = 5;
            this.Btn_1_2.UseVisualStyleBackColor = false;
            this.Btn_1_2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_1_1
            // 
            this.Btn_1_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_1_1.BackColor = System.Drawing.Color.White;
            this.Btn_1_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_1_1.BackgroundImage")));
            this.Btn_1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_1_1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_1_1.Location = new System.Drawing.Point(174, 142);
            this.Btn_1_1.MinimumSize = new System.Drawing.Size(130, 100);
            this.Btn_1_1.Name = "Btn_1_1";
            this.Btn_1_1.Size = new System.Drawing.Size(130, 100);
            this.Btn_1_1.TabIndex = 4;
            this.Btn_1_1.UseVisualStyleBackColor = false;
            this.Btn_1_1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_1_0
            // 
            this.Btn_1_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_1_0.BackColor = System.Drawing.Color.White;
            this.Btn_1_0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_1_0.BackgroundImage")));
            this.Btn_1_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_1_0.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_1_0.Location = new System.Drawing.Point(39, 142);
            this.Btn_1_0.MinimumSize = new System.Drawing.Size(130, 100);
            this.Btn_1_0.Name = "Btn_1_0";
            this.Btn_1_0.Size = new System.Drawing.Size(130, 100);
            this.Btn_1_0.TabIndex = 3;
            this.Btn_1_0.UseVisualStyleBackColor = false;
            this.Btn_1_0.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_0_2
            // 
            this.Btn_0_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_0_2.BackColor = System.Drawing.Color.White;
            this.Btn_0_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_0_2.BackgroundImage")));
            this.Btn_0_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_0_2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_0_2.Location = new System.Drawing.Point(310, 36);
            this.Btn_0_2.MinimumSize = new System.Drawing.Size(130, 100);
            this.Btn_0_2.Name = "Btn_0_2";
            this.Btn_0_2.Size = new System.Drawing.Size(130, 100);
            this.Btn_0_2.TabIndex = 2;
            this.Btn_0_2.UseVisualStyleBackColor = false;
            this.Btn_0_2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // About_Label
            // 
            this.About_Label.AutoSize = true;
            this.About_Label.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About_Label.Location = new System.Drawing.Point(3, 13);
            this.About_Label.MaximumSize = new System.Drawing.Size(400, 600);
            this.About_Label.Name = "About_Label";
            this.About_Label.Size = new System.Drawing.Size(398, 165);
            this.About_Label.TabIndex = 0;
            this.About_Label.Text = resources.GetString("About_Label.Text");
            // 
            // ActionPanel
            // 
            this.ActionPanel.Controls.Add(this.Zero_Choose_Btn);
            this.ActionPanel.Controls.Add(this.Action_Label);
            this.ActionPanel.Controls.Add(this.Cross_Choose_Btn);
            this.ActionPanel.Location = new System.Drawing.Point(12, 17);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(273, 186);
            this.ActionPanel.TabIndex = 4;
            // 
            // ControllerPanel
            // 
            this.ControllerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ControllerPanel.Controls.Add(this.Stat_Btn);
            this.ControllerPanel.Controls.Add(this.HardDifficultBtn);
            this.ControllerPanel.Controls.Add(this.MediumDifficult_Btn);
            this.ControllerPanel.Controls.Add(this.EasyDifficult_Btn);
            this.ControllerPanel.Controls.Add(this.PlayAgain_Btn);
            this.ControllerPanel.Controls.Add(this.DifficultyLabel);
            this.ControllerPanel.Controls.Add(this.StyleBtn);
            this.ControllerPanel.Controls.Add(this.About_Btn);
            this.ControllerPanel.Controls.Add(this.Play_Btn);
            this.ControllerPanel.Location = new System.Drawing.Point(15, 209);
            this.ControllerPanel.Name = "ControllerPanel";
            this.ControllerPanel.Size = new System.Drawing.Size(270, 236);
            this.ControllerPanel.TabIndex = 5;
            // 
            // Stat_Btn
            // 
            this.Stat_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stat_Btn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stat_Btn.Location = new System.Drawing.Point(33, 171);
            this.Stat_Btn.Name = "Stat_Btn";
            this.Stat_Btn.Size = new System.Drawing.Size(194, 23);
            this.Stat_Btn.TabIndex = 12;
            this.Stat_Btn.Text = "Статистика";
            this.Stat_Btn.UseVisualStyleBackColor = true;
            this.Stat_Btn.Click += new System.EventHandler(this.Stat_Btn_Click);
            // 
            // HardDifficultBtn
            // 
            this.HardDifficultBtn.AutoSize = true;
            this.HardDifficultBtn.Location = new System.Drawing.Point(157, 57);
            this.HardDifficultBtn.Name = "HardDifficultBtn";
            this.HardDifficultBtn.Size = new System.Drawing.Size(64, 17);
            this.HardDifficultBtn.TabIndex = 11;
            this.HardDifficultBtn.Text = "Сложно";
            this.HardDifficultBtn.UseVisualStyleBackColor = true;
            this.HardDifficultBtn.CheckedChanged += new System.EventHandler(this.HardDifficultBtn_CheckedChanged);
            // 
            // MediumDifficult_Btn
            // 
            this.MediumDifficult_Btn.AutoSize = true;
            this.MediumDifficult_Btn.Location = new System.Drawing.Point(81, 57);
            this.MediumDifficult_Btn.Name = "MediumDifficult_Btn";
            this.MediumDifficult_Btn.Size = new System.Drawing.Size(62, 17);
            this.MediumDifficult_Btn.TabIndex = 10;
            this.MediumDifficult_Btn.Text = "Средне";
            this.MediumDifficult_Btn.UseVisualStyleBackColor = true;
            this.MediumDifficult_Btn.CheckedChanged += new System.EventHandler(this.MediumDifficult_Btn_CheckedChanged);
            // 
            // EasyDifficult_Btn
            // 
            this.EasyDifficult_Btn.AutoSize = true;
            this.EasyDifficult_Btn.Checked = true;
            this.EasyDifficult_Btn.Location = new System.Drawing.Point(19, 57);
            this.EasyDifficult_Btn.Name = "EasyDifficult_Btn";
            this.EasyDifficult_Btn.Size = new System.Drawing.Size(56, 17);
            this.EasyDifficult_Btn.TabIndex = 9;
            this.EasyDifficult_Btn.TabStop = true;
            this.EasyDifficult_Btn.Text = "Легко";
            this.EasyDifficult_Btn.UseVisualStyleBackColor = true;
            this.EasyDifficult_Btn.CheckedChanged += new System.EventHandler(this.EasyDifficult_Btn_CheckedChanged);
            // 
            // PlayAgain_Btn
            // 
            this.PlayAgain_Btn.Enabled = false;
            this.PlayAgain_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgain_Btn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain_Btn.Location = new System.Drawing.Point(33, 106);
            this.PlayAgain_Btn.Name = "PlayAgain_Btn";
            this.PlayAgain_Btn.Size = new System.Drawing.Size(194, 23);
            this.PlayAgain_Btn.TabIndex = 6;
            this.PlayAgain_Btn.Text = "Играть ещё раз";
            this.PlayAgain_Btn.UseVisualStyleBackColor = true;
            this.PlayAgain_Btn.Visible = false;
            this.PlayAgain_Btn.Click += new System.EventHandler(this.PlayAgain_Btn_Click);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyLabel.Location = new System.Drawing.Point(56, 22);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(109, 15);
            this.DifficultyLabel.TabIndex = 8;
            this.DifficultyLabel.Text = "Выбор сложности";
            // 
            // StyleBtn
            // 
            this.StyleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StyleBtn.Location = new System.Drawing.Point(33, 140);
            this.StyleBtn.Name = "StyleBtn";
            this.StyleBtn.Size = new System.Drawing.Size(194, 23);
            this.StyleBtn.TabIndex = 7;
            this.StyleBtn.Text = "Изменить цвета";
            this.StyleBtn.UseVisualStyleBackColor = true;
            this.StyleBtn.Click += new System.EventHandler(this.StyleBtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.Back_Btn);
            this.AboutPanel.Controls.Add(this.About_Label);
            this.AboutPanel.Location = new System.Drawing.Point(291, 9);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(440, 418);
            this.AboutPanel.TabIndex = 6;
            this.AboutPanel.Visible = false;
            // 
            // Back_Btn
            // 
            this.Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Btn.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Btn.Location = new System.Drawing.Point(288, 316);
            this.Back_Btn.Name = "Back_Btn";
            this.Back_Btn.Size = new System.Drawing.Size(140, 27);
            this.Back_Btn.TabIndex = 8;
            this.Back_Btn.Text = "Назад";
            this.Back_Btn.UseVisualStyleBackColor = true;
            this.Back_Btn.Click += new System.EventHandler(this.Back_Btn_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.Btn_2_2);
            this.GamePanel.Controls.Add(this.Btn_0_0);
            this.GamePanel.Controls.Add(this.Btn_0_1);
            this.GamePanel.Controls.Add(this.Btn_2_1);
            this.GamePanel.Controls.Add(this.Btn_0_2);
            this.GamePanel.Controls.Add(this.Btn_1_0);
            this.GamePanel.Controls.Add(this.Btn_2_0);
            this.GamePanel.Controls.Add(this.Btn_1_1);
            this.GamePanel.Controls.Add(this.Btn_1_2);
            this.GamePanel.Location = new System.Drawing.Point(294, 9);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(477, 373);
            this.GamePanel.TabIndex = 7;
            // 
            // StatPanel
            // 
            this.StatPanel.Controls.Add(this.BackStat_Btn);
            this.StatPanel.Controls.Add(this.HardLoseCount);
            this.StatPanel.Controls.Add(this.HardLoseLabel);
            this.StatPanel.Controls.Add(this.HardWinCount);
            this.StatPanel.Controls.Add(this.HardWinLabel);
            this.StatPanel.Controls.Add(this.HardLabel);
            this.StatPanel.Controls.Add(this.MediumLoseCount);
            this.StatPanel.Controls.Add(this.MediumLoseLabel);
            this.StatPanel.Controls.Add(this.MediumWinCount);
            this.StatPanel.Controls.Add(this.MediumWinLabel);
            this.StatPanel.Controls.Add(this.MediumLabel);
            this.StatPanel.Controls.Add(this.EasyLoseCount);
            this.StatPanel.Controls.Add(this.EasyLoseLabel);
            this.StatPanel.Controls.Add(this.EasyWinCount);
            this.StatPanel.Controls.Add(this.EasyWinLabel);
            this.StatPanel.Controls.Add(this.EasyLabel);
            this.StatPanel.Location = new System.Drawing.Point(291, 12);
            this.StatPanel.Name = "StatPanel";
            this.StatPanel.Size = new System.Drawing.Size(506, 418);
            this.StatPanel.TabIndex = 8;
            this.StatPanel.Visible = false;
            // 
            // BackStat_Btn
            // 
            this.BackStat_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackStat_Btn.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackStat_Btn.Location = new System.Drawing.Point(287, 371);
            this.BackStat_Btn.Name = "BackStat_Btn";
            this.BackStat_Btn.Size = new System.Drawing.Size(140, 24);
            this.BackStat_Btn.TabIndex = 15;
            this.BackStat_Btn.Text = "Назад";
            this.BackStat_Btn.UseVisualStyleBackColor = true;
            this.BackStat_Btn.Click += new System.EventHandler(this.BackStat_Btn_Click);
            // 
            // HardLoseCount
            // 
            this.HardLoseCount.AutoSize = true;
            this.HardLoseCount.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardLoseCount.Location = new System.Drawing.Point(198, 176);
            this.HardLoseCount.Name = "HardLoseCount";
            this.HardLoseCount.Size = new System.Drawing.Size(14, 16);
            this.HardLoseCount.TabIndex = 14;
            this.HardLoseCount.Text = "0";
            // 
            // HardLoseLabel
            // 
            this.HardLoseLabel.AutoSize = true;
            this.HardLoseLabel.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardLoseLabel.Location = new System.Drawing.Point(118, 176);
            this.HardLoseLabel.Name = "HardLoseLabel";
            this.HardLoseLabel.Size = new System.Drawing.Size(74, 16);
            this.HardLoseLabel.TabIndex = 13;
            this.HardLoseLabel.Text = "Поражений";
            // 
            // HardWinCount
            // 
            this.HardWinCount.AutoSize = true;
            this.HardWinCount.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardWinCount.Location = new System.Drawing.Point(57, 176);
            this.HardWinCount.Name = "HardWinCount";
            this.HardWinCount.Size = new System.Drawing.Size(14, 16);
            this.HardWinCount.TabIndex = 12;
            this.HardWinCount.Text = "0";
            // 
            // HardWinLabel
            // 
            this.HardWinLabel.AutoSize = true;
            this.HardWinLabel.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardWinLabel.Location = new System.Drawing.Point(6, 176);
            this.HardWinLabel.Name = "HardWinLabel";
            this.HardWinLabel.Size = new System.Drawing.Size(45, 16);
            this.HardWinLabel.TabIndex = 11;
            this.HardWinLabel.Text = "Побед";
            // 
            // HardLabel
            // 
            this.HardLabel.AutoSize = true;
            this.HardLabel.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardLabel.Location = new System.Drawing.Point(6, 145);
            this.HardLabel.Name = "HardLabel";
            this.HardLabel.Size = new System.Drawing.Size(182, 16);
            this.HardLabel.TabIndex = 10;
            this.HardLabel.Text = "Сложный уровень сложности";
            // 
            // MediumLoseCount
            // 
            this.MediumLoseCount.AutoSize = true;
            this.MediumLoseCount.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediumLoseCount.Location = new System.Drawing.Point(198, 114);
            this.MediumLoseCount.Name = "MediumLoseCount";
            this.MediumLoseCount.Size = new System.Drawing.Size(14, 16);
            this.MediumLoseCount.TabIndex = 9;
            this.MediumLoseCount.Text = "0";
            // 
            // MediumLoseLabel
            // 
            this.MediumLoseLabel.AutoSize = true;
            this.MediumLoseLabel.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediumLoseLabel.Location = new System.Drawing.Point(118, 114);
            this.MediumLoseLabel.Name = "MediumLoseLabel";
            this.MediumLoseLabel.Size = new System.Drawing.Size(74, 16);
            this.MediumLoseLabel.TabIndex = 8;
            this.MediumLoseLabel.Text = "Поражений";
            // 
            // MediumWinCount
            // 
            this.MediumWinCount.AutoSize = true;
            this.MediumWinCount.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediumWinCount.Location = new System.Drawing.Point(57, 114);
            this.MediumWinCount.Name = "MediumWinCount";
            this.MediumWinCount.Size = new System.Drawing.Size(14, 16);
            this.MediumWinCount.TabIndex = 7;
            this.MediumWinCount.Text = "0";
            // 
            // MediumWinLabel
            // 
            this.MediumWinLabel.AutoSize = true;
            this.MediumWinLabel.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediumWinLabel.Location = new System.Drawing.Point(6, 114);
            this.MediumWinLabel.Name = "MediumWinLabel";
            this.MediumWinLabel.Size = new System.Drawing.Size(45, 16);
            this.MediumWinLabel.TabIndex = 6;
            this.MediumWinLabel.Text = "Побед";
            // 
            // MediumLabel
            // 
            this.MediumLabel.AutoSize = true;
            this.MediumLabel.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediumLabel.Location = new System.Drawing.Point(6, 84);
            this.MediumLabel.Name = "MediumLabel";
            this.MediumLabel.Size = new System.Drawing.Size(179, 16);
            this.MediumLabel.TabIndex = 5;
            this.MediumLabel.Text = "Средний уровень сложности";
            // 
            // EasyLoseCount
            // 
            this.EasyLoseCount.AutoSize = true;
            this.EasyLoseCount.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyLoseCount.Location = new System.Drawing.Point(198, 52);
            this.EasyLoseCount.Name = "EasyLoseCount";
            this.EasyLoseCount.Size = new System.Drawing.Size(14, 16);
            this.EasyLoseCount.TabIndex = 4;
            this.EasyLoseCount.Text = "0";
            // 
            // EasyLoseLabel
            // 
            this.EasyLoseLabel.AutoSize = true;
            this.EasyLoseLabel.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyLoseLabel.Location = new System.Drawing.Point(118, 52);
            this.EasyLoseLabel.Name = "EasyLoseLabel";
            this.EasyLoseLabel.Size = new System.Drawing.Size(74, 16);
            this.EasyLoseLabel.TabIndex = 3;
            this.EasyLoseLabel.Text = "Поражений";
            // 
            // EasyWinCount
            // 
            this.EasyWinCount.AutoSize = true;
            this.EasyWinCount.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyWinCount.Location = new System.Drawing.Point(57, 52);
            this.EasyWinCount.Name = "EasyWinCount";
            this.EasyWinCount.Size = new System.Drawing.Size(14, 16);
            this.EasyWinCount.TabIndex = 2;
            this.EasyWinCount.Text = "0";
            // 
            // EasyWinLabel
            // 
            this.EasyWinLabel.AutoSize = true;
            this.EasyWinLabel.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyWinLabel.Location = new System.Drawing.Point(6, 52);
            this.EasyWinLabel.Name = "EasyWinLabel";
            this.EasyWinLabel.Size = new System.Drawing.Size(45, 16);
            this.EasyWinLabel.TabIndex = 1;
            this.EasyWinLabel.Text = "Побед";
            // 
            // EasyLabel
            // 
            this.EasyLabel.AutoSize = true;
            this.EasyLabel.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyLabel.Location = new System.Drawing.Point(6, 19);
            this.EasyLabel.Name = "EasyLabel";
            this.EasyLabel.Size = new System.Drawing.Size(168, 16);
            this.EasyLabel.TabIndex = 0;
            this.EasyLabel.Text = "Легкий уровень сложности";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.StatPanel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.AboutPanel);
            this.Controls.Add(this.ControllerPanel);
            this.Controls.Add(this.ActionPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 39);
            this.Name = "MainWindow";
            this.Text = "Крестики/Нолики";
            this.ActionPanel.ResumeLayout(false);
            this.ActionPanel.PerformLayout();
            this.ControllerPanel.ResumeLayout(false);
            this.ControllerPanel.PerformLayout();
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.StatPanel.ResumeLayout(false);
            this.StatPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Action_Label;
        private System.Windows.Forms.RadioButton Zero_Choose_Btn;
        private System.Windows.Forms.RadioButton Cross_Choose_Btn;
        private System.Windows.Forms.Button About_Btn;
        private System.Windows.Forms.Button Play_Btn;
        private System.Windows.Forms.Button Btn_2_2;
        private System.Windows.Forms.Button Btn_2_1;
        private System.Windows.Forms.Button Btn_2_0;
        private System.Windows.Forms.Button Btn_1_1;
        private System.Windows.Forms.Button Btn_1_0;
        private System.Windows.Forms.Label About_Label;
        private System.Windows.Forms.Button Btn_1_2;
        private System.Windows.Forms.Button Btn_0_2;
        private System.Windows.Forms.Button Btn_0_1;
        private System.Windows.Forms.Button Btn_0_0;
        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.Panel ControllerPanel;
        private System.Windows.Forms.Button PlayAgain_Btn;
        private System.Windows.Forms.RadioButton HardDifficultBtn;
        private System.Windows.Forms.RadioButton MediumDifficult_Btn;
        private System.Windows.Forms.RadioButton EasyDifficult_Btn;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Button StyleBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button Back_Btn;
        private System.Windows.Forms.Button Stat_Btn;
        private System.Windows.Forms.Panel StatPanel;
        private System.Windows.Forms.Label EasyLoseCount;
        private System.Windows.Forms.Label EasyLoseLabel;
        private System.Windows.Forms.Label EasyWinCount;
        private System.Windows.Forms.Label EasyWinLabel;
        private System.Windows.Forms.Label EasyLabel;
        private System.Windows.Forms.Label HardLoseCount;
        private System.Windows.Forms.Label HardLoseLabel;
        private System.Windows.Forms.Label HardWinCount;
        private System.Windows.Forms.Label HardWinLabel;
        private System.Windows.Forms.Label HardLabel;
        private System.Windows.Forms.Label MediumLoseCount;
        private System.Windows.Forms.Label MediumLoseLabel;
        private System.Windows.Forms.Label MediumWinCount;
        private System.Windows.Forms.Label MediumWinLabel;
        private System.Windows.Forms.Label MediumLabel;
        private System.Windows.Forms.Button BackStat_Btn;
    }
}

