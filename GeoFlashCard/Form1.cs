using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoFlashCard
{
    public partial class TriviaForm : Form
    {
        Dictionary<(string, string), Bitmap> mineralDictionary = new Dictionary<(string, string), Bitmap>();
        public TriviaForm()
        {
            InitializeComponent();            
            Mineral handMineral = new Mineral("hand", "AlMgDe", GeoFlashCard.Properties.Resources.handImage);
            pictureBox1.Image = handMineral._mineralImage;
        }
    }
}
