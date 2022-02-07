﻿using System;
using System.Collections.Generic;
using LesGeneriques.Classes;

namespace LesGeneriques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region La class Opération<T>
            Console.WriteLine("*** Les elements génériques ***");

            Console.WriteLine("\nAvec des type int : ");
            Operation<int> obj1 = new Operation<int>();
            Console.WriteLine(obj1.EstEquivalent(2, 2));

            Console.WriteLine("\nAvec des type double : ");
            Operation<double> obj2 = new Operation<double>();
            Console.WriteLine(obj2.EstEquivalent(0.55, 0.55));

            Console.WriteLine("\nAvec des type string : ");
            Operation<string> obj3 = new Operation<string>();
            Console.WriteLine(obj3.EstEquivalent("Bonjour", "Bonjour"));
            #endregion


            #region Les Queue<> FirstInFirstOut (FIFO)
            Console.WriteLine("\n*** Les Queues<T> ***");
            Console.WriteLine("\nAvec des type int : ");
            Queue<int> file = new Queue<int>();
            file.Enqueue(1);
            file.Enqueue(2);
            file.Enqueue(3);
            file.Enqueue(4);
            file.Enqueue(5);
            int valeur = file.Dequeue();
            Console.WriteLine(valeur);
            valeur = file.Dequeue();
            Console.WriteLine(valeur);
            valeur = file.Dequeue();
            Console.WriteLine(valeur);
            valeur = file.Dequeue();
            Console.WriteLine(valeur);
            valeur = file.Dequeue();
            Console.WriteLine(valeur);

            Console.WriteLine("\nAvec des type string : ");
            Queue<string> chaine = new Queue<string>();
            chaine.Enqueue("Chaine 1");
            chaine.Enqueue("Chaine 2");
            chaine.Enqueue("Chaine 3");
            chaine.Enqueue("Chaine 4");
            chaine.Enqueue("Chaine 5");
            
            string ch = chaine.Dequeue();
            Console.WriteLine(ch);
            ch = chaine.Dequeue();
            Console.WriteLine(ch);
            ch = chaine.Dequeue();
            Console.WriteLine(ch);
            ch = chaine.Dequeue();
            Console.WriteLine(ch);
            ch = chaine.Dequeue();
            Console.WriteLine(ch);
            #endregion

            #region Les Piles<T> LastInFirstOut (LIFO)
            Console.WriteLine("\n*** Les Piles<T> ***");
            Console.WriteLine("\nAvec des type int : ");
            Pile<int> pileEntier = new Pile<int>(3);
            pileEntier.Empiler(1);
            pileEntier.Empiler(10);
            pileEntier.Empiler(100);
            Console.WriteLine($"L'élément en place 1 de la pile est {pileEntier.Get(0)}");
            Console.WriteLine($"L'élément en place 2 de la pile est {pileEntier.Get(1)}");
            Console.WriteLine($"L'élément en place 3 de la pile est {pileEntier.Get(2)}");
            // Console.WriteLine($"L'élément en place 4 de la pile est {pileEntier.Get(3)}"); // Genere un ereur de compilation

            pileEntier.Depiler();

            Console.WriteLine($"L'élément en place 1 de la pile est {pileEntier.Get(0)}");
            Console.WriteLine($"L'élément en place 2 de la pile est {pileEntier.Get(1)}");
            Console.WriteLine($"L'élément en place 3 de la pile est {pileEntier.Get(2)}");

            Console.WriteLine("\nAvec des type Voiture : ");
            Pile<Voiture> pileVoiture = new Pile<Voiture>(3);
            pileVoiture.Empiler(new Voiture("ceed","Blanche",45,900));
            pileVoiture.Empiler(new Voiture("Kuga", "Noir",50,800));
            pileVoiture.Empiler(new Voiture("Espace","Bleu",80,1200));
            Console.WriteLine($"L'élément en place 1 de la pile est {pileVoiture.Get(0)}");
            Console.WriteLine($"L'élément en place 2 de la pile est {pileVoiture.Get(1)}");
            Console.WriteLine($"L'élément en place 3 de la pile est {pileVoiture.Get(2)}");
            // Console.WriteLine($"L'élément en place 4 de la pile est {pileEntier.Get(3)}"); // Genere un ereur de compilation

            pileVoiture.Depiler();
            pileVoiture.Depiler();

            Console.WriteLine($"L'élément en place 1 de la pile est {pileVoiture.Get(0)}");
            Console.WriteLine($"L'élément en place 2 de la pile est {pileVoiture.Get(1)}");
            Console.WriteLine($"L'élément en place 3 de la pile est {pileVoiture.Get(2)}");
            #endregion

            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
            Console.Read();
        }
    }
}
