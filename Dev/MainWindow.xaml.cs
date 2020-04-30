using ArtNetSoft.UI.WPF;
using System.Windows;

namespace Dev
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var theme = Theme.ThemeType == ThemeType.Light ?
                ThemeType.Dark : ThemeType.Light;

            Theme.LoadThemeType(theme);
        }
    }
}
