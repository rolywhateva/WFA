using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Labels
{
    public partial class Labeluri : Form
    {
        public Labeluri()
        {
            InitializeComponent();
        }

        private void Labeluri_Load(object sender, EventArgs e)
        {
            MainLabel.Text = "Suck my dick, you little bitch.";
            MainLabel.TextAlign = ContentAlignment.MiddleCenter;
            MainLabel.Width = 300;
            MainLabel.Height = 400;
            MainLabel.Font = new Font(FontFamily.GenericMonospace,25f, FontStyle.Bold);
            Label lb = new Label();
            lb.Location = new Point(100, 200);
            lb.Text = "Cu pasiune";
            lb.Font = new Font(FontFamily.GenericSansSerif, 12f, FontStyle.Italic);
            Controls.Add(lb);


        }
    }
}
