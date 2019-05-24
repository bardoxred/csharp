using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private bool if_game_active;
        private int score = 0;
        private Snake snake;
        private Fruit fruit;

        public Form1()
        {
            InitializeComponent();
            if_game_active = false;
            timer1.Enabled = true;
            pauseToolStripMenuItem.Enabled = false;
            restartToolStripMenuItem.Enabled = false;
          
        }

        private void pauzaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (if_game_active)
            {
                field.CreateGraphics().Clear(Color.Green);
                snake.Move();
                snake.Draw(field.CreateGraphics(), new SolidBrush(Color.Black));
                fruit.draw_fruit(field.CreateGraphics(), new SolidBrush(Color.Red));
                if (fruit.if_eaten(snake.tail_X[0], snake.tail_Y[0]))
                {
                    try
                    {
                        snake.eat();
                        score = score + 10;
                        timer1.Interval -= 1;
                    }
                    catch
                    {
                        MessageBox.Show("Slow down!");
                    }
                   
                }
                if (snake.snake_alive() == false)
                {
                    if_game_active = false;
                    pauseToolStripMenuItem.Enabled = false;
                    gameSpeedToolStripMenuItem.Enabled = false;
                    MessageBox.Show("Your lose\nYour score: "+score);
                    score = 0;
                }
                
            } 
            else
            {
                FontFamily fontFamily = new FontFamily("Arial");
                Font font = new Font(fontFamily, 25);
                Brush font_color = new SolidBrush(Color.Black);
                //field.CreateGraphics().DrawString("Press Start", font, font_color, 40, 105);
            }
            
        }
        

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if_game_active = true;
            snake = new Snake(field.Width, field.Height);
            fruit = new Fruit(snake.tail);
            pauseToolStripMenuItem.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            restartToolStripMenuItem.Enabled = true;
        }

        private void field_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    snake.move = "up";
                }
                if (e.KeyCode == Keys.Down)
                {
                    snake.move = "down";
                }
                if (e.KeyCode == Keys.Left)
                {
                    snake.move = "left";
                }
                if (e.KeyCode == Keys.Right)
                {
                    snake.move = "right";
                }
               
                try
                {
                    if (e.KeyCode == Keys.Subtract)
                    {
                        timer1.Interval += 10;
                    }
                    if (e.KeyCode == Keys.Add)
                    {
                        timer1.Interval -= 10;
                    }
                }
                catch
                {
                    MessageBox.Show("Can't go faster!");
                }
                
            }
            catch
            {
                MessageBox.Show("Press Start");
            }
            
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if_game_active = true;
            snake = new Snake(field.Width, field.Height);
            fruit = new Fruit(snake.tail);

        }

        private void gameSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 150;
            
        }

        private void slowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (if_game_active)
            {
                if_game_active = false;
                pauseToolStripMenuItem.Text = "Resume";
                field.CreateGraphics().Clear(Color.Green);
            }
            else
            {
                if_game_active = true;
                pauseToolStripMenuItem.Text = "Pause";
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
        }
    }
}
