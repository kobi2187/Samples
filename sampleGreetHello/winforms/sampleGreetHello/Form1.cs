using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sampleGreetHello
{
    public partial class sampleGreetHello : Form
    {
        // this is the main.
        public sampleGreetHello()
        {
            InitializeComponent();
            // init ctrl, view objects
            // call view.start, which will call ctrl.Load and return.
            // then the normal event loop continues. 
            // any interaction runs a command
            // controls get updated from view object.
            // i guess view needs the form object to do this.
        }

     

    }
}
