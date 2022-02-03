using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPendu.Classes
{
    public class GenerateurDeMot
    {
        private String[] mots = { "google", "microsoft", "facebook", "sopra", "capg" };
        
        private Random random = new Random();
        public string Generer()
        {
            int randomIndex = random.Next(0, mots.Length);
            return mots[randomIndex];
        }
    }
}
