namespace Tic_Tac_Toe
{
    partial class StyleWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.StandartStyleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DarkStyleBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AnotherStyleBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стандартная цветовая схема";
            // 
            // StandartStyleBtn
            // 
            this.StandartStyleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StandartStyleBtn.Location = new System.Drawing.Point(12, 32);
            this.StandartStyleBtn.Name = "StandartStyleBtn";
            this.StandartStyleBtn.Size = new System.Drawing.Size(75, 23);
            this.StandartStyleBtn.TabIndex = 1;
            this.StandartStyleBtn.Text = "Применить";
            this.StandartStyleBtn.UseVisualStyleBackColor = true;
            this.StandartStyleBtn.Click += new System.EventHandler(this.StandartStyleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Темная цветовая схема";
            // 
            // DarkStyleBtn
            // 
            this.DarkStyleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DarkStyleBtn.Location = new System.Drawing.Point(12, 134);
            this.DarkStyleBtn.Name = "DarkStyleBtn";
            this.DarkStyleBtn.Size = new System.Drawing.Size(75, 23);
            this.DarkStyleBtn.TabIndex = 3;
            this.DarkStyleBtn.Text = "Применить";
            this.DarkStyleBtn.UseVisualStyleBackColor = true;
            this.DarkStyleBtn.Click += new System.EventHandler(this.DarkStyleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ещё одна цветовая схема";
            // 
            // AnotherStyleBtn
            // 
            this.AnotherStyleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnotherStyleBtn.Location = new System.Drawing.Point(12, 253);
            this.AnotherStyleBtn.Name = "AnotherStyleBtn";
            this.AnotherStyleBtn.Size = new System.Drawing.Size(75, 23);
            this.AnotherStyleBtn.TabIndex = 5;
            this.AnotherStyleBtn.Text = "Применить";
            this.AnotherStyleBtn.UseVisualStyleBackColor = true;
            this.AnotherStyleBtn.Click += new System.EventHandler(this.AnotherStyleBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Стандартная;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(189, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 96);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Темная;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(189, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 94);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Другая;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(189, 214);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 94);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // StyleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 328);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnotherStyleBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DarkStyleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StandartStyleBtn);
            this.Controls.Add(this.label1);
            this.Name = "StyleWindow";
            this.Text = "Настройки цветовой гаммы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StandartStyleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DarkStyleBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AnotherStyleBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}