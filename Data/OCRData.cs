using System;
using System.Drawing;

namespace MyOCR.Data
{
    public class OCRData
    {
        public Rectangle Rect { get; set; }

        public int State { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
