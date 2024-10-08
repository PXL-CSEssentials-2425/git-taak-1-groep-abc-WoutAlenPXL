using System.Windows;
using System.Windows.Media;

namespace ColorPsychology
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler voor Rode afbeelding
        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            ColorCodeTextBox.Text = "#FF0000"; // Rood
            ColorInfoTextBox.Text = "Rood is de kleur van warmte";
        }

        // Event handler voor Gele afbeelding
        private void YellowButton_Click(object sender, RoutedEventArgs e)
        {
            ColorCodeTextBox.Text = "#FFFF00"; // Geel
            ColorInfoTextBox.Text = "Geel is de kleur van levenslust";
        }

        // Event handler voor Groene afbeelding
        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            ColorCodeTextBox.Text = "#008000"; // Groen
            ColorInfoTextBox.Text = "Groen is de kleur van genezing";
        }

        // Event handler voor Blauwe afbeelding
        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            ColorCodeTextBox.Text = "#0000FF"; // Blauw
            ColorInfoTextBox.Text = "Blauw is de kleur van intelligentie";
        }
    }

}


    


