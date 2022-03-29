using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectionPendu.Interfaces;

namespace CorrectionPendu.Classes
{
    public class Pendu
    {

        private int nbEssai;        
        private string masque;
        private string motAtrouve;

        public string Masque { get => masque;  }
        public string MotAtrouve { get => motAtrouve;  }
        public int NbEssai { get => nbEssai; }

        public Pendu()
        {
            nbEssai = 10;
        }
        public bool TestChar(char c)
        {
            ///
            /// On vérifie sur le caractère existe dans le motAtrouve, 
            /// si oui on renvoie vrai, on met à jour le masque
            /// si non on renvoie faux, on change ne nbEssai
            /// 
            
            bool result = false;
            string newMasque = "";
            for(int i = 0; i < MotAtrouve.Length; i++)
            {
                if(MotAtrouve[i] == c)
                {
                    newMasque += c;
                    result = true;
                }
                else
                {
                    newMasque += Masque[i];
                }
            }
            masque = newMasque;
            if(!result)
            {
                nbEssai--;
            }
            return result;
        }

        public bool TestWin()
        {
            ///
            /// On compare le masque et le motAtrouve
            /// Si le masque est égal au motAtrouve, on renvoie vrai
            /// sinon on renvoie faux
            ///

            return NbEssai > 0 && MotAtrouve == Masque;

        }

        public void GenererMasque(IGenerateur generateur)
        {
            //On génère le mot aléatoire, grace au generateur, motAtrouve.
            motAtrouve = generateur.Generer();
            //On crée le masque dans masque.
            masque = "";
            for(int i = 0; i < MotAtrouve.Length; i++)
            {
                masque += "*";
            }
        }
    }
}
