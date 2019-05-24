using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        public int tail; //one block of snake tail
        public int tail_size; // group of snake blocks
        public int[] tail_X = new int[100];
        public int[] tail_Y = new int[100];
        public string move;

        public Snake(int width, int height)
        {
            tail = width / 25;
            tail_size = 3;
            move = "down";
            int X = 12 * tail; //spawn point X
            int Y = 11 * tail; //spawn point Y
            for (int i = 0; i < tail_size; i++)
            {
                tail_X[i] = X - (i * tail);
                tail_Y[i] = Y;
            }
        }
        public void Move()
        {
            for(int i = tail_size; i > 0; i--)
            {
                tail_X[i] = tail_X[(i-1)];
                tail_Y[i] = tail_Y[(i-1)];
            }
            if (move == "left")
            {
                tail_X[0] = tail_X[0] - tail;
            }

            if (move == "right")
            {
                tail_X[0] = tail_X[0] + tail;
            }
            if (move == "up")
            {
                tail_Y[0] = tail_Y[0] - tail;
            }
            if (move == "down")
            {
                tail_Y[0] = tail_Y[0] + tail;
            }
            if (tail_X[0] < 0)
            {
                tail_X[0] = tail * 25;
            }
            if (tail_X[0] > tail * 25)
            {
                tail_X[0] = 0;
            }
            if (tail_Y[0] < 0)
            {
                tail_Y[0] = tail * 23;
            }
            if (tail_Y[0] > tail * 23)
            {
                tail_Y[0] = 0;
            }
        }
        public void eat()
        {
            tail_X[tail_size] = tail_X[tail_size + 1];
            tail_Y[tail_size] = tail_Y[tail_size + 1];
            tail_size = tail_size + 1;
        }
        public bool snake_alive()
        {
            for(int i=1; i < tail_size; i++)
            {
                if(tail_X[0]==tail_X[i] && tail_Y[0] == tail_Y[i])
                {
                    return false;
                }
            }
            return true;
        }
        public void Draw(Graphics graphics, Brush brush)
        {
            graphics.FillRectangle(new SolidBrush(Color.White), tail_X[0], tail_Y[0], tail, tail);
            for (int i = 1; i<tail_size; i++)
            {
                graphics.FillRectangle(brush, tail_X[i], tail_Y[i], tail, tail);
            }
        }
    }
}
