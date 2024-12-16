using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    partial class CharacterSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelect));
            this.Background4 = new System.Windows.Forms.PictureBox();
            this.Background3 = new System.Windows.Forms.PictureBox();
            this.Background1 = new System.Windows.Forms.PictureBox();
            this.Background2 = new System.Windows.Forms.PictureBox();
            this.Bird1 = new System.Windows.Forms.PictureBox();
            this.Bird2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Background4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird2)).BeginInit();
            this.SuspendLayout();
            // 
            // Background4
            // 
            this.Background4.Image = ((System.Drawing.Image)(resources.GetObject("Background4.Image")));
            this.Background4.Location = new System.Drawing.Point(689, 0);
            this.Background4.Margin = new System.Windows.Forms.Padding(4);
            this.Background4.Name = "Background4";
            this.Background4.Size = new System.Drawing.Size(385, 570);
            this.Background4.TabIndex = 1;
            this.Background4.TabStop = false;
            // 
            // Background3
            // 
            this.Background3.Image = ((System.Drawing.Image)(resources.GetObject("Background3.Image")));
            this.Background3.Location = new System.Drawing.Point(528, 0);
            this.Background3.Margin = new System.Windows.Forms.Padding(4);
            this.Background3.Name = "Background3";
            this.Background3.Size = new System.Drawing.Size(165, 570);
            this.Background3.TabIndex = 3;
            this.Background3.TabStop = false;
            this.Background3.Click += new System.EventHandler(this.Background3_Click);
            // 
            // Background1
            // 
            this.Background1.Image = ((System.Drawing.Image)(resources.GetObject("Background1.Image")));
            this.Background1.Location = new System.Drawing.Point(1, 0);
            this.Background1.Margin = new System.Windows.Forms.Padding(4);
            this.Background1.Name = "Background1";
            this.Background1.Size = new System.Drawing.Size(387, 570);
            this.Background1.TabIndex = 0;
            this.Background1.TabStop = false;
            // 
            // Background2
            // 
            this.Background2.Image = ((System.Drawing.Image)(resources.GetObject("Background2.Image")));
            this.Background2.Location = new System.Drawing.Point(352, 0);
            this.Background2.Margin = new System.Windows.Forms.Padding(4);
            this.Background2.Name = "Background2";
            this.Background2.Size = new System.Drawing.Size(192, 570);
            this.Background2.TabIndex = 2;
            this.Background2.TabStop = false;
            // 
            // Bird1
            // 
            this.Bird1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.Bird1.Image = ((System.Drawing.Image)(resources.GetObject("Bird1.Image")));
            this.Bird1.Location = new System.Drawing.Point(177, 252);
            this.Bird1.Margin = new System.Windows.Forms.Padding(4);
            this.Bird1.Name = "Bird1";
            this.Bird1.Size = new System.Drawing.Size(133, 62);
            this.Bird1.TabIndex = 4;
            this.Bird1.TabStop = false;
            // 
            // Bird2
            // 
            this.Bird2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(150)))));
            this.Bird2.Image = ((System.Drawing.Image)(resources.GetObject("Bird2.Image")));
            this.Bird2.Location = new System.Drawing.Point(812, 252);
            this.Bird2.Margin = new System.Windows.Forms.Padding(4);
            this.Bird2.Name = "Bird2";
            this.Bird2.Size = new System.Drawing.Size(133, 62);
            this.Bird2.TabIndex = 5;
            this.Bird2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 30);
            this.textBox1.ReadOnly = true; // Đặt chế độ chỉ đọc nếu không muốn cho phép người dùng chỉnh sửa
            this.textBox1.Text = "Mode 1";
            this.textBox1.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            this.textBox1.TextAlign = HorizontalAlignment.Center;

            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(750, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 30);
            this.textBox2.ReadOnly = true; // Đặt chế độ chỉ đọc
            this.textBox2.Text = "Mode 2";
            this.textBox2.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            this.textBox2.TextAlign = HorizontalAlignment.Center;

            // 
            // CharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Background2);
            this.Controls.Add(this.Bird2);
            this.Controls.Add(this.Bird1);
            this.Controls.Add(this.Background1);
            this.Controls.Add(this.Background4);
            this.Controls.Add(this.Background3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CharacterSelect";
            this.Text = "Select your character!!";
            this.Load += new System.EventHandler(this.CharacterSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Background4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Background4;
        private System.Windows.Forms.PictureBox Background3;
        private System.Windows.Forms.PictureBox Background1;
        private System.Windows.Forms.PictureBox Background2;
        private System.Windows.Forms.PictureBox Bird1;
        private System.Windows.Forms.PictureBox Bird2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}