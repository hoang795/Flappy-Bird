using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class CharacterSelect : Form
    {
        public CharacterSelect()
        {
            InitializeComponent();
            textBox1.Click += PanelMode1_Click;
            textBox2.Click += PanelMode2_Click;

        }
        private void PanelMode1_Click(object sender, EventArgs e)
        {
            //Move to Mode 1 screen
            MessageBox.Show("You have chosen Mode 1");
            CharacterSelect mode1Form = new CharacterSelect();
            mode1Form.Show();
            this.Hide();

        }
        private void PanelMode2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have chosen Mode 2");
            CharacterSelect mode2Form = new CharacterSelect();
            mode2Form.Show();
            this.Hide();
        }

        private void CharacterSelect_Load(object sender, EventArgs e)
        {
            // Initialize any dynamic content or setup logic here.
            MessageBox.Show(" Choose the mode!");
        }
        private void Bird1_Click(object sender, EventArgs e)
        {
            OpenDifficultySelect("Bird1"); // Truyền thông tin nhân vật đã chọn
        }

        private void Bird2_Click(object sender, EventArgs e)
        {
            OpenDifficultySelect("Bird2"); // Truyền thông tin nhân vật đã chọn
        }

        private void OpenDifficultySelect(string selectedCharacter)
        {
            // Mở giao diện chọn độ khó và truyền nhân vật đã chọn
            DifficultySelect difficultyForm = new DifficultySelect(selectedCharacter);
            difficultyForm.Show();
            this.Hide();
        }

        private void Background2_Click(object sender, EventArgs e)
        {

        }

    }
}