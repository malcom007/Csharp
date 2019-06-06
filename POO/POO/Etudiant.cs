using System;
namespace POO
{
    public class Etudiant
    {
        private int numEtudiant;
        private string nom;

        public int m_umEtudiant
        {
            get
            {
                return numEtudiant;
            }

            set
            {
                numEtudiant = value;
            }
        }

        public string m_nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        //constructeur vide
        public Etudiant()
        {
        }

        //constructeur avec valeurs
        public Etudiant(int numEtudiant, string nom)
        {
            this.numEtudiant = numEtudiant;
            this.nom = nom;
        }

    }
}
