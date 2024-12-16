///DifficultySelect.cs

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class DifficultySelect : Form
    {
        private string selectedCharacter;

        public DifficultySelect(string character)
        {
            InitializeComponent();
            selectedCharacter = character;
            InitializeUI();
        }
        private Label lblSelectLevel; // Khai báo đối tượng Label

        private void InitializeUI()
        {
            lblSelectLevel = new Label();
            lblSelectLevel.Text = "Select the Level";  // Nội dung của Label
            lblSelectLevel.Location = new Point(50, 20);  // Vị trí của Label trên form
            lblSelectLevel.Size = new Size(200, 30);  // Kích thước của Label
            lblSelectLevel.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic); // Chỉnh font, kích thước và kiểu chữ
            this.Controls.Add(lblSelectLevel);  // Thêm Label vào form

            btnNormal = new Button();
            btnNormal.Text = "Normal";
            btnNormal.Location = new Point(50, 50);
            btnNormal.Click += BtnNormal_Click;

            btnHard = new Button();
            btnHard.Text = "Hard";
            btnHard.Location = new Point(50, 100);
            btnHard.Click += BtnHard_Click;

            btnExtreme = new Button();
            btnExtreme.Text = "Extreme";
            btnExtreme.Location = new Point(50, 150);
            btnExtreme.Click += BtnExtreme_Click;

            this.Controls.Add(btnNormal);
            this.Controls.Add(btnHard);
            this.Controls.Add(btnExtreme);

            if (selectedCharacter == "Mode 1")
            {
                this.BackColor = Color.LightBlue;
            }
            else if (selectedCharacter == "Mode 2")
            {
                this.BackColor = Color.DarkBlue;
            }
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected Normal difficulty.");
            OpenForm1("Normal");
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected Hard difficulty.");
            OpenForm1("Hard");
        }

        private void BtnExtreme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected Extreme difficulty.");
            OpenForm1("Extreme");
        }

        private void DifficultySelect_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Selected Character: {selectedCharacter}");
        }

        private void OpenForm1(string difficulty)
        {
            Form1 gameForm = new Form1(selectedCharacter, difficulty);
            gameForm.Show();
            this.Hide();
        }
    }
}