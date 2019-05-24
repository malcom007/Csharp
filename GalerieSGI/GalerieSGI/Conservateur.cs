namespace GalerieSGI
{
    internal class Conservateur
    {


        private static int CountConservateur;

        //Les accesseurs
        public string ID { get => ID; set => ID = value; }
        public string Nom { get => Nom; set => Nom = value; }
        public double Commission { get => Commission; set => Commission = value; }

        //Constructeur
        public Conservateur( string nom, double commission)
        {

            ID = ""+CountConservateur++;
            this.Nom = nom;
            this.Commission = commission;
        }

        public string afficherConservateur()
        {
            return ID + "\t" + Nom + "\t" + Commission;
        }



    }
}