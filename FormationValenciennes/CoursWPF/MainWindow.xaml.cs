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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoursWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeBtn();
        }

        void MakeBtn()
        {
            Button btn1 = new Button()
            {
                Content = "Click Me...",
                Foreground = Brushes.OrangeRed,
                Background = Brushes.Yellow

            };
            btn1.Click += Button_Click;
            MyStackPanel.Children.Add(btn1);
          
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            // Permet de configurer une popUp et de récupérer éventuellement la réponse de l'utilisateur
            MessageBoxResult result = MessageBox.Show("Je propage le click","Information",MessageBoxButton.YesNo,MessageBoxImage.Question);

            // Si Récupération de la réponse, Le type est MessageBoxResult
            if (result == MessageBoxResult.Yes)
                MessageBox.Show("Il a dit oui...");
            else if (result == MessageBoxResult.No)
                MessageBox.Show("Il a dit Non...");
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow window = new AboutWindow();
            window.Show();
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void GridWindow_Click(object sender, RoutedEventArgs e)
        {
            GridWindow window = new GridWindow();
            window.Show();
        }

        private void ValiderSaisie_Click(object sender, RoutedEventArgs e)
        {
            // Récupérer les saisies
            string nom = NomTxBox.Text;
            string prenom = PrenomTxBox.Text;
            string age = AgeTxBox.Text;

            // Concaténer ces valeurs
            string nom_Complet = $"{nom} {prenom} a {age} ans";

            // afficher dans la partie ResultTxBlock
            ResultTxBlock.Text = nom_Complet;
        }

        private void UniformGridWindow_Click(object sender, RoutedEventArgs e)
        {
            UniformGridWindow window = new UniformGridWindow();
            window.Show();
        }
    }
}
