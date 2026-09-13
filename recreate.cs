using Raylib_cs;
using PngToBinClass;

namespace RecreateClass;

public class Recreate
{
    public void Run(List<List<PixelData>> pixels)
    {
        Raylib.SetConfigFlags(ConfigFlags.UndecoratedWindow);
        Raylib.InitWindow(1920, 1080, "Recreate");
        Raylib.SetWindowPosition(0, 0);

        float scaleX = 1600f / 1920f;
        float scaleY = 900f / 1080f;

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.Black);

            int width = pixels[0].Count();
            int height = pixels.Count();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    PixelData pixel = pixels[i][j];
                    Color colour = new Color(pixel.red, pixel.green, pixel.blue, 255);

                    int newX = (int)(pixel.x * scaleX);
                    int newY = (int)(pixel.y * scaleY);


                    Raylib.DrawPixel(newX, newY, colour);
                }
            }

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
