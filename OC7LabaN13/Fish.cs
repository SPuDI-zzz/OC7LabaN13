using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC7LabaN13
{
    public abstract class Fish
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Width { get; }
        public int Deep { get; }

        public Fish(int positionX, int positionY, int width, int deep)
        {
            PositionX = positionX;
            PositionY = positionY;
            Width = width;
            Deep = deep;
        }
        public void Swim(int distance, int direction)
        {
            if (direction == 1)//вверх 
            {
                if (PositionY - distance < 0)
                {
                    PositionY = Deep - PositionY - distance;
                    return;
                }
                PositionY -= distance;
                return;
            }
            if (direction == 2)//вправо
            {
                if (PositionX + distance > Width)
                {
                    PositionX = Width - PositionY + distance;
                    return;
                }
                PositionX += distance;
                return;
            }
            if (direction == 3)//вниз
            {
                if (PositionY + distance > Deep)
                {
                    PositionY = Deep - PositionY + distance;
                    return;
                }
                PositionY += distance;
                return;
            }
            if (direction == 4)//влево
            {
                if (PositionX - distance < 0)
                {
                    PositionX = Width - PositionX - distance;
                    return;
                }
                PositionX -= distance;
                return;
            }
        }
    }
}
