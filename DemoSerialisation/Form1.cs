using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace DemoSerialisation
{
    public partial class Form1 : Form
    {
        const string binData = @"C:\Users\Diego\Documents\GitHub\TPS_Technology_.NET\DemoSerialisation\Data.bin";
        const string xmlData = @"C:\Users\Diego\Documents\GitHub\TPS_Technology_.NET\DemoSerialisation\Data.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void SerializeBin_Click(object sender, EventArgs e)
        {
            var data = new[] {
                new Truc("Dupont",51),
                new Truc("Dupond",61),
                new Truc("Martin",71),
                new Truc("Nicolas",81)
            };

            var flux = new FileStream(binData, FileMode.Create, FileAccess.Write);

            var bf = new BinaryFormatter();

            data[0] = data[2];

            bf.Serialize(flux, data);

            flux.Close();
        }

        private void DeserializeBin_Click(object sender, EventArgs e)
        {
            var flux = new FileStream(binData, FileMode.Open, FileAccess.Read);

            var bf = new BinaryFormatter();

            var obj = (Truc[])bf.Deserialize(flux);

            obj[0].Modifier();

            flux.Close();

            Result.DataSource = obj;
        }

        private void SerializeXML_Click(object sender, EventArgs e)
        {
            var data = new[] {
                new TrucXml("Dupont",51),
                new TrucXml("Dupond",61),
                new TrucXml("Martin",71),
                new TrucXml("Nicolas",81)
            };

            var flux = new FileStream(xmlData, FileMode.Create, FileAccess.Write);

            var xs = new XmlSerializer(typeof(TrucXml[]));

            data[0] = data[2];

            xs.Serialize(flux, data);

            flux.Close();
        }

        private void DeserializeXML_Click(object sender, EventArgs e)
        {
            var flux = new FileStream(xmlData, FileMode.Open, FileAccess.Read);

            var xs = new XmlSerializer(typeof(TrucXml[]));
            var obj = (TrucXml[])xs.Deserialize(flux);

            obj[0].Modifier();

            flux.Close();
            Result.DataSource = obj;
        }
    }
}
