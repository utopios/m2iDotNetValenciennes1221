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

namespace CoursWPF
{
    /// <summary>
    /// Logique d'interaction pour ImagesWindow.xaml
    /// </summary>
    public partial class ImagesWindow : Window
    {
        public ImagesWindow()
        {
            InitializeComponent();
        }

        private void ChangerImages_Click(object sender, RoutedEventArgs e)
        {
            int index = -1;
            var images = MyDocPanel.Children.OfType<Image>();       // Recupere l'ensemble des enfants de type image contenu dans le MydocPanel
            Image image = images.FirstOrDefault(img => img.Visibility == Visibility.Visible); // Chercher l'image qui a la propriete Visibility a Visible
            image.Visibility = Visibility.Collapsed;                // Bascule la visibilité de l'image qui était visible à collapse
            Image[] imgTmp = images.ToArray();                      // Met sous forme de table le contenu de la var images
            index = Array.IndexOf(imgTmp, image);                   // Retrouve notre image qui était visible
            string nameTmp;
            if (index < 2)                                          // Construction du nom de la prochaine image à afficher
            {
                index++;
                nameTmp = "Img" + index;
            }
            else           
                nameTmp = "Img0";

            Image tmp = images.FirstOrDefault(img => img.Name == nameTmp); // Recherche l'image suivante à afficher

            tmp.Visibility = Visibility.Visible;                    // Bascule la propriété Visibilty à visible

        }
    }
}
