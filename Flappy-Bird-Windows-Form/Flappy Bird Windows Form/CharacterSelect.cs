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
            // Gán text mặc định cho TextBox
            textBox1.Text = "Mode 1";
            textBox2.Text = "Mode 2";

            // Gắn sự kiện Click cho các TextBox
            textBox1.Click += TextBox1_Click;
            textBox2.Click += TextBox2_Click;
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            HandleModeSelection("Mode 1");
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            HandleModeSelection("Mode 2");
        }

        private void HandleModeSelection(string mode)
        {
            // Hiển thị thông báo
            MessageBox.Show($"You have chosen {mode}!");

            // Chuyển sang màn hình tiếp theo
            OpenDifficultySelect(mode);
        }

        private void OpenDifficultySelect(string mode)
        {
            // Mở màn hình tiếp theo và truyền thông tin chế độ
            DifficultySelect difficultySelectForm = new DifficultySelect(mode);
            difficultySelectForm.Show();
            this.Hide(); // Ẩn form hiện tại
        }
        private void Background3_Click(object sender, EventArgs e)
        {
            // Thêm logic xử lý tại đây
            MessageBox.Show("Background3 clicked!");
        }
    }
}