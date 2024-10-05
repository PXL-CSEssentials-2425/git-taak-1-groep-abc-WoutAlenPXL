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

        // Hover Effect - Change window background when hovering over PXL logo
        private void Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightBlue); // Change to any color when hovering
        }

        private void Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightGray); // Reset to light gray
        }
    }
}
