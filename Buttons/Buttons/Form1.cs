using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SetResult(string s)
        {
            ResultLabel.Visible = true;
            ResultLabel.Text = s;
        }
        public void SetInst(string s)
        {
            IndicationLabel.Visible = true;
            IndicationLabel.Text = s;
        }
        private void b1_Click(object sender, EventArgs e)
        {
            SetResult("Oua");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResultLabel.Visible = false;
            IndicationLabel.Visible = false;

        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            SetInst("In romana");
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            IndicationLabel.Visible = false;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            SetResult("Tojas");
        }

        private void b2_MouseEnter(object sender, EventArgs e)
        {
            SetInst("Magyarul");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            SetResult("Dick");
        }

        private void b3_MouseEnter(object sender, EventArgs e)
        {
            SetInst("In english");
        }

        private void b2_MouseLeave(object sender, EventArgs e)
        {
            IndicationLabel.Visible = false;
        }

        private void b3_MouseLeave(object sender, EventArgs e)
        {
            IndicationLabel.Visible = false;
        }
    }
}
