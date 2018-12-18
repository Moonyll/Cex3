using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, quel est votre âge ?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Bonjour, quel est votre sexe (homme ou femme)?");
            string genre = Console.ReadLine();
            if (age >= 18)
                Console.WriteLine("Vous êtes un(e) " + genre + " et vous êtes majeur.");
            else
                Console.WriteLine("Vous êtes un(e) " + genre + " ans, vous êtes mineur.");
        }
    }
}
