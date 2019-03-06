using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


            string tags = "ABC";
             lb = new Label[3];
            for(int i=0;i<p.Length;i++)
            {
                 lb[i] = new Label();
                lb[i].Text = tags[i].ToString();
                lb[i].BackColor = Color.White;
                lb[i].ForeColor = Color.Black;
                lb[i].Location = new Point(p[i].X - 20, p[i].Y);
                lb[i].Size = new Size(20, 30);
                lb[i].Font = new Font(FontFamily.GenericMonospace, 3);
                
                this.Controls.Add(lb[i]);
              
              
            }
            drawing.Refresh();


        }
    }
}
