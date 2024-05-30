using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void intervalTrackBarControl1_Load(object sender, EventArgs e)
        {

            intervalTrackBarControl1.trackBarMax.Scroll += (Sender, E) =>
            {

                label1.Text = intervalTrackBarControl1.trackBarMin.Value + "-" + intervalTrackBarControl1.trackBarMax.Value;

            };


            intervalTrackBarControl1.trackBarMin.Scroll += (Sender, E) =>
            {

                label1.Text = intervalTrackBarControl1.trackBarMin.Value + "-" + intervalTrackBarControl1.trackBarMax.Value;

            };
        }
    }
}
