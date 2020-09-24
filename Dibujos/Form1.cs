using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dibujos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Red);
            Graphics formGraphics;
            formGraphics = panel1.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle(0, 0, 100, 200));
            myPen.Dispose();
            formGraphics.Dispose();

            Pen myPen1 = new Pen(Color.Red);
            Graphics formGraphics1;
            formGraphics1 = panel2.CreateGraphics();
            formGraphics1.DrawRectangle(myPen1, new Rectangle(0, 0, 100, 200));
            myPen1.Dispose();
            formGraphics1.Dispose();


            Graphics formGraphics2 = this.CreateGraphics();
            string drawString = "Texto de prueba";
            Font drawFont = new Font("Comic Sans", 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 490.0F;
            float y = 35.0F;
            StringFormat drawFormat = new StringFormat();
            formGraphics2.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();

        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            shape.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new System.Drawing.Region(shape);
        }

    }
}

