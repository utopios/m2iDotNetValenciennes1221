using CorrectionPendu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPendu.Classes
{
    public class GenerateurDeMot : IGenerateur
    {
        private String[] mots = { "google", "microsoft", "facebook", "sopra", "capg" };
        
        private Random random;
        public string Generer()
        {
            random = new Random();
            int randomIndex = random.Next(0, mots.Length);
            return mots[randomIndex];
        }
    }
}
