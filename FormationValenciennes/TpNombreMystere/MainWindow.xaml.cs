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
using TpNombreMystere.Classes;

namespace TpNombreMystere
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game game;
        private int UserNum;

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            game = new Game();
            TbLigne1.Text = $"";
            TbLigne2.Text = "Veuillez saisir un chiffre / nombre entre 1 et 50";
            TbNbEssai.Text = $"Nombre d'essai(s) : {game.Counter}";
            TbxUserNum.Text = "";
            BtnValider.IsEnabled = true;
        }

        private void TbxUserNum_Keydown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return && game.GameWin != true)
            {
                BtnValider_Click(sender, e);
            }
        }

        private int PickedNumber()
        {
            string picked = TbxUserNum.Text;
            int pickedNum;
            // Vérificaton de la saisie utilisteur 
            bool isNumeric = int.TryParse(picked, out pickedNum);
            if (isNumeric == false)
                TbLigne1.Text = "Erreur de saisie";
            else
            {
                game.Counter++;
                UpdateNbCoups();
            }
            TbxUserNum.Text = "";
            return pickedNum;
        }

        private void UpdateNbCoups()
        {
            TbNbEssai.Text = $"Nombre d'essai(s) : {game.Counter}";
        }

        private void BtnValider_Click(object sender, RoutedEventArgs e)
        {
            UserNum = PickedNumber();
            if (UserNum > 0 && UserNum < 51)
            {
                TbLigne1.Text = game.TestNum(UserNum);
            }
            else
                TbLigne1.Text = "Erreur de saisie";
            
            if (game.GameWin)
            {
                BtnValider.IsEnabled = false;
                TbLigne2.Text = $"Le nombre mystère était {game.NbMystere}";
            }
            else
            {
                TbxUserNum.Focus();
            }
                
        }

        private void BtnNouvellePartie_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }
    }
}
