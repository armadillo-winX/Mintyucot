using Microsoft.Win32;
using Mintyucot.Windows;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mintyucot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Title = $"{VersionInfo.AppName} ver.{VersionInfo.AppVersion}";
        }

        private void ExitMenuItemOnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddImageMascotButtonOnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "画像ファイル|*.bmp;*.png;*.jpeg;*.jpg"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                ImageMascotWindow imageMascotWindow = new(openFileDialog.FileName);
                imageMascotWindow.Show();
            }
        }
    }
}