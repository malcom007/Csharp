using System;

namespace LabCours3OminiPop
{
    class Program
    {

        static void Main(string[] args)
        {
            Boolean _MonTest = false;
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
                    choixUser=AffichageMenu();

                    monProgramme(choixUser);


                }
                catch (invalidLogin)
                {
                    Console.WriteLine("Oups! Le mot passe ou le login est invalide ");
                }


            } while (!_MonTest==true);


        }



        private static void monProgramme(int choixUser)
        {
            arrayList ListeEleve = new arrayList();




            switch (choixUser)
            {
                case 1:
                    Console.WriteLine("\nAjout d'un étudiant");
                    Console.WriteLine("-----------------------\n");



                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Affichages du Menu et nous retourne le choix de l'utilisateur.
        /// </summary>
        /// <returns>The menu.</returns>
        private static int AffichageMenu()
        {
            int choix=0;
            Boolean testChoix=true;


            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Entrez un nouveau étudiant");
                Console.WriteLine("2. Lister tout les étudiants");
                Console.WriteLine("3. Quittez le programme");
                Console.Write("\nEntrez votre choix: ");

                try
                {
                    choix= int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (choix!=1 && choix!=2 && choix!=3)
                    {
                        //On leve une Exception si le mot de passe est invalide
                        throw new choixInvidException();
                    }
                    testChoix = true;
                }
                catch (choixInvidException )
                {
                    Console.WriteLine("OUps! Seulemt 1 ou 2 ou 3");
                    Console.WriteLine();
                    testChoix = false;
                }catch(Exception)
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
        public static Boolean login() {
            Boolean testLogin=true;
            String user, psw;

            Console.WriteLine("Entre votre login");
            user=Console.ReadLine();

            Console.WriteLine("Entre votre mot de passe");
            psw = Console.ReadLine();

            if (user != "meriem" || psw!= "1234")
            {
                return testLogin == false;
            }

            return testLogin;

        }
    }
}
