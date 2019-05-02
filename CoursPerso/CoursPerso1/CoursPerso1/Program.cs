using System;

namespace CoursPerso1
{
    class Program
    {
        static void Main(string[] args)
        {
            MaClass monObjet = new MaClass("Mokobe","Jean", 25);

            Console.WriteLine(monObjet.GetIdentity());

            Console.WriteLine();


        }
    }
}
