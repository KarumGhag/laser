using System.Drawing;

namespace PngToBinClass;

public static class PngToBin
{
    public static void Convert()
    {
        Bitmap image = new Bitmap("photos/me.png");

        Color pixel = image.GetPixel(0, 0);

        Console.WriteLine(pixel.R);
        Console.WriteLine(pixel.G);
        Console.WriteLine(pixel.B);
    }
}
