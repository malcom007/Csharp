using System;

namespace GalerieSGI
{
    class Program

    {
        struct Conservateur
        {
            private string nom;
            private double commission;

            private static int countConservateur;
            private string id;

            public string Id { get => id; set => id = value; }
            public string Nom { get => nom; set => nom = value; }
            public double Commission { get => commission; set => commission = value; }
            public static int CountConservateur { get => countConservateur; set => countConservateur = value; }

            public Conservateur(string nom, double commission) : this()
            {
                Nom = nom;
                Commission = commission;
                Id = "C"+(++countConservateur);

            }
        }

        struct Artiste
        {
            private string idConservateur;
            private static int countArtiste;
            private string iD;
            private string nom;

            public string ID { get => iD; set => iD = value; }
            public string Nom { get => nom; set => nom = value; }
            public string IdConservateur { get => idConservateur; set => idConservateur = value; }
            public static int CountArtiste { get => countArtiste; set => countArtiste = value; }

            public Artiste(string idConservateur, string nom ) : this()
            {
                IdConservateur = idConservateur;
                ID = "A"+(++countArtiste);
                Nom = nom;

            }
        }

        struct Oeuvre
        {
            private string etat;
            private double valeurEst;
            private string id;
            private string idArtiste;
            private string anneeAquis;
            private string titre;
            private double prixVente;

            private static int countOeuvre;

            public string Id { get => id; set => id = value; }
            public string IdArtiste { get => idArtiste; set => idArtiste = value; }
            public string AnneeAquis { get => anneeAquis; set => anneeAquis = value; }
            public string Titre { get => titre; set => titre = value; }
            public string Etat { get => etat; set => etat = value; }
            public double PrixVente { get => prixVente; set => prixVente = value; }
            public double ValeurEst { get => valeurEst; set => valeurEst = value; }
            public static int CountOeuvre { get => countOeuvre; set => countOeuvre = value; }

            public Oeuvre(string idArtiste, string anneeAquis, string titre, double prixVente, double valeurEst) : this()
            {
                Etat = "Exposé";
                ValeurEst = valeurEst;
                Id = "E"+(++CountOeuvre);
                IdArtiste = idArtiste;
                AnneeAquis = anneeAquis;
                Titre = titre;
                PrixVente = prixVente;

            }
        }




        delegate void DisplayMessage(string message);
        static string ReadInput = Console.ReadLine();

        static Conservateur[] tabConservateurs = new Conservateur[10];
        static Artiste[] tabArtistes = new Artiste[10];
        static Oeuvre[] tabOeuvres = new Oeuvre[10];

       



        /// <summary>
        /// Programme Principale
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            DisplayMessage afficher = Console.WriteLine;


            int choixUser; char reponse;
            bool monTest = true, resultRecherche;


            do
            {


                try
                {
                    choixUser = monMenu();

                    monProgramme(choixUser);

                    do
                    {
                        monTest = true;
                        afficher("Appuyez sur 0 pour Revenir au Menu!");
                        monTest = char.TryParse(Console.ReadLine(), out reponse);


                        if (monTest == false)
                        {
                            afficher("Pour quitter appuyer sur une touche de clavier autre que le ENTER!");

                        }

                    } while (!monTest);

                    //On revient au menu
                    if (reponse == '0')
                    {
                        monTest = false;
                    }
                    else 
                    { 
                        Console.WriteLine("Merci d'avoir utilisé ce programme");
                        monTest = true; 
                    }
                        
                }
                catch (tailleTableauAtteint ex)
                {
                    monTest = false;
                    Console.WriteLine(ex.Message);
                }
                catch(doubleException e)
                {
                    monTest = false;
                    afficher(e.Message);
                }
                catch (AucunAffichage)
                {
                    monTest = false;
                    afficher("Aucun élément a afficher ");
                }

                catch (Exception )
                {

                }








            } while (!monTest);
        }




        private static void monProgramme(int choixUser)
        {
            DisplayMessage afficher = Console.WriteLine;
            bool testChoix = true;
            

            switch (choixUser)
            {
                case 1:
                    afficher("\nAjout d'un conservateur");
                    afficher("--------------------------");

                    ajouterConservateur();

                    break;

                case 2:
                    afficher("\nAjout d'un Artiste");
                    afficher("--------------------------");

                    ajouterArtiste();

                    break;

                case 3:
                    afficher("\nAjout d'un Oeuvre");
                    afficher("--------------------------");

                    ajouterOeuvre();

                    break;

                case 4:
                    afficher("\nAfficher conservateurs");
                    afficher("--------------------------");

                    if (tabConservateurs[0].Id == null)
                    {
                        throw new AucunAffichage();
                    }

                    afficherConservateur();

                    break;

                case 5:
                    afficher("\nAfficher artistes");
                    afficher("--------------------------");

                    if (tabArtistes[0].ID == null)
                    {
                        throw new AucunAffichage();
                    }

                    afficherArtiste();

                    break;

                case 6:
                    afficher("\nAfficher oeuvres");
                    afficher("--------------------------");

                    if (tabOeuvres[0].Id == null)
                    {
                        throw new AucunAffichage();
                    }

                    afficherOeuvre();

                    break;



                default:
                    break;
            }



        }

        private static void afficherOeuvre()
        {
            Console.WriteLine("\n********Liste des oeuvres****");
            Console.WriteLine();



            Console.WriteLine();
            foreach (Oeuvre monOeuvre in tabOeuvres)
            {
                Console.WriteLine("\t" + monOeuvre.Id + "\t" + monOeuvre.Etat + "\t" + monOeuvre.Titre + "\t" + monOeuvre.ValeurEst + "\t" + monOeuvre.PrixVente + "\t" + monOeuvre.IdArtiste);
            }
        }

        private static void ajouterOeuvre()
        {
            DisplayMessage afficher = Console.WriteLine;



            int countOeuve = 0; string idArtsite, titre,anneeAquis; bool resultRecherche; char reponse;
            double prixVente, valeurEst;

            if (countOeuve > 10)
            {
                throw new tailleTableauAtteint("Taille max du tableau atteint, impossible d'ajouter");
            }

            if (tabArtistes[0].ID != null)
            {
                afficherArtiste();
            }

            do
            {

                Console.Write("Entrez l'id de l'artiste:  ");
                idArtsite = Console.ReadLine();
                Console.WriteLine();
                resultRecherche = RechercheArtiste(idArtsite);


                //Si l'id n'Est pas dans la table conservateur
                if (resultRecherche == false)
                {
                    Console.WriteLine("Aucun artiste !! \n ");

                    do
                    {
                        resultRecherche = true;
                        afficher("Appuyez sur 0 pour ajouter");
                        resultRecherche = char.TryParse(Console.ReadLine(), out reponse);
                        Console.WriteLine();

                        if (resultRecherche == false)
                        {
                            afficher("Entrez un caractère seulement");
                        }

                    } while (!resultRecherche);

                    if (reponse == '0')
                    {
                        Console.WriteLine();
                        ajouterArtiste();
                        afficherArtiste();
                        Console.WriteLine();
                        resultRecherche = false;
                    }

                }


            } while (!resultRecherche);



            Console.Write("Entrez le titre de l'oeuvre:  ");
            titre = Console.ReadLine();
            Console.Write("Entrez le l'année de l'oeuvre:  ");
            anneeAquis = Console.ReadLine();
            Console.Write("Entrez la valeur de l'oeuvre:  ");
            resultRecherche = double.TryParse(Console.ReadLine(), out valeurEst);

            if (!resultRecherche)
            {
                throw new doubleException("OUp!!!!!  Vous n'avez pas saisi des chiffre");
            }

            Console.Write("Entrez le prix de vente de l'oeuvre:  ");
            resultRecherche = double.TryParse(Console.ReadLine(), out prixVente);

            if (!resultRecherche)
            {
                throw new doubleException("OUp!!!!!  Vous n'avez pas saisi des chiffre");
            }


            tabOeuvres[countOeuve]= new Oeuvre(idArtsite, anneeAquis, titre, prixVente, valeurEst);

            countOeuve = Oeuvre.CountOeuvre;






        }

        private static void afficherArtiste()
        {
            Console.WriteLine("\n********Liste des artistes****");
            Console.WriteLine();

            Console.WriteLine();
            foreach (Artiste monArtiste in tabArtistes)
            {
                Console.WriteLine("\t" + monArtiste.ID + "\t" + monArtiste.Nom + "\t" + monArtiste.IdConservateur);
            }
        }

        private static bool RechercheArtiste(string idArtsite)
        {
            foreach (Artiste monArtiste in tabArtistes)
            {
                if (monArtiste.ID == (idArtsite))
                {
                    return true;
                }
            }
            return false;
        }

        private static void ajouterArtiste()
        {
            DisplayMessage afficher = Console.WriteLine;

            string nom = ""; char reponse; string idConservateur ; int countArtiste = 0; bool resultRecherche = true;

            if (countArtiste > 10)
            {
                throw new tailleTableauAtteint("Taille max du tableau atteint, impossible d'ajouter");
            }

            if (tabConservateurs[0].Id != null)
            {
                afficherConservateur();
            }

            do
            {

                Console.Write("Entrez l'id du conservateur:  ");
                idConservateur = Console.ReadLine();
                Console.WriteLine();
                resultRecherche = RechercheConservateur(idConservateur);


                //Si l'id n'Est pas dans la table conservateur
                if (resultRecherche == false)
                {
                    Console.WriteLine("Aucun conservateur !! \n ");
                    
                    do
                    {
                        resultRecherche = true;
                        afficher("Appuyez sur 0 pour ajouter");
                        resultRecherche = char.TryParse(Console.ReadLine(), out reponse);
                        Console.WriteLine();

                        if (resultRecherche==false)
                        {
                            afficher("Entrez un caractère seulement");
                        }

                    } while (!resultRecherche);

                    if (reponse=='0')
                    {
                        Console.WriteLine();
                        ajouterConservateur();
                        afficherConservateur();
                        Console.WriteLine();
                        resultRecherche = false;
                    }



                }


            } while (!resultRecherche);

                Console.Write("Entrez le nom de l'artiste:  ");
                nom = Console.ReadLine();


            tabArtistes[countArtiste] = new Artiste(idConservateur, nom);
            countArtiste = Artiste.CountArtiste;

            Console.WriteLine( "Artiste ajouté !!!!");

        }

        private static void afficherConservateur()
        {
            Console.WriteLine("\n********Liste des conservateur****");
            Console.WriteLine();


            foreach (Conservateur monConservateur in tabConservateurs)
            {
                Console.WriteLine("\t"+monConservateur.Id+"\t"+monConservateur.Nom+"\t"+monConservateur.Commission);
            }
        }

        private static bool RechercheConservateur(string idConservateur)
        {
            foreach (Conservateur monConservateur in tabConservateurs)
            {
                if (monConservateur.Id==(idConservateur))
                {
                    return true;
                }
            }
            return false;
        }

        public static void ajouterConservateur()
        {
            string nom="";
            double commission=0;
            int countConserv= 0;
            bool resultconversion=true;

            Console.WriteLine("\n********Ajout des conservateurs****\n");


            if (countConserv > 10)
                {
                    throw new tailleTableauAtteint("Taille max du tableau atteint, impossible d'ajouter");
                }

            Console.WriteLine("Entrez le nom du conservateur");
            nom = Console.ReadLine();
            Console.WriteLine("Entrez sa commission");
            resultconversion = double.TryParse(Console.ReadLine(), out commission);

            if (!resultconversion)
            {
                throw new doubleException("OUp!!!!!  Vous n'avez pas saisi des chiffre");
            }
            tabConservateurs[countConserv] = new Conservateur(nom, commission);
            countConserv = Conservateur.CountConservateur;





        }

        private static int monMenu()
        {
            DisplayMessage afficher = Console.WriteLine;
            int choix = 0;
            bool testChoix = true;


            do
            {
                Console.WriteLine();
                afficher("*******Galerie SGI********\n");

                afficher("1. Ajouter Conservateur");
                afficher("2. Ajouter Artiste");
                afficher("3. Ajouter Oeuvre");
                afficher("4. Afficher Conservateurs");
                afficher("5. Afficher Artistes");
                afficher("6. Afficher Ouvres");

                Console.Write("\nEntrez votre choix: ");

                try
                {
                    choix = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (choix != 1 && choix != 2 && choix != 3 && choix != 4 && choix != 5 && choix != 6)
                    {
                        //On leve une Exception si le mot de passe est invalide
                        throw new choixInvidException();
                    }
                    testChoix = true;
                }
                catch (choixInvidException)
                {
                    Console.WriteLine("OUps! choix entre 1-6");
                    Console.WriteLine();
                    testChoix = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nOUps! chiffre seulement");
                    Console.WriteLine();
                    testChoix = false;
                }

            } while (!testChoix);

            return choix;
        }
    }
}
