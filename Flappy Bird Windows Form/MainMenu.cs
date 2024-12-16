using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            button1.Text = "Play";

            label1.Text = "Flappy Bird";
            label1.Font = new Font("Wendy One", 28, FontStyle.Bold);
            label1.ForeColor = Color.ForestGreen;
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.BackColor = Color.Transparent;
            label2.Text = "Get Ready!";
            label2.Font = new Font("Kumbh Sans", 16, FontStyle.Bold);
            label2.ForeColor = Color.YellowGreen;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.BackColor = Color.Transparent;

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PictureBox4 clicked!");
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Initialize any dynamic content or setup logic here.
            MessageBox.Show("Main Menu Loaded!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenCharacterSelect();
        }

        private void OpenCharacterSelect()
        {
            // Mở màn hình CharacterSelect
            CharacterSelect characterSelectForm = new CharacterSelect();
            characterSelectForm.Show();
            this.Hide(); // Ẩn MainMenu
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}