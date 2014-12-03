using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoStringBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DemoSansSB(object sender, EventArgs e)
        {
            var s = String.Empty;

            var nbInter = int.Parse(NbIterations.Text);
            var t1 = DateTime.Now;

            for (var n = 0; n < nbInter; n++)
            {
                s += ".";
            }

            var t2 = DateTime.Now;
            var delta = t2 - t1;

            duree.Text = String.Format("{0:F10} s", delta.TotalMilliseconds);
        }

        private void DemoAvecSB(object sender, EventArgs e)
        {
            var s = String.Empty;

            var sb = new StringBuilder();

            var nbInter = int.Parse(NbIterations.Text);
            var t1 = DateTime.Now;

            for (var n = 0; n < nbInter; n++)
            {
                sb.Append(".");
            }

            s = sb.ToString();
            var t2 = DateTime.Now;
            var delta = t2 - t1;

            duree.Text = String.Format("{0:F10} s", delta.TotalMilliseconds);
        }
    }
}
