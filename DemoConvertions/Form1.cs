using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConvertions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Type2String_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            Destination.Text = now.ToString("dddd dd MMMM yyyy hh:mm:ss.fff");
        }

        private void String2Type_Click(object sender, EventArgs e)
        {
            int n = 0;
            var converted = int.TryParse(Source.Text, out n);

            if (converted)
            {
                Destination.Text = n.ToString("X");
            }
        }
    }
}
