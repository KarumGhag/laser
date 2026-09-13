using System.Drawing;

namespace PngToBinClass;

public static class PngToBin
{
    public static void Convert()
    {
        Bitmap image = new Bitmap("photos/me.png");

        int width = image.Width;
        int height = image.Height;

        List<List<PixelData>> pixels = new List<List<PixelData>>();


        for (int i = 0; i < height; i++)
        {
            List<PixelData> horizontal = new List<PixelData>();

            for (int j = 0; j < width; j++)
            {
                Color rgb = image.GetPixel(j, i);
                horizontal.Add(new PixelData(rgb.R, rgb.G, rgb.B, j, i));
            }

            pixels.Add(horizontal);
        }
    }
}

public class PixelData
{
    int red;
    int green;
    int blue;

    public PixelData(int r, int g, int b, int x, int y)
    {
        this.red = r;
        this.green = g;
        this.blue = b;
    }
}
