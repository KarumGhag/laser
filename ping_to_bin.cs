using System.Drawing;

namespace PngToBinClass;

public static class PngToBin
{
    public static List<List<PixelData>> Convert()
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

        return pixels;
    }
}

public class PixelData
{
    public int red;
    public int green;
    public int blue;
    public int x;
    public int y;

    public PixelData(int r, int g, int b, int x, int y)
    {
        red = r;
        green = g;
        blue = b;
        this.x = x;
        this.y = y;
    }
}
