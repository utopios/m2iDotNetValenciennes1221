using System;
using System.Collections.Generic;
using LesInterfaces.Classes;
using LesInterfaces.Interfaces;

namespace LesInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IPersonne
            Personne p = new Personne(new Adresse2()) { Nom = "Di Persio", Prenom = "Anthony" };
            Console.WriteLine(p);


            // Ivolant
            List<IVolant> volants = new List<IVolant>();

            volants.Add(new Oiseau());
            volants.Add(new Drone());
            volants.Add(new Avion());

            foreach (IVolant volant in volants)
                volant.Voler();

            IVolant avion = new Avion();
            IVolant drone = new Drone();
            IVolant oiseau = new Oiseau();


            TransportColis t = new(oiseau);

            t.Transporter();
            t.Livrer();


            TransportColis u = new(drone);

            u.Transporter();
            u.Livrer();

            TransportColis v = new(avion);

            v.Transporter();
            v.Livrer();


            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
