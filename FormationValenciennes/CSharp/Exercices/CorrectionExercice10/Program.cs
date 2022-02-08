using System;

namespace CorrectionExercice10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** La lettre est-elle consonne ou voyelle ? ****");
            Console.Write("Merci de saisir la lettre : ");
            string lettre = Console.ReadLine().ToUpper();
            if(lettre == "A" || lettre == "E" || lettre == "I" || lettre == "O" || lettre == "U" || lettre == "Y")
            {
                Console.WriteLine("Cette lettre est une voyelle");
            }
            else
            {
                Console.WriteLine("Cette lette est une consonne");
            }
        }
    }
}
