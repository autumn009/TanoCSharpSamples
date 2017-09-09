using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main(string[] args)
    {
        var bm = Bitmap.FromFile(@"s:\sample.jpg");
        bm.RotateFlip(RotateFlipType.RotateNoneFlipX);
        bm.Save(@"s:\sample.png", ImageFormat.Png);
    }
}
