using System;

namespace ExamenIntraGestionEtudiants
{
    class Program
    {
        struct Etudiant
        {
            private int idEtudiant;
            private string prenomEtudiant;
            private Cours[] cours = new Cours();
            private int nbreCours;
            private static int countEtudiant;
            private string nomEtudiant;

            public int IdEtudiant { get => idEtudiant; set => idEtudiant = value; }
            public string NomEtudiant { get => nomEtudiant; set => nomEtudiant = value; }
            public string PrenomEtudiant { get => prenomEtudiant; set => prenomEtudiant = value; }
            public Cours[] Cours { get => cours; set => cours = value; }
            public static int CountEtudiant { get => countEtudiant; set => countEtudiant = value; }
            public int NbreCours { get => nbreCours; set => nbreCours = value; }

            public Etudiant(string prenomEtudiant,  string nomEtudiant, Cours[] cours, int nbreCours) : this()
            {
                IdEtudiant = ++countEtudiant;
                PrenomEtudiant = prenomEtudiant;
                Cours = cours;
                NomEtudiant = nomEtudiant;
                NbreCours = nbreCours;
            }

            public void AfficherCours()
            {
                Console.WriteLine("\t-----Liste des cours------");

                foreach (Cours listeCour in cours)
                {
                    Console.WriteLine("\t"+listeCour.IdCour+" "+ listeCour.NomCour+" "+ listeCour.NbreHeureCour+" "+ listeCour.NoteEtudiant+" ");
                    
                }

            }

            public void AfficherCoursMoyenne()
            {
                Console.WriteLine("\t-----Liste des cours------");
                double moyenne = 0;
                foreach (Cours listeCour in cours)
                {
                    Console.WriteLine("\t" + listeCour.IdCour + " " + listeCour.NomCour + " " + listeCour.NbreHeureCour + " " + listeCour.NoteEtudiant + " ");
                    moyenne += listeCour.NoteEtudiant;
                }

                Console.WriteLine("t La moyenne de sa note " + moyenne / nbreCours);
            }

            public void AfficherCoursDetaille()
            {
                Console.WriteLine("\t-----Liste des cours------");
               
                foreach (Cours listeCour in cours)
                {
                    Console.WriteLine("\t" + listeCour.IdCour + " " + listeCour.NomCour + " " + listeCour.NbreHeureCour + " " + listeCour.NoteEtudiant + " ");
                   
                }


            }
        }

        struct Cours
        {
            private int idCour;
            private double noteEtudiant;
            private string nomCour;
            private static int countCours;
            private double nbreHeureCour;

            public int IdCour { get => idCour; set => idCour = value; }
            public double NbreHeureCour { get => nbreHeureCour; set => nbreHeureCour = value; }
            public double NoteEtudiant { get => noteEtudiant; set => noteEtudiant = value; }
            public string NomCour { get => nomCour; set => nomCour = value; }
            public static int CountCours { get => countCours; set => countCours = value; }

            public Cours(string nomCour,  double nbreHeureCour, double noteEtudiant) : this()
            {
                IdCour = ++countCours;
                NoteEtudiant = noteEtudiant;
                NomCour = nomCour;
                NbreHeureCour = nbreHeureCour;

            }


        }
        static bool monTest;
        static Etudiant[] tabEtudiant = new Etudiant[10];
        static void Main(string[] args)
        {
            int  countLogin=0;



            do
            {
                Console.WriteLine("**************** LOGIN ******************");
                Console.WriteLine();
                try
                {
                     monTest = login();
                    countLogin++;

                    if (monTest == false)
                    {
                        if (countLogin < 3)
                        {
                            //On leve une Exception si le mot de passe est invalide
                            throw new invalidLogin("");
                        }
                        else
                            throw new nombreTentativeAtteint();
                    }
                    //Changement couleur une fois connecté
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();

                    Console.WriteLine("\r\nBienvenue Meriem \n");
                    startProgram();


                }
                catch (invalidLogin)
                {
                    monTest = false;

                    Console.WriteLine("\nOups! Le mot passe ou le login est invalide. Veuillez reessayer\n ");
                }
                catch (nombreTentativeAtteint)
                {
                    monTest = true;
                    Console.WriteLine("\nNombre de tentative atteint! Veuillez contacter la direction\n");
                }
               
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            } while (!monTest == true );
        }



        private static void monProgramme(int choixUser)
        {


            switch (choixUser)
            {
                case 1:
                    Console.WriteLine ("\nAjout d'un étudiant");
                    Console.WriteLine("--------------------------");

                    ajouterEtudiant();
                    startProgram();

                    break;

                case 2:
                    Console.WriteLine("\nListe  des étudiants abrégé");
                    Console.WriteLine("-----------------------------");

                    if (Etudiant.CountEtudiant == 0)
                    {
                        Console.WriteLine("Aucun étudiant");
                        startProgram();
                    }
                    else
                    {
                        listeEtudiantsAbrege();

                    }
                    

                    break;

                case 3:
                    Console.WriteLine("\nListe  des étudiants détaillé");
                    Console.WriteLine("-------------------------------");

                    if (Etudiant.CountEtudiant == 0)
                    {
                        Console.WriteLine("Aucun étudiant");
                        startProgram();
                    }
                    else
                        listeEtudiantDetaille();

                    break;

                case 4:
                    Console.WriteLine("\nListe  des étudiants avec leurs moyennes");
                    Console.WriteLine("------------------------------------------");

                    if (Etudiant.CountEtudiant == 0)
                    {
                        Console.WriteLine("Aucun étudiant");
                        startProgram();
                    }
                    else
                        AffichageEtudiantMoyen();

                   

                    break;

                case 5:
                    Console.WriteLine("\nSuppression d'un étudiant");
                    Console.WriteLine("-----------------------------");



                    break;

                case 6:
                    Console.WriteLine("\nFermeture de programme");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("\nMerci d'avoir utiliser notre programme");

                    //if (tabOeuvres[0].Id == null)
                    //{
                    //    throw new AucunAffichage();
                    //}

                    //afficherOeuvre();

                    break;



                default:
                    break;
            }
        }

        private static void AffichageEtudiantMoyen()
        {
            foreach (Etudiant etudiant in tabEtudiant)
            {
                if (etudiant.IdEtudiant > 0)
                {
                    Console.WriteLine(etudiant.IdEtudiant + " " + etudiant.PrenomEtudiant + " " + etudiant.NomEtudiant + " ");
                    etudiant.AfficherCoursMoyenne();
                }
            }
            startProgram();
        }

        private static void listeEtudiantDetaille()
        {
            foreach (Etudiant etudiant in tabEtudiant)
            {
                if (etudiant.IdEtudiant>0)
                {
                    Console.WriteLine(etudiant.IdEtudiant + " " + etudiant.PrenomEtudiant + " " + etudiant.NomEtudiant + " ");
                    etudiant.AfficherCoursDetaille();
                }

            }
            startProgram();
        }

        private static void listeEtudiantsAbrege()
        {
            

            foreach (Etudiant etudiant in tabEtudiant)
            {

                    Console.WriteLine(etudiant.IdEtudiant + " " + etudiant.PrenomEtudiant + " " + etudiant.NomEtudiant + " ");




            }
            startProgram();
        }

        private static void ajouterEtudiant()
        {
            Cours[] tabCours;
            string nom="", prenom=""; double nombreHeureCour=0, moyenneNote=0, noteEtudiant=0;bool testConversion=true; int countEtudiant=0 , nbreCours;


            if (countEtudiant > 10)
            {
                Console.WriteLine("Nombre d'étudiant atteint");
                startProgram();
            }


            do
            {
                Console.WriteLine("Entrez le nombre de cours que l'étudiant souhaite être inscrit");
                testConversion = int.TryParse(Console.ReadLine(), out nbreCours);

                if (!testConversion || nbreCours <= 0 || nbreCours > 4)
                {

                    Console.WriteLine("\nEntrez un nombre compris 1-4\n");
                    testConversion = false;
                }
                tabCours = new Cours[nbreCours];
            } while (!testConversion);


            do
            {


                try
                {

                    Console.WriteLine("Prenom de l'étudiant");
                    prenom=Console.ReadLine();

                    Console.WriteLine("Nom de l'étudiant");
                    nom = Console.ReadLine();

                    for (int i = 0; i < nbreCours; i++)
                    {
                        testConversion = true;
                        do
                        {
                            Console.WriteLine("Nom du cour " + i);
                            tabCours[i].NomCour = Console.ReadLine();

                            Console.WriteLine("Nombre d'heure du cour " + i);
                            testConversion = double.TryParse(Console.ReadLine(), out nombreHeureCour);

                            if (!testConversion || nombreHeureCour<=0)
                            {
                                Console.WriteLine("Inscrire la note en format numérique, ce nombre doit etre superieur a 0 \n");
                                testConversion = false;
                            }

                            tabCours[i].NbreHeureCour = nombreHeureCour;

                            Console.WriteLine("Note du cour " + i);
                            testConversion = double.TryParse(Console.ReadLine(), out noteEtudiant);

                            if (!testConversion )
                            {
                                Console.WriteLine("Inscrire la note en format numérique\n");
                                testConversion = false;
                            }
                            tabCours[i].NoteEtudiant = noteEtudiant;
                            tabCours[i].IdCour = Cours.CountCours+1;

                        } while (!testConversion);
                       
                    }
                }
               
                catch (Exception ex)
                {
                    testConversion = false;
                }





            } while (!testConversion);

            Console.WriteLine("Count Cours "+Cours.CountCours);
            tabEtudiant[countEtudiant] = new Etudiant(prenom, nom, tabCours, nbreCours);
            countEtudiant = Etudiant.CountEtudiant;
            Console.WriteLine("L'étudiant {0} {1} a été inscrit !", prenom,nom);




        }

        /// <summary>
        /// Affichages the menu.
        /// Liste de Menu
        /// </summary>
        /// <returns>The menu.</returns>
        private static int AffichageMenu()
        {
            int choix = 0; bool testChoix;
            do
            {


                Console.WriteLine("\n**************** GESTION DU COLLEGE DE ROSE ******************\n");

                Console.WriteLine("\t\t Menu Principal");
                Console.WriteLine("\t\t -------------- \n");
                Console.WriteLine("1. Ajouter un nouvel étudiant");
                Console.WriteLine("2. Lister les étudiants format abrégé ");
                Console.WriteLine("3. Lister les étudiants format détaillé");
                Console.WriteLine("4. Lister les étudiants avec leurs moyennes");
                Console.WriteLine("5. Supprimer un étudiant");
                Console.WriteLine("6. Quitter l'application");
                Console.Write("\nEntrez votre choix: ");

                try
                {
                    choix = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (choix != 1 && choix != 2 && choix != 3 && choix != 4 && choix != 5 && choix != 6)
                    {
                        //On leve une Exception si le choix est invalide est invalide
                        throw new choixInvidException();
                    }
                    testChoix = true;
                }
                catch (choixInvidException)
                {
                    Console.WriteLine("\nOUps! mauvais choix, veuillez réessayer parmi ces choix (1,2,3,4,5,6)\n ");

                    testChoix = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nOUps! chiffre seulement\n");
                    testChoix = false;
                }

            } while (!testChoix);

            return choix;
        }

        private static void startProgram()
        {
            int choixUser;
            //On stocke le choix de l'utilisateur
            choixUser = AffichageMenu();

            monProgramme(choixUser);
        }

        /// <summary>
        /// Methode connexion user
        /// Login this instance.
        /// </summary>
        /// <returns>The login.</returns>
        private static bool login()
        {

            String user, psw, toLowerUser;

            Console.WriteLine("Entre votre login");
            user = Console.ReadLine();
            toLowerUser=user.ToLower();
            

            Console.WriteLine("Entre votre mot de passe");
            psw = Console.ReadLine();

            if (toLowerUser != "examen" || psw != "1234")
            {
                return false;
            }

            return true;
        }
    }
}
