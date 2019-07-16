using System;

namespace RoverEngine
{
    public class Plateau
    {
        public int[] size = { 0, 0 };
        public Plateau(int x, int y)
        {
             size[0] = x;
             size[1] = y;
        }
        public int[] Dimensions()
        {
             return size;
        }
    }
}
