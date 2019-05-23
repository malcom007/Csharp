using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace LabCours3OminiPop
{
    class Program
    {
        static IList<etudiant> ListeEleves = new ArrayList<etudiant>();
        static etudiant monEtudiant ;
        private static string mailEtudiant;
        static Boolean _MonTest = false, monTestConertisseur;



        static void Main(string[] args)
        {

            int choixUser;

            
            do
            {
                Console.WriteLine("*******OMNIPOP-SOFTWA********");
                Console.WriteLine();
                try
                {
                    _MonTest = login();

                    if (_MonTest == false)
                    {
                        //On leve une Exception si le mot de passe est invalide
                        throw new invalidLogin();
                    }

                    Console.WriteLine("\nBienvenue \n");

                    //On stocke le choix de l'utilisateur
                    choixUser = AffichageMenu();

                    monProgramme(choixUser);


                }
                catch (invalidLogin)
                {
                    Console.WriteLine("Oups! Le mot passe ou le login est invalide ");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            } while (!_MonTest == true);


        }



        public static void monProgramme(int choixUser)
        {
            etudiant myStudent;

           
            _MonTest = true; monTestConertisseur = false;





            switch (choixUser)
            {


                case 1:
                    Console.WriteLine("\nAjout d'un étudiant");
                    Console.WriteLine("-----------------------\n");

                    ajoutEtudiant();
                    break;

                default:
                    break;
            }


    }

        /// <summary>
        /// Expression reguliere pour tester l'année
        /// Invalids the format annee.
        /// </summary>
        /// <returns><c>true</c>, if format annee was invalided, <c>false</c> otherwise.</returns>
        /// <param name="anneeNaissance">Annee naissance.</param>
        private static bool invalidFormatAnnee(int anneeNaissance)
        {
            const  string pattern = @"^[0-9]{4,4}$";
            string input = @""+anneeNaissance;

            RegexOptions options = RegexOptions.IgnoreCase;

            Match m = Regex.Match(input, pattern, options);

            //Si ca match parfaitement on retourne true
            if (!m.Success)
            {
                return false;

            }

            return true;
        }

        public static bool IsValidEmail(string mailEtudiant)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(mailEtudiant);
                return true;
            }
            catch
            {
                return false;

            }
        }

        /// <summary>
        /// We use the System.MailAddress class to check if an exception occurs when creating the e-mail to determine if it is a valid or not :
        /// Ises the valid email.
        /// </summary>
        /// <returns><c>true</c>, if valid email was ised, <c>false</c> otherwise.</returns>
        /// <param name="mailEtudiant">Mail etudiant.</param>



        private static void ajoutEtudiant()
        {
             string nomEtudiant=null, prenomEtudiant=null, userName=null;int anneeNaissance=0;

            //Saisi nom avec verificateur taille nom
            do
            {
                monTestConertisseur = true;
                try
                {
                    Console.Write("Nom de l'étudiant:  ");
                    nomEtudiant = Console.ReadLine();

                    Console.Write("Prenom de l'étudiant:  ");
                    prenomEtudiant = Console.ReadLine();

                    if (nomEtudiant.Length < 3 || prenomEtudiant.Length < 3)
                    {
                        throw new InvaldNameLength("Doit avoir plus de 2 lettre");
                    }


                }
                catch (InvaldNameLength ex)
                {
                    monTestConertisseur = false;
                    Console.WriteLine(ex.Message);
                }

            } while (!monTestConertisseur);

            //Année de naissance
            do
            {
                try
                {
                    Console.Write("Année de Naissance de l'étudiant:  ");
                    monTestConertisseur = Int32.TryParse(Console.ReadLine(), out anneeNaissance);

                    if (monTestConertisseur == false)
                    {

                        throw new anneeInvalides("Format d'année invalide, chiffre seulement");
                    }

                    invalidFormatAnnee(anneeNaissance);


                    if (!invalidFormatAnnee(anneeNaissance))
                    {
                        throw new anneNoMatch("L'année doit contenir 4 chiffres");
                    }



                }
                catch (anneeInvalides e)
                {
                    monTestConertisseur = false;
                    Console.WriteLine(e.Message);
                }
                catch (anneNoMatch e)
                {
                    monTestConertisseur = false;
                    Console.WriteLine(e.Message);
                }


            } while (!monTestConertisseur);

            //Création userName avec Substring
            userName = nomEtudiant.Substring(0, 3).ToUpper(new CultureInfo("en-US", false))
                       + (prenomEtudiant.Substring(0, 1).ToLower(new CultureInfo("en-US", false)))
                       + (prenomEtudiant.Substring(2, 2).ToUpper(new CultureInfo("en-US", false)))
                       + anneeNaissance;


            //Saisie mail
            do
            {
                try
                {
                    Console.Write("Mail de l'étudiant:  ");
                    mailEtudiant = Console.ReadLine();

                    monTestConertisseur = IsValidEmail(mailEtudiant);

                    if (monTestConertisseur == false)
                    {

                        throw new invalidMailFormat("Oups, le format de mail est invalid, veuillez ressayer");
                    }

                    monTestConertisseur = true;

                }
                catch (invalidMailFormat e)
                {
                    monTestConertisseur = false;
                    Console.WriteLine(e.Message);
                }

            } while (!monTestConertisseur);

            monEtudiant = new etudiant(nomEtudiant,prenomEtudiant,anneeNaissance,mailEtudiant,userName);
            ListeEleves.Add(monEtudiant);


            Console.WriteLine("**** Affichage etudiant ****");
            foreach (etudiant afficheEtudiant in ListeEleves)
            {
                Console.WriteLine(afficheEtudiant);
            }
        }

        /// <summary>
        /// Affichages du Menu et nous retourne le choix de l'utilisateur.
        /// </summary>
        /// <returns>The menu.</returns>
        private static int AffichageMenu()
        {
            int choix = 0;
            Boolean testChoix = true;


            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Entrez un nouveau étudiant");
                Console.WriteLine("2. Lister tout les étudiants");
                Console.WriteLine("3. Quittez le programme");
                Console.Write("\nEntrez votre choix: ");

                try
                {
                    choix = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (choix != 1 && choix != 2 && choix != 3)
                    {
                        //On leve une Exception si le mot de passe est invalide
                        throw new choixInvidException();
                    }
                    testChoix = true;
                }
                catch (choixInvidException)
                {
                    Console.WriteLine("OUps! Seulemt 1 ou 2 ou 3");
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

        /// <summary>
        /// Methode permettand de vérifier le login.
        /// </summary>
        /// <returns>The login.</returns>
        public static Boolean login()
        {
            Boolean testLogin = true;
            String user, psw;

            Console.WriteLine("Entre votre login");
            user = Console.ReadLine();

            Console.WriteLine("Entre votre mot de passe");
            psw = Console.ReadLine();

            if (user != "meriem" || psw != "1234")
            {
                return testLogin == false;
            }

            return testLogin;

        }
    }
}
