using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TpCompteBancaireHeritageWPF.Classes;

namespace TpCompteBancaireHeritageWPF
{
    /// <summary>
    /// Logique d'interaction pour RetraitOperationWindow.xaml
    /// </summary>
    public partial class RetraitOperationWindow : Window
    {
        Compte cTmp = new();
        MainWindow w;
        public RetraitOperationWindow(int numCompte, MainWindow window)
        {
            InitializeComponent();
            cTmp = cTmp.RechercherCompte(numCompte);
            w = window;
            TbIdCompte.Text = numCompte.ToString();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            decimal montant;
            if (decimal.TryParse(TbxMontant.Text, out montant))
            {
                Operation o = new Operation(montant*-1);
                if (cTmp.GetType() == typeof(ComptePayant))
                {
                    ComptePayant compte = (ComptePayant)cTmp;
                    compte.Retrait(o);
                }
                else
                    cTmp.Retrait(o);
                MessageBox.Show($"Le retrait de {montant} € a été effectué", "Retrait effectué", MessageBoxButton.OK, MessageBoxImage.Information);
                w.ActualiserCompte(cTmp.Id);
                Close();
            }
            else
                MessageBox.Show("Erreur de saisie du montant", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
