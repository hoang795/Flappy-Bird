using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 6;
        int gravity = 10;
        int score = 0;
        int pipeGap = 150; // Default gap size for pipes

        private Button btnRestart;
        public string GameMode { get; private set; } // Game mode passed from MainMenu
        public string SelectedCharacter { get; private set; } // Nhân vật được chọn

        public Form1(string character, string mode)
        {
            // Add this try-catch block for debugging resource loading
            try
            {
                var resourceManager = new ResourceManager("Flappy_Bird_Windows_Form.Form1", Assembly.GetExecutingAssembly());
                var resourceValue = resourceManager.GetString("YourResourceKey"); // Replace with an actual key if available
            }
            catch (MissingManifestResourceException ex)
            {
                MessageBox.Show("Resource loading failed: " + ex.Message);
            }
            InitializeComponent();
            SelectedCharacter = character; // Lưu thông tin nhân vật
            GameMode = mode; // Lưu thông tin chế độ
            SetGameMode(GameMode);
            SetPipeDesign(GameMode);  // Thiết lập thiết kế ống theo chế độ game
            InitializeRestartButton(); // Initialize the restart button

            // Set up game timer
            gameTimer = new Timer();
            gameTimer.Interval = 20; // Game update interval
            gameTimer.Tick += new EventHandler(gameTimerEvent);
            gameTimer.Start(); // Start the game timer
        }

        private void InitializeRestartButton()
        {
            btnRestart = new Button
            {
                Location = new Point(350, 300),
                Name = "btnRestart",
                Size = new Size(100, 50),
                TabIndex = 0,
                Text = "Restart",
                UseVisualStyleBackColor = true,
                Visible = false // Initially hidden
            };
            btnRestart.Click += btnRestart_Click;
            Controls.Add(btnRestart);
        }
        private void CreatePipes()
        {
            flappyBird = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point(100, 200),
                BackColor = Color.Yellow
            };
            pipeTop = new PictureBox
            {
                Size = new Size(80, 200),
                Location = new Point(400, 0),
                BackColor = Color.Green
            };
            pipeBottom = new PictureBox
            {
                Size = new Size(80, 200),
                Location = new Point(400, 400),
                BackColor = Color.Green
            };
            ground = new PictureBox
            {
                Size = new Size(ClientSize.Width, 50),
                Location = new Point(0, ClientSize.Height - 50),
                BackColor = Color.Brown
            };
            scoreText = new Label
            {
                Text = "Score: 0",
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Controls.Add(flappyBird);
            Controls.Add(pipeTop);
            Controls.Add(pipeBottom);
            Controls.Add(ground);
            Controls.Add(scoreText);
        }
        private void SetGameMode(string mode)
        {
            // Adjust settings based on the selected game mode
            switch (mode)
            {
                case "Normal":
                    pipeSpeed = 6;
                    pipeGap = 150;
                    break;
                case "Hard":
                    pipeSpeed = 8;
                    pipeGap = 120;
                    break;
                case "Extreme":
                    pipeSpeed = 10;
                    pipeGap = 90;
                    break;
            }
        }
        private void SetPipeDesign(string mode)
        {
            Color pipeColor;

            switch (mode)
            {
                case "Hard":
                    pipeColor = Color.DarkGreen;
                    break;
                case "Extreme":
                    pipeColor = Color.Orange;
                    break;
                default:
                    pipeColor = Color.Green;
                    break;
            }

            pipeBottom.BackColor = pipeColor;
            pipeTop.BackColor = pipeColor;
        }
     
        
      

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;  // Move the bird up/down based on gravity
            pipeBottom.Left -= pipeSpeed;  // Move pipes left
            pipeTop.Left -= pipeSpeed;     // Move top pipe left

            // Create coin and check for collision

            // Update score display
            scoreText.Text = "Score: " + score;

            // Reset pipes when they move off-screen
            if (pipeBottom.Left < -pipeBottom.Width)
            {
                ResetPipes();  // Reposition pipes
                score++;  // Increase score when passing pipes
            }
            if (pipeTop.Left < -pipeTop.Width)
            {
                ResetPipes();  // Reposition pipes
                score++;  // Increase score when passing pipes
            }

            // End the game if the bird hits pipes or the ground
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            // Update game difficulty based on score milestones
            UpdateDifficulty();
        }

        private void ResetPipes()
        {
            // Reset pipe positions randomly
            pipeBottom.Left = ClientSize.Width;
            pipeBottom.Top = new Random().Next(pipeGap,ClientSize.Height - ground.Height);

            pipeTop.Left = ClientSize.Width;
            pipeTop.Top = pipeBottom.Top - pipeGap;
        }
        private void UpdateScore()
        {
            score++;
            scoreText.Text = "Score: " + score;
        }
    
      
        private void UpdateDifficulty()
        {
            // Increase difficulty based on score milestones
            if (score == 10)
            {
                pipeSpeed += 2;  // Increase pipe speed
            }
            else if (score == 20)
            {
                pipeGap -= 20;  // Decrease pipe gap
            }
            else if (score == 30)
            {
                pipeTop.Top += new Random().Next(-10, 10);  // Slight variation in pipe height
            }
            else if (score == 50)
            {
                this.BackColor = Color.LightBlue;  // Change background color for added challenge
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!";
            btnRestart.Visible = true; // Show the restart button

            // Ask the player if they want to return to the Main Menu
            DialogResult result = MessageBox.Show("Do you want to return to the Main Menu?", "Game Over", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the current game form
                MainMenu mainMenu = new MainMenu(); // Create an instance of the MainMenu form
                mainMenu.Show(); // Show the Main Menu
            }
            else
            {
                // Handle case if the player chooses "No" (e.g., exit or stay on the game over screen)
                Application.Exit(); // Exit the application (optional)
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Reset game variables
            score = 0;
            pipeSpeed = 6;
            gravity = 10;
            pipeGap = 150;

            // Reset bird and pipes positions
            flappyBird.Top = this.ClientSize.Height / 2;
            pipeBottom.Left = this.ClientSize.Width;
            pipeTop.Left = this.ClientSize.Width;
            pipeBottom.Top = new Random().Next(pipeGap, this.ClientSize.Height - ground.Height);
            pipeTop.Top = pipeBottom.Top - pipeGap;

            // Hide restart button and start the game again
            btnRestart.Visible = false;
            scoreText.Text = "Score: " + score;
            gameTimer.Start();
        }
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}