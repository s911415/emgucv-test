using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace emgucv_test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
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
