using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritage.Classes;

namespace TpCompteBancaireHeritage.Data
{
    internal class ClientCompteInjection
    {
        public static void Injecter(Bank bank)
        {
            // Création des clients
            Client c1 = new Client("Di Persio", "Anthony", "+33 6 12 34 56 78");



            // Création des Comptes
            Compte compte1 = new(150, c1);


            // Ajout d'opérations
            Operation operation1 = new(20);
            Operation operation2 = new(-40);

            // Ajout des opération au comptes
            compte1.Operations.Add(operation1);
            compte1.Operations.Add(operation2);

            // Ajout du compte à la collection comptes de la Bank
            bank.Comptes.Add(compte1);

        }
    }
}
