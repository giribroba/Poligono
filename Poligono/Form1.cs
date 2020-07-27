using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poligono
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Bitmap papel = new Bitmap(Picture.Width, Picture.Height);
            Graphics desenhador = Graphics.FromImage(papel);

            DesenhaLinha(desenhador);

            Picture.BackgroundImage = papel;
        }

        private void DesenhaLinha(Graphics desenhador)
        {
            var Xi = int.Parse(Xibx.Text);
            var Xf = int.Parse(Xfbx.Text);
            var Yi = int.Parse(Yibx.Text);
            var Yf = int.Parse(Yfbx.Text);

            float dx = Xf - Xi;
            float dy = Yf - Yi;

            var steps = (Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy));

            float xInc = (float)(dx / steps);
            float yInc = (float)(dy / steps);

            float xTemp = 0;
            float yTemp = 0;

            var eX = 0;
            var eY = 0;

            for (int i = 0; i < steps; i++)
            {
                if (Math.Abs(Xi + xTemp - Math.Floor(Xi + xTemp)) != 0.5f)
                {
                    if (Math.Abs(Yi + yTemp - Math.Floor(Yi + yTemp)) != 0.5f)
                    {
                        DesenhaPixel((int)Math.Round(Xi + xTemp), (int)Math.Round(Yi + yTemp), desenhador);
                    }
                    else
                    {
                        DesenhaPixel((int)Math.Round(Xi + xTemp), (int)Math.Round(Yi + yTemp + (eY % 2 == 0 ? -0.5f : +0.5f)), desenhador);
                        eY++;
                    }
                }
                else
                {
                    if (Math.Abs(Yi + yTemp - Math.Floor(Yi + yTemp)) != 0.5f)
                    {
                        DesenhaPixel((int)Math.Round(Xi + xTemp + (eX % 2 == 0 ? -0.5f : +0.5f)), (int)Math.Round(Yi + yTemp), desenhador);
                    }
                    else
                    {
                        DesenhaPixel((int)Math.Round(Xi + xTemp + (eX % 2 == 0 ? -0.5f : +0.5f)), (int)Math.Round(Yi + yTemp + (eY % 2 == 0 ? -0.5f : +0.5f)), desenhador);
                        eY++;
                    }
                    eX++;
                }

                xTemp += xInc;
                yTemp += yInc;
            }
        }

        private void DesenhaPixel(int x, int y, Graphics desenhador)
        {
            var caneta = new Pen(Color.Black, 1);
            var pix = new Rectangle(Picture.Width / 2 + x, Picture.Height / 2 - y, 1, 1);

            desenhador.DrawRectangle(caneta, pix);
        }
    }
}
