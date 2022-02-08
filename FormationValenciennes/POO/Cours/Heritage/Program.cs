using System;
using Heritage.Classes;

namespace Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Instance de la classe fleur et utilisation des méthodes disponible
            Fleur cosmos = new Fleur("Cosmos", "Cosmos Sulphureus");
            //Console.WriteLine("Mon nom est {0}", cosmos.NomFleur);
            //Afficher(cosmos);
            #endregion

            #region Instance de la classe chat et utilisation des méthodes disponible
            Chat kitkat = new Chat("kitkat", "Siamoise");
            //Console.WriteLine("Mon nom est {0}", kitkat.NomChat);
            //Afficher(kitkat);
            #endregion

            #region Instance de la classe Chien et utilisation des méthodes disponible
            Chien medor = new Chien("medor", "Berger Allemand");
            //Console.WriteLine("Mon nom est {0}", medor.NomChien);
            //Afficher(medor);
            // medor.Aboyer();
            #endregion

            EtreVivant laVache = new Vache("Marguerite", "Normande");
            //Afficher(laVache);
            EtreVivant rex = new Chien("Rex", "Caniche");
            //Afficher(rex);
            //rex.Aboyer();
            EtreVivant Etre1 = new Poisson("Bubule", "Rouge");
            EtreVivant Etre2 = new Chat("Ronron", "Angora");
            EtreVivant Etre3 = new Fleur("TiteFleur", "Paquerette");

            EtreVivant[] tab = new EtreVivant[] {laVache,rex,Etre1,Etre2,Etre3};

            foreach (EtreVivant v in tab)
            {
                Afficher(v);
            }

            #region Boxing / Unboxing
            Console.WriteLine(rex.GetType());
            // Unboxing de EtreVivant => Chien
            rex = (Chien)rex;
            Console.WriteLine(rex.GetType());

            Afficher(rex);

            // Conversion
            for (int i = 0; i < tab.Length; i++)
            {
                //1ere Solution Boxing => Unboxing
                if (tab[i].GetType()==typeof(Chien))
                {
                    Chien c = (Chien)tab[i];
                    Afficher(c);
                }

                // 2 eme solution => Utiliser le mot clé "as" pour effectuer la conversion
                Vache v = tab[i] as Vache;
                if (v != null)
                    Afficher(v);

                // 3eme solution = En utilisant le mot clé "is" pour effectuer une conversion
                if (tab[i] is Poisson poisson)
                {
                    Afficher(poisson);
                }
            }
            #endregion




            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
        public static void Afficher(Fleur f)
        {
            Console.WriteLine("Mon nom est {0}", f.NomFleur);
            f.Naissance();
            f.Reproduction();
            f.Alimentation();
            f.Expression();
            f.Oxigenation();
            f.Reproduction();
            f.Mort();
            Console.WriteLine("-------------------------------------");
        }
        public static void Afficher(Chat c)
        {
            Console.WriteLine("Mon nom est {0}",c.NomChat);
            c.Naissance();
            c.Reproduction();
            c.Alimentation();
            c.Expression();
            c.Oxigenation();
            c.Reproduction();
            c.Mort();
            Console.WriteLine("-------------------------------------");
        }

        public static void Afficher(Chien c)
        {
            Console.WriteLine("Mon nom est {0}", c.NomChien);
            c.Naissance();
            c.Reproduction();
            c.Alimentation();
            c.Expression();
            c.Oxigenation();
            c.Reproduction();
            c.Mort();
            c.Aboyer();
            Console.WriteLine("-------------------------------------");
        }

        public static void Afficher(EtreVivant e)
        {
            Console.WriteLine("Mon nom est {0}", e.Nom);
            e.Naissance();
            e.Reproduction();
            e.Alimentation();
            e.Expression();
            e.Oxigenation();
            e.Reproduction();
            e.Mort();
            Console.WriteLine("-------------------------------------");
        }
    }
}
