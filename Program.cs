using RecreateClass;
using PngToBinClass;
using System.Drawing;

List<List<PixelData>> pixels = PngToBin.Convert();

Recreate recreate = new Recreate();
recreate.Run(pixels);
