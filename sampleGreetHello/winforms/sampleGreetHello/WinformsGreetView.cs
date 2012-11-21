using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using VariantMvc;
using GreetHello;
using System.Diagnostics;

namespace SampleGreetHello
{
    public partial class WinformsGreetView : Form, IView<Parts>, IGreetView
    {
        public event UpdateNotification FinishedSendingUpdates;
        public event UpdateNotification StartedSendingUpdates;


        IController<Parts> _ctrl;
        // this is the main.
        public WinformsGreetView()
        {
            // init view object
            this.Start();
            // call _view.start, which will call ctrl.Load and return.
            this._ctrl = (IController<Parts>)new GreetController(this);
            // then the normal event loop continues. 
            SetupUi();
            // any interaction runs a command

        }

        #region IView implementation

        public void RedrawPart(SimpleData<Parts> data)
        {
            switch (data.Part)
            {
                case Parts.Attitude:
                    drawAttitude((string)data.Data);
                    break;
                case Parts.Counter:
                    drawCounter((uint)data.Data);
                    break;
                case Parts.ShowMsg:
                    drawMsg((string)data.Data);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        void drawAttitude(string data)
        {
            this.attitudeLabel.Text = data;
        }

        void drawCounter(uint data)
        {
            string status = String.Format("greeted {0} times today.", data);
            this.toolStripStatusLabel1.Text = status;
        }

        void drawMsg(string data)
        {
            var str = data;
            MessageBox.Show(str);            
        }
        
        public void SetupUi()
        {
            InitializeComponent();
            this.Show();
        }

        public void RequestUpdate()
        {
            _ctrl.RequestReload();
        }

        public void Notify(string note)
        {
            throw new NotImplementedException();
        }

        public void DoExit()
        {
            Application.Exit();
        }

        public void Start()
        {
            this.SetupUi();
            this._ctrl.Load();            
        }

        public void RequestGreeting()
        {
            _ctrl.PerformAction("greet");
        }

        public void ShowErr(CommonData.Response resp)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void btnGreet_Click(object sender, EventArgs e)
        {
            RequestGreeting(); // notify ctrl
        }

        public void AdjustAttitude(uint tick)
        {
            _ctrl.PerformAction("adjust " + tick);
        }

        private void tbAttitudeAdjuster_ValueChanged(object sender, EventArgs e)
        {
            uint tick = (uint)tbAttitudeAdjuster.Value;
            AdjustAttitude(tick); // notify ctrl
        }

        int clip(int min, int max, int value)
        {
            int val = Math.Min(value, max);
            val = Math.Max(value, min);
            return val;
        }

// affects gui
        internal void adjustClipped(int value)
        { 
            int min = tbAttitudeAdjuster.Minimum;
            int max = tbAttitudeAdjuster.Maximum;

            tbAttitudeAdjuster.Value = clip(min, max, value);
        }
// affects gui
        internal void changeTicksCount(int ticks)
        {
            tbAttitudeAdjuster.Maximum = ticks;
        }

     

    }
}
