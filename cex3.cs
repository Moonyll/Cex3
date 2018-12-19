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
/* Console.WriteLine("entrer votre Genre M/Mme");
            string gender = (Console.ReadLine());
            Console.WriteLine("entrer votre âge");
            int age = int.Parse(Console.ReadLine());
            /*if (gender == "M" && age > 17 && age <= 120)    //Condition si Homme ET age entre 18 ET 120 ans
            {
                Console.WriteLine("Vous êtes un Homme et vous êtes majeur.");
            }
            else if (gender == "M" && age < 18 && age >= 1) //Condition si Homme ET age entre 17 ET 1 ans
            {
                Console.WriteLine("Vous êtes un Homme et vous êtes mineur.");
            }
            else if (gender == "Mme" && age > 17 && age <= 120)
            {
                Console.WriteLine("Vous êtes une Femme et vous êtes majeure.");
            }
            else if (gender == "Mme" && age < 18 && age >= 1)
            {
                Console.WriteLine("Vous êtes un Femme et vous êtes mineure.");
            }
            else { Console.WriteLine("Il doit y avoir un problème"); }
            if (gender == "Mme")
            {
                if (age > 17 && age <= 120)
                {
                    Console.WriteLine("Vous êtes une Femme et vous êtes majeure.");
                }
                else if (age < 18 && age >= 1)
                {
                    Console.WriteLine("Vous êtes un Femme et vous êtes mineure.");
                }
                else { Console.WriteLine("Il doit y avoir un problème au niveau de l'âge"); }
            }
            else if (gender == "M")
            {
                if (age > 17 && age <= 120)
                {
                    Console.WriteLine("Vous êtes un Homme et vous êtes majeur.");
                }
                else if (age < 18 && age >= 1)
                {
                    Console.WriteLine("Vous êtes un Homme et vous êtes mineur.");
                }
                else { Console.WriteLine("Il doit y avoir un problème au niveau de l'âge"); }
            }
            else { Console.WriteLine("Il doit y avoir un problème au niveau du genre"); }
        }
    }
}*/
