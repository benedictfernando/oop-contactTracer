using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_contactTracer
{
    public partial class tracer : Form
    {
        public tracer()
        {
            InitializeComponent();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
