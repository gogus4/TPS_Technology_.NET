
namespace DemosDelegate
{
    class Bidon
    {
        string nom;

        public Bidon(string nom)
        {
            this.nom = nom;
        }

        public void Afficher(string message)
        {
            System.Console.WriteLine("Ici {0} message = {1}", nom, message);
        }
    }
}
