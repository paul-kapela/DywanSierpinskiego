using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DywanSierpinskiego
{
    public partial class Form1 : Form
    {
        Color selectedColor = Color.Black;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public void Carpet(Graphics graphics, Color color, int level, RectangleF rectangle)
        {
            if (level == 0)
            {
                if (multiColorCheckBox.Checked == true)
                {
                    graphics.FillRectangle(new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))), rectangle);
                }
                else
                {
                    graphics.FillRectangle(new SolidBrush(color), rectangle);
                }
            }
            else
            {
                float width = rectangle.Width / 3f;
                float x0 = rectangle.Left;
                float x1 = x0 + width;
                float x2 = x0 + 2f * width;

                float height = rectangle.Height / 3f;
                float y0 = rectangle.Top;
                float y1 = y0 + height;
                float y2 = y0 + 2f * height;

                RectangleF[,] rectangles = new RectangleF[3, 3]
                {
                    { new RectangleF(x0, y0, width, height), new RectangleF(x1, y0, width, height), new RectangleF(x2, y0, width, height) },
                    { new RectangleF(x0, y1, width, height), new RectangleF(x1, y1, width, height), new RectangleF(x2, y1, width, height) },
                    { new RectangleF(x0, y2, width, height), new RectangleF(x1, y2, width, height), new RectangleF(x2, y2, width, height) }
                };

                Carpet(graphics, color, level - 1, rectangles[0, 0]);
                Carpet(graphics, color, level - 1, rectangles[1, 0]);
                Carpet(graphics, color, level - 1, rectangles[2, 0]);
                Carpet(graphics, color, level - 1, rectangles[0, 1]);
                Carpet(graphics, color, level - 1, rectangles[2, 1]);
                Carpet(graphics, color, level - 1, rectangles[0, 2]);
                Carpet(graphics, color, level - 1, rectangles[1, 2]);
                Carpet(graphics, color, level - 1, rectangles[2, 2]);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            carpetCanvas.Refresh();
            int o;
            if (int.TryParse(stepsTextBox.Text, out o) && (int.Parse(stepsTextBox.Text) > 0) && (int.Parse(stepsTextBox.Text) < 6))
            {
                Carpet(carpetCanvas.CreateGraphics(), selectedColor, int.Parse(stepsTextBox.Text), new RectangleF(0, 0, 500f, 500f));
            }
            else
            {
                MessageBox.Show("Liczba (koniecznie liczba!) kroków nie może być mniejsza od 1 i nie powinna (w tym przypadku) być większa od 5.", "Błąd");
            }
        }

        private void colorSelectButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
            }
        }
    }
}
