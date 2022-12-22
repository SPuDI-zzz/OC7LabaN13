using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC7LabaN13
{
    public interface IFish
    {
        int PositionX { get; set; }
        int PositionY { get; set; }
        int Width { get; }
        int Deep { get; }
        void Swim(int distance, int direction);
    }
}
