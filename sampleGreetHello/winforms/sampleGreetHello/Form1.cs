using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace sampleGreetHello
{
    public partial class sampleGreetHello : Form
    {
        // IView _view = new 


        // this is the main.
        public sampleGreetHello()
        {
            InitializeComponent();
            this.Show();
            // this.changeTicksCount(40);
            
            // init ctrl, view objects
            // call _view.start, which will call ctrl.Load and return.
            // then the normal event loop continues. 
            // any interaction runs a command
            // controls get updated from view object.
            // i guess view needs the form object to do this.
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            // _view.requestGreeting();
        }

        int clip(int min, int max, int value)
        {
            int val = Math.Min(value, max);
            val = Math.Max(value, min);
            return val;
        }

        void adjustClipped(int value)
        { 
            int min = tbAttitudeAdjuster.Minimum;
            int max = tbAttitudeAdjuster.Maximum;

            tbAttitudeAdjuster.Value = clip(min, max, value);
        }

        void changeTicksCount(int ticks)
        {
            tbAttitudeAdjuster.Maximum = ticks;
        }

        private void tbAttitudeAdjuster_ValueChanged(object sender, EventArgs e)
        {
            int tick = tbAttitudeAdjuster.Value;
            //_view.adjustAttitude(tick);
        }

     

     

    }
}
