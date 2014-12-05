using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoSerialisation
{
    [Serializable]
    class Truc
    {
        string nom;
        long numero;

        public Truc(string nom, long numero)
        {
            this.nom = nom;
            this.numero = numero;
        }

        public void Modifier()
        {
            numero += 1000;
        }

        public override string ToString()
        {
            return String.Format("{0} et {1}", nom, numero);
        }
    }

    [XmlType("Chose")]
    public class TrucXml
    {
        [XmlAttribute("Name")]
        public string nom;
        [XmlAttribute("Id")]
        public long numero;
        private DateTime naissance = DateTime.Now;

        public TrucXml()
        {
            naissance = new DateTime(2000, 1, 1);
        }

        public TrucXml(string nom, long numero)
        {
            this.nom = nom;
            this.numero = numero;
        }

        public void Modifier()
        {
            numero += 1000;
        }

        public override string ToString()
        {
            return String.Format("{0} et {1}", nom, numero);
        }
    }
}
