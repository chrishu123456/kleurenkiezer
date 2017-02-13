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

namespace kleurenkiezer
{
    /// <summary>
    /// Interaction logic for BrushesWindow.xaml
    /// </summary>
    public partial class BrushesWindow : Window
    {
        public BrushesWindow()
        {
            InitializeComponent();
        }


        private void VergrootButton_Click(object sender, RoutedEventArgs e)
        {
            if (VergrootButton.IsChecked == true)
            {
                VergrootButton.Content = "Zonder vergroting";
                VisualBrush zicht = new VisualBrush();
                zicht.Viewport = new Rect(0, 0, 1, 0.5);
                zicht.TileMode = TileMode.FlipY;
                zicht.Visual = Panelmetknop;
                Vergroting.Fill = zicht;
            }
            else
            {
                VergrootButton.Content = "Vergroot";
                Vergroting.Fill = null;
            }
        }
    }
}
