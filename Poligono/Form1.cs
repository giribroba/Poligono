using System;
using System.Collections.Generic;
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
            int raio = int.Parse(RaioBox.Text);
            int lados = int.Parse(LadosBox.Text);
            List<int[]> vertices = new List<int[]>();

            Bitmap papel = new Bitmap(Picture.Width, Picture.Height);
            Graphics desenhador = Graphics.FromImage(papel);

            double ang;
            for (int i = 0; i <= lados; i++)
            {
                ang = 2 * Math.PI * i / lados;

                vertices.Add(new int[] { (int)Math.Round(Math.Cos(ang) * raio), (int)Math.Round(Math.Sin(ang) * raio) });

                if (i > 0)
                {
                    DesenhaLinha(desenhador, vertices[i - 1], vertices[i]);
                }
            }

            Picture.BackgroundImage = papel;
        }

        private void DesenhaLinha(Graphics desenhador, int[] vertice1, int[] vertice2)
        {
            float dx = vertice2[0] - vertice1[0];
            float dy = vertice2[1] - vertice1[1];

            var steps = (Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy));

            float xInc = (float)(dx / steps);
            float yInc = (float)(dy / steps);

            float xTemp = 0;
            float yTemp = 0;

            var eX = 0;
            var eY = 0;

            for (int i = 0; i < steps; i++)
            {
                if (Math.Abs(vertice1[0] + xTemp - Math.Floor(vertice1[0] + xTemp)) != 0.5f)
                {
                    if (Math.Abs(vertice1[1] + yTemp - Math.Floor(vertice1[1] + yTemp)) != 0.5f)
                    {
                        DesenhaPixel((int)Math.Round(vertice1[0] + xTemp), (int)Math.Round(vertice1[1] + yTemp), desenhador);
                    }
                    else
                    {
                        DesenhaPixel((int)Math.Round(vertice1[0] + xTemp), (int)Math.Round(vertice1[1] + yTemp + (eY % 2 == 0 ? -0.5f : +0.5f)), desenhador);
                        eY++;
                    }
                }
                else
                {
                    if (Math.Abs(vertice1[1] + yTemp - Math.Floor(vertice1[1] + yTemp)) != 0.5f)
                    {
                        DesenhaPixel((int)Math.Round(vertice1[0] + xTemp + (eX % 2 == 0 ? -0.5f : +0.5f)), (int)Math.Round(vertice1[1] + yTemp), desenhador);
                    }
                    else
                    {
                        DesenhaPixel((int)Math.Round(vertice1[0] + xTemp + (eX % 2 == 0 ? -0.5f : +0.5f)), (int)Math.Round(vertice1[1] + yTemp + (eY % 2 == 0 ? -0.5f : +0.5f)), desenhador);
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
