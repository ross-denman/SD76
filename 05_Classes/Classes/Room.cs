using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Room
    {
        // Give this class properties of
        // Length, Width, Height, Surface Area, and Volume
        // Empty and full Constructor

        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double SurfaceArea
        {
            get
            {
                return 2 * (Length * Width + Length * Height + Width * Height);
            }
        }
        public double Volume
        {
            get
            {
                return Length * Width * Height;
            }
        }
        public Room() { }
        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
    }
}
