using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary2
{
     [ToolboxBitmap(@"C:\Users\maksi\source\repos\Net_lab_1\WindowsFormsControlLibrary1\IntervalTrackBarControl.bmp")]
     // [ToolboxBitmap(typeof(IntervalTrackBarControl), "IntervalTrackBarControl.bmp")]
    // [ToolboxBitmap( "IntervalTrackBarControl.ico")]
    // [ToolboxBitmap(typeof(IntervalTrackBarControl), "WindowsFormsControlLibrary2.IntervalTrackBarControl.ico")]
    // [ToolboxBitmap(typeof(IntervalTrackBarControl), "Net_lab_1.WindowsFormsControlLibrary2.IntervalTrackBarControl.ico")]

   

    public partial class IntervalTrackBarControl : UserControl
    {
        public TrackBar trackBarMin;
        public TrackBar trackBarMax;

        public event EventHandler MinValueChanged;
        public event EventHandler MaxValueChanged;

        public int Minimum
        {
            get { return trackBarMin.Minimum; }
            set { trackBarMin.Minimum = value; }
        }

        public int Maximum
        {
            get { return trackBarMax.Maximum; }
            set { trackBarMax.Maximum = value; }
        }

        public int ValueMin
        {
            get { return trackBarMin.Value; }
            set { trackBarMin.Value = value; }
        }

        public int ValueMax
        {
            get { return trackBarMax.Value; }
            set { trackBarMax.Value = value; }
        }

        public IntervalTrackBarControl()
        {   
            Label l1 = new Label();
            l1.Text = "Min: 0";
            l1.Location = new Point(this.Location.X, 100);

            Label l2 = new Label();
            l2.Text = "Max: 100";
            l2.Location = new Point(this.Location.X, 0);


            trackBarMin = new TrackBar();
            trackBarMin.Minimum = 0;
            trackBarMin.Maximum = 100;
            trackBarMin.Value = 0;
         
            trackBarMin.Location = new Point(100, 100);

            trackBarMax = new TrackBar();     
            trackBarMax.Minimum = 0;
            trackBarMax.Maximum = 100;
            trackBarMax.Value = 100;
            trackBarMax.Location = new Point(100, 0);




            Controls.Add(l1);
            Controls.Add(l2);
            Controls.Add(trackBarMin);
            Controls.Add(trackBarMax);

            trackBarMin.Scroll += (sender, e) =>
            {
                
                if (trackBarMin.Value > trackBarMax.Value)
                {
                   
                    trackBarMin.Value = trackBarMax.Value;
                    return;
                }
                else
                {
                    l1.Text = "Min: " + trackBarMin.Value;
                }
                OnMinValueChanged(EventArgs.Empty);

            };

            trackBarMax.Scroll += (sender, e) =>
            {
               
                if (trackBarMax.Value < trackBarMin.Value)
                {
                  
                    trackBarMax.Value = trackBarMin.Value;
                    return;
                }
                else
                {
                    l2.Text = "Max: " + trackBarMax.Value;
                }

                OnMaxValueChanged(EventArgs.Empty);
            };



        }

        protected virtual void OnMinValueChanged(EventArgs e)
        {
            MinValueChanged?.Invoke(this, e);
        }

        protected virtual void OnMaxValueChanged(EventArgs e)
        {
            MaxValueChanged?.Invoke(this, e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
     
            trackBarMin.Width = this.Width / 2;
            trackBarMax.Width = this.Width / 2;
        }


    }


}
