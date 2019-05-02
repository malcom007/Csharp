using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)

        {
            Boolean monTester = true;
            int number, result=0;

            Console.WriteLine("****Factorisation***");

            //do
            //{
            //    Console.WriteLine("Entrez un nombre");

            //    try
            //    {
            //        number = int.Parse(Console.ReadLine());

            //        for (int i = 0; i < number+1; i++)
            //        {
            //            if (i==0)
            //            {
            //                result = 1;
            //            }
            //            else

            //                result = i * result;

            //            Console.WriteLine("{0}! = {1}", i,result);
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Erreur! Format numérique seulement");
            //        monTester = false;
            //    }

            //} while (!monTester);

            Console.WriteLine("****Conversion en Binair***");

            String Convert;

            int i;


            do
            {
                Console.WriteLine("Entre un entier");

                try
                {
                    ArrayList tab = new ArrayList();
                    number = int.Parse(Console.ReadLine());

                    do
                    { int r = number % 2;
                        tab.Add(r);
                        result = (number-r) /2;

                    } while (result !=0);


                    Console.WriteLine( "Ca marche");





                }
                catch (Exception )
                {
                    Console.WriteLine("Erreur! Format numérique seulement");
                    monTester = false;
                }

            } while (!monTester);


        }
    }
}
