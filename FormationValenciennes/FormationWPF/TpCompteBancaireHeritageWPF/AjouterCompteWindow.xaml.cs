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
    /// Logique d'interaction pour AjouterCompteWindow.xaml
    /// </summary>
    public partial class AjouterCompteWindow : Window
    {
        Client client = null;
        public AjouterCompteWindow()
        {
            InitializeComponent();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            if (TbxNom.Text !="" && TbxPrenom.Text != "" && TbxTelephone.Text !="" )
            {
                client = new Client(TbxNom.Text, TbxPrenom.Text, TbxTelephone.Text);
                client.Id = client.Save();
                TbIdClient.Text = client.Id.ToString();
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void AjouterCompte_Click(object sender, RoutedEventArgs e)
        {
            if (client != null && TbxSolde.Text != "" )
            {
                decimal solde;
                if (decimal.TryParse(TbxSolde.Text, out solde))
                {
                    Compte c = null;
                    if (TbxTaux.Text != "")
                    {
                        decimal taux = Convert.ToDecimal(TbxTaux.Text);
                        c = new CompteEpargne(solde, client, taux);
                    }
                    else if (TbxMontantOperation.Text != "")
                    {
                        decimal montant = Convert.ToDecimal(TbxMontantOperation.Text);
                        c = new ComptePayant(solde, client, montant);
                    }
                    else
                    {
                        c = new Compte(solde, client);
                    }
                    if (c.AjouterCompte())
                    {
                        MessageBox.Show("Les compte à été ajouté", "Succes", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        Close();
                    }
                    else
                        MessageBox.Show("Erreur lors de l'ajout du compte", "Erreur d'ajout", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                    MessageBox.Show("Veuillez verifier la saisie du montant", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Fermer_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
