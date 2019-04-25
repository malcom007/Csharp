using System;

namespace Exercice1Cours2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age");
            //Notre tester10681068
            Boolean monTest=true;
            do
            {
                int age=-1;
                try
                {
                    Console.WriteLine("Entre votre age");
                    age = int.Parse(Console.ReadLine());

                    if (age >= 0 && age <= 100)
                    {
                        Console.WriteLine("Vous avez {0} ans", age);
                        monTest = true;
                    }
                    else
                    {
                        Console.WriteLine("Vous avez soit plus de 100 ans ou vous n'êtes pas encore né");
                        monTest = true;
                    }


                }
                catch (Exception )
                {
                    Console.WriteLine("Entrez une valeur numerique");
                    monTest = false;
                }

                string date = DateTime.Now.ToString("yyyy");
                Console.WriteLine("Date System "+date);

                DateTime dateM;
                dateM = Convert.ToDateTime("09/04/2019");
                Console.WriteLine(dateM);






            } while (!monTest);
        }
    }
}
