using System;

namespace CoursIntro
{
    class Program
    {
        static void Main(string[] args)
        {
 Boolean test=false;
            int count=0;
        Debut:
            Console.WriteLine("MonProgramme");

            while(test != true)
            {
                Console.WriteLine("Entre un chiffre");
                try
                {
                    count++;
                    int aReussi1 = int.Parse(Console.ReadLine());

                   
                        Console.WriteLine("Marche nickel");
                        Console.WriteLine(aReussi1);

                    Second:
                    Console.WriteLine("2e conversion, entrez  la valeur");

                    Boolean aReussi = int.TryParse(Console.ReadLine(), out int result);

                    if (aReussi == false)
                    {
                        Console.WriteLine("Conversion n'a pas fonctionné");
                        goto Second;
                    }
                    else
                        Console.WriteLine("Convertion est " + aReussi + " et son contenu est " + result);
                   
                    test = true;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur de conversion "+count);
                    if (count >= 3)
                        goto Debut;

                }


                //A mettre en place pour les ancienne version de VisualStudio...
                /*Console.WriteLine("Appuyez sur une touche pour continuer...");
                Console.ReadKey(true);*/

            }
        }
    }
}
