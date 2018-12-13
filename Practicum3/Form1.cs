using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practicum3
{
    public partial class Hoofdscherm : Form
    {
        public Hoofdscherm()
        {
            InitializeComponent();
        }

        void tekenScherm(object sender, PaintEventArgs pea)
        {
            int x, y;
            int w = panel1.Width;
            int h = panel1.Height;

            Bitmap bm = new Bitmap(w, h);

            for (x = 0; x <= w; x += (w / 6))
                pea.Graphics.DrawLine(Pens.Blue, x, 0, x, h);
            for (y = 0; y <= h; y += (h / 6))
                pea.Graphics.DrawLine(Pens.Blue, 0, y, w, y);


        }
    }
}
