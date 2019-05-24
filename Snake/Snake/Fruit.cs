using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Fruit
    {
        public int x;
        public int y;
        public int snake;

        public void new_fruit()
        {
            Random random = new Random();
            x = random.Next(0, 20) * snake;
            y = random.Next(0, 20) * snake;

        }
        public Fruit(int snake)
        {
            this.snake = snake;
            new_fruit();
        }
        public bool if_eaten(int snake_X, int snake_Y)
        {
            if(x==snake_X && y == snake_Y)
            {
                new_fruit();
                return true;
            }
            return false;
        }
        public void draw_fruit(Graphics graphics, Brush brush)
        {
            graphics.FillRectangle(brush, x, y, snake, snake);
        }

    }
}
