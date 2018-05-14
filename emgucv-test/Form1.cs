using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emgucv_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long matchTime;
            using (Mat modelImage = CvInvoke.Imread(@"opencv\data\sample\box.png", ImreadModes.Grayscale))
            using (Mat observedImage = CvInvoke.Imread(@"opencv\data\sample\box_in_scene.png", ImreadModes.Grayscale))
            {
                Mat result = DrawMatches.Draw(modelImage, observedImage, out matchTime);
                ImageViewer.Show(result, String.Format("Matched in {0} milliseconds", matchTime));
            }
        }
    }
}
