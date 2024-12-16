namespace Flappy_Bird_Windows_Form
{
    partial class DifficultySelect
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnExtreme;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnExtreme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(50, 50);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(200, 40);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(50, 100);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(200, 40);
            this.btnHard.TabIndex = 1;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.BtnHard_Click);
            // 
            // btnExtreme
            // 
            this.btnExtreme.Location = new System.Drawing.Point(50, 150);
            this.btnExtreme.Name = "btnExtreme";
            this.btnExtreme.Size = new System.Drawing.Size(200, 40);
            this.btnExtreme.TabIndex = 2;
            this.btnExtreme.Text = "Extreme";
            this.btnExtreme.UseVisualStyleBackColor = true;
            this.btnExtreme.Click += new System.EventHandler(this.BtnExtreme_Click);
            // 
            // DifficultySelect
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnExtreme);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnNormal);
            this.Name = "DifficultySelect";
            this.Text = "Select Difficulty";
            this.Load += new System.EventHandler(this.DifficultySelect_Load);
            this.ResumeLayout(false);
        }
    }
}