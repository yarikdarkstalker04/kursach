using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizuliazatia
{
    public partial class Form1 : Form
    {
        int x, y, x1, y1, x2, y2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            y = Convert.ToInt32(ClientSize.Height/2-ClientSize.Height*0.2);
            x = Convert.ToInt32(ClientSize.Width / 2);
            y1 = Convert.ToInt32(ClientSize.Height/2+ClientSize.Height*0.1);
            x1 = Convert.ToInt32(ClientSize.Width / 2 - ClientSize.Width * 0.2);
            y2 = Convert.ToInt32(ClientSize.Height/2+ClientSize.Height*0.2);
            x2 = Convert.ToInt32(ClientSize.Width / 2 + ClientSize.Width * 0.1);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush solidBrush = new SolidBrush(Color.Purple);
            e.Graphics.FillEllipse(solidBrush, x, y, 100, 100);
            solidBrush = new SolidBrush(Color.Green);
            e.Graphics.FillEllipse(solidBrush, x1, y1, 100, 100);
            solidBrush = new SolidBrush(Color.Yellow);
            e.Graphics.FillEllipse(solidBrush, x2,y2, 100, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //x=  (x + 1) % 360;
            //y=  (y + 1) % 360;
            //x1= (x1 + 1) % 360;
            //y1= (y1 + 1) % 360;
            //x2= (x2 + 1) % 360;
            //y2= (y2 + 1) % 360;
            Invalidate();
        }
    }
}
