using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoFlashCard
{
    public partial class TriviaForm : Form
    {
        List<Mineral> mineralList = new List<Mineral>();
        Random rand = new Random();
        
        public TriviaForm()
        {
            InitializeComponent();
            //Iterates through each member of the application resources class. Returned as property
            foreach(PropertyInfo property in typeof(Properties.Resources).GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
            {
                if (!(property.Name.Equals("ResourceManager") || property.Name.Equals("Culture")))
                {
                    Bitmap original = (Bitmap)property.GetValue(property.Name);
                    Bitmap resized = new Bitmap(original, new Size(600, 480));
                    mineralList.Add(new Mineral(property.Name, "test", resized));
                }                                    
            }

            pictureBox1.Image = mineralList[0]._mineralImage;
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            int index = rand.Next(0, mineralList.Count - 1);
            pictureBox1.Image = mineralList[index]._mineralImage;
        }
    }
}
