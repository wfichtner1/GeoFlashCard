using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFlashCard
{
    class Mineral
    {
        string Name;
        string Compound;
        Bitmap mineralImage;

        public Mineral(string name, string compound, Bitmap image)
        {
            Name = name;
            Compound = compound;
            mineralImage = image;
        }

    }
}
