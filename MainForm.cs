using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLFImageClassification
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            lblImagePath.Text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Pliki obrazów | *.jpg; *.jpeg; *.png";
            ofd.Title = "Wybierz plik obrazu";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = Path.GetFullPath(ofd.FileName);
                lblImagePath.Text = filePath;
            }
        }

        private void btnRunProcessing_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblImagePath.Text))
            {
                lblHelp.Text = "Przetwarzanie";
                panelResults.Visible = false;

                var bmp = (Bitmap)Image.FromFile(lblImagePath.Text);
                var img = new ImageProcessor(bmp);
                var primitives = img.FindPrimitives();
                var rlf = new RunLengthFeatures(primitives);
                lblShortPrimitiveEmphasis.Text = rlf.ShortPrimitiveEmphasis().ToString();
                lblLongPrimitiveEmphasis.Text = rlf.LongPrimitiveEmphasis().ToString();
                lblGrayLevelUniformity.Text = rlf.GrayLevelUniformity().ToString();
                lblPrimitiveLengthUniformity.Text = rlf.PrimitiveLengthUniformity().ToString();
                lblPrimitivePercentage.Text = rlf.PrimitivePercentage().ToString();

                panelResults.Visible = true;
                lblHelp.Text = "Zakończono przetwarzanie";
            }
        }
    }
}
