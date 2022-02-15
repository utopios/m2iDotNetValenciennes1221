using CoursWPF.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CoursWPF
{
    /// <summary>
    /// Logique d'interaction pour ListViewWindow.xaml
    /// </summary>
    public partial class ListViewWindow : Window
    {
        private static ObservableCollection<Personne> personnes;
        //private static List<Personne> personnes;

        public ListViewWindow()
        {
            InitializeComponent();
            personnes = new ObservableCollection<Personne>();
            //personnes = new List<Personne>();
            AddToList();
            BinderListNom();
        }

        private void AjouterPersonne_Click(object sender, RoutedEventArgs e)
        {
            if (Nom.Text !="" && Prenom.Text !="" && Age.Text!="")
            {
                personnes.Add(new Personne(Nom.Text, Prenom.Text, Convert.ToInt32(Age.Text)));
                // BinderListNom(); // Seulement avec les collection de type List<>
                Nom.Text = "";
                Prenom.Text = "";
                Age.Text = "";
            }
        }

        private void AddToList()
        {
            Personne P1 = new("Toto", "Titi", 25);
            Personne P2 = new("Doe", "John", 35);
            Personne P3 = new("Rabbit", "Jessica", 60);
            Personne P4 = new("Doe", "Janes", 25);
            Personne P5 = new("Duss", "Jean-Claude", 75);

            personnes.Add(P1);
            personnes.Add(P2);
            personnes.Add(P3);
            personnes.Add(P4);
            personnes.Add(P5);
        }

        private void BinderListNom()
        {
            ListeBoxNom.ItemsSource = personnes;
        }
    }
}
