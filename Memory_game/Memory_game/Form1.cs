using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_game
{
    public partial class Form1 : Form
    {
        bool[] buttons_have_color = new bool[17];
        Color[] colors = new Color[17];
        bool[] hidden = new bool[17];
        bool first_click = true;
        int moves = 0;
        int first_number = 0;
        int second_number = 0;

        private void random_button(Color color)
        {
            Random gen = new Random();
            int field_number = gen.Next(1, 17);
            while (buttons_have_color[field_number] == true)
            {
                field_number = gen.Next(1, 17);
            }
            buttons_have_color[field_number] = true;
            colors[field_number] = color;
        }

        private void print_button()
        {
            if (hidden[1] == false)
            { button1.BackColor = colors[1];}
            else { button1.BackColor = Color.Gray; }

            if (hidden[2] == false)
            { button2.BackColor = colors[2]; }
            else { button2.BackColor = Color.Gray; }

            if (hidden[3] == false)
            { button3.BackColor = colors[3]; }
            else { button3.BackColor = Color.Gray; }

            if (hidden[4] == false)
            { button4.BackColor = colors[4]; }
            else { button4.BackColor = Color.Gray; }

            if (hidden[5] == false)
            { button5.BackColor = colors[5]; }
            else { button5.BackColor = Color.Gray; }

            if (hidden[6] == false)
            { button6.BackColor = colors[6]; }
            else { button6.BackColor = Color.Gray; }

            if (hidden[7] == false)
            { button7.BackColor = colors[7]; }
            else { button7.BackColor = Color.Gray; }

            if (hidden[8] == false)
            { button8.BackColor = colors[8]; }
            else { button8.BackColor = Color.Gray; }

            if (hidden[9] == false)
            { button9.BackColor = colors[9]; }
            else { button9.BackColor = Color.Gray; }

            if (hidden[10] == false)
            { button10.BackColor = colors[10]; }
            else { button10.BackColor = Color.Gray; }

            if (hidden[11] == false)
            { button11.BackColor = colors[11]; }
            else { button11.BackColor = Color.Gray; }

            if (hidden[12] == false)
            { button12.BackColor = colors[12]; }
            else { button12.BackColor = Color.Gray; }

            if (hidden[13] == false)
            { button13.BackColor = colors[13]; }
            else { button13.BackColor = Color.Gray; }

            if (hidden[14] == false)
            { button14.BackColor = colors[14]; }
            else { button14.BackColor = Color.Gray; }

            if (hidden[15] == false)
            { button15.BackColor = colors[15]; }
            else { button15.BackColor = Color.Gray; }

            if (hidden[16] == false)
            { button16.BackColor = colors[16]; }
            else { button16.BackColor = Color.Gray; }
        }

        private void check()
        {
            moves = moves + 1;
            if (colors[first_number] == colors[second_number])
            {
  
                hidden[first_number] = false;
                hidden[second_number] = false;
            }
            else
            {
                MessageBox.Show("Try Again!");
            }
            int discovered = 0;
            for (int g = 1; g < 17; g++)
            {
                if (hidden[g] == false)
                {
                    discovered++;
                } 
            }
            if (discovered == 16)
            {
                MessageBox.Show("You won! You have discovered all! Number of moves: " + moves);
                Application.Restart();
            }
        }

        public Form1()
        {
            InitializeComponent();
            random_button(Color.Red);
            random_button(Color.Red);
            random_button(Color.Blue);
            random_button(Color.Blue);
            random_button(Color.Green);
            random_button(Color.Green);
            random_button(Color.Yellow);
            random_button(Color.Yellow);
            random_button(Color.Purple);
            random_button(Color.Purple);
            random_button(Color.White);
            random_button(Color.White);
            random_button(Color.Black);
            random_button(Color.Black);
            random_button(Color.Khaki);
            random_button(Color.Khaki);

            for(int i = 1; i < 17; i++)
            {
                hidden[i] = true;
            }
            print_button();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[1])
            {
                button1.BackColor = colors[1];
                if (first_click == true)
                {
                    first_number = 1;
                    first_click = false;
                }
                else
                {
                    second_number = 1;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor != colors[2])
            {
                button2.BackColor = colors[2];
                if (first_click == true)
                {
                    first_number = 2;
                    first_click = false;
                }
                else
                {
                    second_number = 2;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor != colors[3])
            {
                button3.BackColor = colors[3];
                if (first_click == true)
                {
                    first_number = 3;
                    first_click = false;
                }
                else
                {
                    second_number = 3;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor != colors[4])
            {
                button4.BackColor = colors[4];
                if (first_click == true)
                {
                    first_number = 4;
                    first_click = false;
                }
                else
                {
                    second_number = 4;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor != colors[5])
            {
                button5.BackColor = colors[5];
                if (first_click == true)
                {
                    first_number = 5;
                    first_click = false;
                }
                else
                {
                    second_number = 5;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor != colors[6])
            {
                button6.BackColor = colors[6];
                if (first_click == true)
                {
                    first_number = 6;
                    first_click = false;
                }
                else
                {
                    second_number = 6;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor != colors[7])
            {
                button7.BackColor = colors[7];
                if (first_click == true)
                {
                    first_number = 7;
                    first_click = false;
                }
                else
                {
                    second_number = 7;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor != colors[8])
            {
                button8.BackColor = colors[8];
                if (first_click == true)
                {
                    first_number = 8;
                    first_click = false;
                }
                else
                {
                    second_number = 8;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor != colors[9])
            {
                button9.BackColor = colors[9];
                if (first_click == true)
                {
                    first_number = 9;
                    first_click = false;
                }
                else
                {
                    second_number = 9;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor != colors[10])
            {
                button10.BackColor = colors[10];
                if (first_click == true)
                {
                    first_number = 10;
                    first_click = false;
                }
                else
                {
                    second_number = 10;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor != colors[11])
            {
                button11.BackColor = colors[11];
                if (first_click == true)
                {
                    first_number = 11;
                    first_click = false;
                }
                else
                {
                    second_number = 11;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor != colors[12])
            {
                button12.BackColor = colors[12];
                if (first_click == true)
                {
                    first_number = 12;
                    first_click = false;
                }
                else
                {
                    second_number = 12;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor != colors[13])
            {
                button13.BackColor = colors[13];
                if (first_click == true)
                {
                    first_number = 13;
                    first_click = false;
                }
                else
                {
                    second_number = 13;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor != colors[14])
            {
                button14.BackColor = colors[14];
                if (first_click == true)
                {
                    first_number = 14;
                    first_click = false;
                }
                else
                {
                    second_number = 14;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor != colors[15])
            {
                button15.BackColor = colors[15];
                if (first_click == true)
                {
                    first_number = 15;
                    first_click = false;
                }
                else
                {
                    second_number = 15;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor != colors[16])
            {
                button16.BackColor = colors[16];
                if (first_click == true)
                {
                    first_number = 16;
                    first_click = false;
                }
                else
                {
                    second_number = 16;
                    first_click = true;
                    check();
                    print_button();
                }
            }
        }
    }
}
