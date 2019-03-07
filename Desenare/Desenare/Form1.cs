using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desenare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DrawingEngine drawing;
        Label[] lb;
        private void Form1_Load(object sender, EventArgs e)
        {
            drawing = new DrawingEngine(pictureBox);
            drawing.P = new Pen(Color.Black, 10);
            //desenare linie
            drawing.GraphicsObj.DrawLine(drawing.P, 100, 200, 300, 400);
           

            //desenare Polygon
            Point[] p = new Point[] { new Point(30, 50), new Point(60, 70), new Point(100, 23) };
            drawing.GraphicsObj.DrawPolygon(drawing.P, p);

            //desenare cerc??

            drawing.GraphicsObj.DrawEllipse(drawing.P, 345, 234, 50, 100);
            //umplere cerc

            SolidBrush sB = new SolidBrush(Color.LightGreen);
            drawing.GraphicsObj.FillEllipse(sB, 345, 234, 50, 100);
            //umplere polygon 

            drawing.GraphicsObj.FillPolygon(sB, p);

            drawing.GraphicsObj.DrawArc(drawing.P, 300, 400, 200, 300, -60, -30);

            drawing.GraphicsObj.DrawString("Sugi o ceapa", new Font(FontFamily.GenericSansSerif,15f), new SolidBrush(Color.Chocolate), 340, 200);
            drawing.GraphicsObj.DrawBezier(drawing.P, 30, 50, 100, 120,30, 170, 50, 230);

            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Azure);
            drawing.GraphicsObj.DrawEllipse(new Pen(Color.Azure), 300, 200, 400, 400);
            drawing.GraphicsObj.FillEllipse(hatchBrush, 300, 200, 400, 400);




            drawing.Refresh();


        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
