namespace LabCours3OminiPop
{
    internal class etudiant
    {
        private int idEtudiant, anneeNaissance;
        private string nomEtudiant, prenomEtudiant, mailEtudiant, userName;
        private static int countEtudiant;

        public etudiant(string nomEtudiant, string prenomEtudiant, int anneeNaissance, string mailEtudiant, string userName)
        {
            this.idEtudiant = countEtudiant++;
            this.anneeNaissance = anneeNaissance;
            this.nomEtudiant = nomEtudiant;
            this.prenomEtudiant = prenomEtudiant;
            this.mailEtudiant = mailEtudiant;
            this.userName = userName;
        }

        public string AfficherEtudiant()
        {
            return idEtudiant + " "
                + prenomEtudiant + " "
                + nomEtudiant + " "
                + anneeNaissance + " "
                + mailEtudiant +" "
                +userName +" ";
        }
    }
}