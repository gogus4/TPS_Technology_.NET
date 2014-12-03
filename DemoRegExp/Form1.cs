using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoRegExp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Regex rxParams = new Regex(@"^\s*(?<cle>[a-zA-Z0-9_]{3,7})\s*=\s*(?<valeur>.+)$", RegexOptions.Multiline);

        private void ParseData(object sender, EventArgs e)
        {
            var data = File.ReadAllText(@"C:\Users\Diego\SkyDrive\Documents\ESGI_5\Technologie .NET\Travail\TPAL2\Tps\DemoRegExp\Parametres.txt");

            var matches = rxParams.Matches(data);

            foreach (Match m in matches)
            {
                var cle = m.Groups["cle"].Value;
                var valeur = m.Groups["valeur"].Value;

                Parameter.Items.Add(String.Format("{0} et {1}",cle,valeur));
            }
        }
    }
}
