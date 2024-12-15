///DifficultySelect.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class DifficultySelect : Form
    {
        private Label label1;
        private Button button1;
        private Button button2;
        private string selectedCharacter;  // Khai báo biến để lưu trữ nhân vật đã chọn

        public DifficultySelect(string character)
        {
            InitializeComponent();
            selectedCharacter = character; // Lưu thông tin nhân vật
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DifficultySelect
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "DifficultySelect";
            this.Load += new System.EventHandler(this.DifficultySelect_Load);
            this.ResumeLayout(false);

        }

        private void DifficultySelect_Load(object sender, EventArgs e)
        {

        }
    }
}