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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Action_Label = new System.Windows.Forms.Label();
            this.Play_Btn = new System.Windows.Forms.Button();
            this.About_Btn = new System.Windows.Forms.Button();
            this.Cross_Choose_Btn = new System.Windows.Forms.RadioButton();
            this.Zero_Choose_Btn = new System.Windows.Forms.RadioButton();
            this.Game_Controle = new System.Windows.Forms.TabControl();
            this.Game_Page = new System.Windows.Forms.TabPage();
            this.Btn_2_2 = new System.Windows.Forms.Button();
            this.Btn_2_1 = new System.Windows.Forms.Button();
            this.Btn_2_0 = new System.Windows.Forms.Button();
            this.Btn_0_0 = new System.Windows.Forms.Button();
            this.Btn_0_1 = new System.Windows.Forms.Button();
            this.Btn_1_2 = new System.Windows.Forms.Button();
            this.Btn_1_1 = new System.Windows.Forms.Button();
            this.Btn_1_0 = new System.Windows.Forms.Button();
            this.Btn_0_2 = new System.Windows.Forms.Button();
            this.About_Page = new System.Windows.Forms.TabPage();
            this.Back_Btn = new System.Windows.Forms.Button();
            this.About_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlayAgain_Btn = new System.Windows.Forms.Button();
            this.Game_Controle.SuspendLayout();
            this.Game_Page.SuspendLayout();
            this.About_Page.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Action_Label
            // 
            this.Action_Label.AutoSize = true;
            this.Action_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Action_Label.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Action_Label.Location = new System.Drawing.Point(59, 23);
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
            this.Play_Btn.Location = new System.Drawing.Point(33, 32);
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
            this.About_Btn.Location = new System.Drawing.Point(33, 92);
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
            this.Cross_Choose_Btn.Location = new System.Drawing.Point(36, 55);
            this.Cross_Choose_Btn.Name = "Cross_Choose_Btn";
            this.Cross_Choose_Btn.Size = new System.Drawing.Size(67, 18);
            this.Cross_Choose_Btn.TabIndex = 1;
            this.Cross_Choose_Btn.TabStop = true;
            this.Cross_Choose_Btn.Text = "Крестик";
            this.Cross_Choose_Btn.UseVisualStyleBackColor = true;
            this.Cross_Choose_Btn.CheckedChanged += new System.EventHandler(this.Cross_Choose_Btn_CheckedChanged);
            // 
            // Zero_Choose_Btn
            // 
            this.Zero_Choose_Btn.AutoSize = true;
            this.Zero_Choose_Btn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zero_Choose_Btn.Location = new System.Drawing.Point(133, 55);
            this.Zero_Choose_Btn.Name = "Zero_Choose_Btn";
            this.Zero_Choose_Btn.Size = new System.Drawing.Size(55, 18);
            this.Zero_Choose_Btn.TabIndex = 2;
            this.Zero_Choose_Btn.TabStop = true;
            this.Zero_Choose_Btn.Text = "Нолик";
            this.Zero_Choose_Btn.UseVisualStyleBackColor = true;
            this.Zero_Choose_Btn.CheckedChanged += new System.EventHandler(this.Zero_Choose_Btn_CheckedChanged);
            // 
            // Game_Controle
            // 
            this.Game_Controle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Game_Controle.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Game_Controle.Controls.Add(this.Game_Page);
            this.Game_Controle.Controls.Add(this.About_Page);
            this.Game_Controle.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Controle.ItemSize = new System.Drawing.Size(0, 1);
            this.Game_Controle.Location = new System.Drawing.Point(323, 12);
            this.Game_Controle.Margin = new System.Windows.Forms.Padding(0);
            this.Game_Controle.Name = "Game_Controle";
            this.Game_Controle.Padding = new System.Drawing.Point(0, 0);
            this.Game_Controle.SelectedIndex = 0;
            this.Game_Controle.Size = new System.Drawing.Size(449, 437);
            this.Game_Controle.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Game_Controle.TabIndex = 3;
            this.Game_Controle.TabStop = false;
            // 
            // Game_Page
            // 
            this.Game_Page.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Game_Page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Game_Page.Controls.Add(this.Btn_2_2);
            this.Game_Page.Controls.Add(this.Btn_2_1);
            this.Game_Page.Controls.Add(this.Btn_2_0);
            this.Game_Page.Controls.Add(this.Btn_0_0);
            this.Game_Page.Controls.Add(this.Btn_0_1);
            this.Game_Page.Controls.Add(this.Btn_1_2);
            this.Game_Page.Controls.Add(this.Btn_1_1);
            this.Game_Page.Controls.Add(this.Btn_1_0);
            this.Game_Page.Controls.Add(this.Btn_0_2);
            this.Game_Page.Location = new System.Drawing.Point(4, 5);
            this.Game_Page.Margin = new System.Windows.Forms.Padding(0);
            this.Game_Page.Name = "Game_Page";
            this.Game_Page.Size = new System.Drawing.Size(441, 428);
            this.Game_Page.TabIndex = 0;
            // 
            // Btn_2_2
            // 
            this.Btn_2_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_2_2.BackColor = System.Drawing.Color.White;
            this.Btn_2_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_2_2.BackgroundImage")));
            this.Btn_2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_2_2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_2_2.Location = new System.Drawing.Point(293, 249);
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
            this.Btn_2_1.Location = new System.Drawing.Point(159, 249);
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
            this.Btn_2_0.Location = new System.Drawing.Point(24, 249);
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
            this.Btn_0_0.Location = new System.Drawing.Point(24, 37);
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
            this.Btn_0_1.Location = new System.Drawing.Point(159, 37);
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
            this.Btn_1_2.Location = new System.Drawing.Point(293, 143);
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
            this.Btn_1_1.Location = new System.Drawing.Point(159, 143);
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
            this.Btn_1_0.Location = new System.Drawing.Point(24, 143);
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
            this.Btn_0_2.Location = new System.Drawing.Point(293, 37);
            this.Btn_0_2.MinimumSize = new System.Drawing.Size(130, 100);
            this.Btn_0_2.Name = "Btn_0_2";
            this.Btn_0_2.Size = new System.Drawing.Size(130, 100);
            this.Btn_0_2.TabIndex = 2;
            this.Btn_0_2.UseVisualStyleBackColor = false;
            this.Btn_0_2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // About_Page
            // 
            this.About_Page.BackColor = System.Drawing.Color.WhiteSmoke;
            this.About_Page.Controls.Add(this.Back_Btn);
            this.About_Page.Controls.Add(this.About_Label);
            this.About_Page.Location = new System.Drawing.Point(4, 5);
            this.About_Page.Margin = new System.Windows.Forms.Padding(0);
            this.About_Page.Name = "About_Page";
            this.About_Page.Size = new System.Drawing.Size(441, 428);
            this.About_Page.TabIndex = 1;
            // 
            // Back_Btn
            // 
            this.Back_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Btn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Btn.Location = new System.Drawing.Point(289, 375);
            this.Back_Btn.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Back_Btn.Name = "Back_Btn";
            this.Back_Btn.Size = new System.Drawing.Size(129, 35);
            this.Back_Btn.TabIndex = 1;
            this.Back_Btn.Text = "Назад";
            this.Back_Btn.UseVisualStyleBackColor = true;
            this.Back_Btn.Click += new System.EventHandler(this.Back_Btn_Click);
            // 
            // About_Label
            // 
            this.About_Label.AutoSize = true;
            this.About_Label.Location = new System.Drawing.Point(14, 12);
            this.About_Label.MaximumSize = new System.Drawing.Size(400, 600);
            this.About_Label.Name = "About_Label";
            this.About_Label.Size = new System.Drawing.Size(376, 84);
            this.About_Label.TabIndex = 0;
            this.About_Label.Text = resources.GetString("About_Label.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Zero_Choose_Btn);
            this.panel1.Controls.Add(this.Action_Label);
            this.panel1.Controls.Add(this.Cross_Choose_Btn);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 186);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.PlayAgain_Btn);
            this.panel2.Controls.Add(this.About_Btn);
            this.panel2.Controls.Add(this.Play_Btn);
            this.panel2.Location = new System.Drawing.Point(15, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 134);
            this.panel2.TabIndex = 5;
            // 
            // PlayAgain_Btn
            // 
            this.PlayAgain_Btn.Enabled = false;
            this.PlayAgain_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgain_Btn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain_Btn.Location = new System.Drawing.Point(33, 32);
            this.PlayAgain_Btn.Name = "PlayAgain_Btn";
            this.PlayAgain_Btn.Size = new System.Drawing.Size(194, 23);
            this.PlayAgain_Btn.TabIndex = 6;
            this.PlayAgain_Btn.Text = "Играть ещё раз";
            this.PlayAgain_Btn.UseVisualStyleBackColor = true;
            this.PlayAgain_Btn.Visible = false;
            this.PlayAgain_Btn.Click += new System.EventHandler(this.PlayAgain_Btn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Game_Controle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 39);
            this.Name = "MainWindow";
            this.Text = "Крестики/Нолики";
            this.Game_Controle.ResumeLayout(false);
            this.Game_Page.ResumeLayout(false);
            this.About_Page.ResumeLayout(false);
            this.About_Page.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Action_Label;
        private System.Windows.Forms.RadioButton Zero_Choose_Btn;
        private System.Windows.Forms.RadioButton Cross_Choose_Btn;
        private System.Windows.Forms.Button About_Btn;
        private System.Windows.Forms.Button Play_Btn;
        private System.Windows.Forms.TabControl Game_Controle;
        private System.Windows.Forms.TabPage Game_Page;
        private System.Windows.Forms.TabPage About_Page;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Back_Btn;
        private System.Windows.Forms.Button PlayAgain_Btn;
    }
}

