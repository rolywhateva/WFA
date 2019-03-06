using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desenare
{
    class DrawingEngine
    {
        private PictureBox box;
        private Bitmap map;
        private Graphics graphicsObj;
        public PictureBox Box
        {
            get { return box; }
        }
        public  Bitmap Map
        {
            get { return map; }

        }
        public SolidBrush SBrush
        {
            get;set;
        }
        public Pen P
        {
            get;set;
        }
        public  Graphics GraphicsObj
        {
            get { return graphicsObj; }
        }
    
        public DrawingEngine(PictureBox  box)
        {
            this.box = box;
            map = new Bitmap(box.Height, box.Width);
            graphicsObj = Graphics.FromImage(map);
           
        }
        public void Refresh()
        {
            box.Image = map;
        }

    }
}
