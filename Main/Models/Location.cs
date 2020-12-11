using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Models
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Location(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void AddXCoordinate(int value)
        {
            this.X = this.X + value;
        }
        public void AddYCoordinate(int value)
        {
            this.Y = this.Y + value;
        }
    }
}
