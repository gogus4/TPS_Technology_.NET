using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoData
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        const string cnxString = @"Data Source=GOGUS-PC\SQLEXPRESS;Initial Catalog=ESGIAL2;Integrated Security=True";
        const string filePath = @"C:\Users\Diego\Documents\GitHub\TPS_Technology_.NET\DemoData\data.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void ParProgramme_Click(object sender, EventArgs e)
        {
            var t = ds.Tables.Add("Data");

            var nom = t.Columns.Add("Nom", typeof(string));
            var numero = t.Columns.Add("Numero", typeof(int));
            var carre = t.Columns.Add("Carre", typeof(int), "Numero * Numero");

            for (var n = 0; n < 10; n++)
            {
                var ligne = t.NewRow();

                ligne[nom] = "toto " + n.ToString();
                ligne["Numero"] = n;

                t.Rows.Add(ligne);
            }

            MaGrille.DataSource = t;
        }

        private void ReadXML_Click(object sender, EventArgs e)
        {
            ds.ReadXml(filePath);
            MaGrille.DataSource = ds.Tables["Data"];
        }

        private void WriteXML_Click(object sender, EventArgs e)
        {
            ds.WriteXml(filePath);
        }

        private void ReadSQL_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection(cnxString);
            var cmd = new SqlCommand("SELECT Numero,Nom,Id FROM Demo", cnx);

            #region OBSOLETE
            /*cnx.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var nom = reader["Nom"]; 
                var numero = reader["Numero"];
                var id = reader["Id"];
            }
            cnx.Close();
            reader.Close();*/
            #endregion

            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            MaGrille.DataSource = ds.Tables[0];
        }

        private void WriteSQL_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection(cnxString);
            var cmd = new SqlCommand("SELECT Numero,Nom,Id FROM Demo", cnx);

            var adapter = new SqlDataAdapter(cmd);
            var bidon = new SqlCommandBuilder(adapter);

            adapter.Update(ds);
        }
    }
}