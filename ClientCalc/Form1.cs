using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCalc
{
    public partial class Form1 : Form
    {
        ICalcul calc = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            calc = (ICalcul)Activator.GetObject(typeof(ICalcul), URL.Text);
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            long a = long.Parse(VA.Text);
            long b = long.Parse(VB.Text);

            Resultat.Text = calc.Ajouter(a, b).ToString();
        }

        private void Multiplier_Click(object sender, EventArgs e)
        {
            double a = double.Parse(VA.Text);
            double b = double.Parse(VB.Text);

            Resultat.Text = calc.Multiplier(a, b).ToString();
        }
    }
}
