using System;

namespace Cours2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int rep;
            //do
            //{
            //    Console.WriteLine("***Menu***");
            //    Console.WriteLine("1.Afficher la lettre A");
            //    Console.WriteLine("2.Afficher la lettre b");
            //    Console.WriteLine("Tapez votre reponse");

            //    rep = int.Parse(Console.ReadLine());

            //} while (rep != 1 && rep != 2);

            //try
            //{
            //    int x=55;
            //    int y = 0;
            //    int z = x / y;
            //    Console.WriteLine("Reponse est " + z);

            //}
            //catch (DivideByZeroException )
            //{
            //    Console.WriteLine("Impossible de diviser par zero");
            //}
            //catch (Exception )
            //{
            //    Console.WriteLine("Verifier votre nombre");
            //}

            //string[] tab = new string[2];

            //try
            //{

            //        tab[2] = "Meriem";
            //    Console.WriteLine(tab[2]);

            //    tab[1] = "Malcom";
            //    Console.WriteLine(tab[1]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Vous avez depassé la taille du table");

            //}
            //catch (Exception )
            //{
            //    Console.WriteLine("Erreur final");

            //}

            //Création Random
            Random rd = new Random();

            for (int i = 0; i < 10; i++)
            {
                //il va nous generer un nombre entre 1 et 10
                int number = rd.Next(1, 11);



                Console.WriteLine("nombre generé " + number);
            }


            //Random des lettres

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                char randomChar = (char)rnd.Next('a', 'z');
                Console.WriteLine(randomChar);
            }

    }
    }
}
