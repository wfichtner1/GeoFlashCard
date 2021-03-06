﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFlashCard
{
    class Mineral
    {
        //Fields
        private string Name;
        private string Compound;
        private Bitmap mineralImage;
        //Properties
        public string _Name
        {
            get
            {
                return Name;
            }
        }
        public string _Compound
        {
            get
            {
                return Compound;
            }
        }
        public Bitmap _mineralImage
        {
            get
            {
                return mineralImage;
            }
        }

        public Mineral(string name, string compound, Bitmap image)
        {
            Name = name;
            Compound = compound;
            mineralImage = image;
        }

    }
}
