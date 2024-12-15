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

        }

        private void CharacterSelect_Load(object sender, EventArgs e)
        {
            // Initialize any dynamic content or setup logic here.
            MessageBox.Show(" Choose your character!");
        }
        private void Bird1_Click(object sender, EventArgs e)
        {
            OpenDifficultySelect("Bird1"); // Truyền thông tin nhân vật đã chọn
        }

        private void Bird2_Click(object sender, EventArgs e)
        {
            OpenDifficultySelect("Bird2"); // Truyền thông tin nhân vật đã chọn
        }

    }
}