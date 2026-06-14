using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Mintyucot.Windows
{
    /// <summary>
    /// ImageMascotWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ImageMascotWindow : Window
    {
        public ImageMascotWindow(
            string imageFilePath)
        {
            InitializeComponent();

            BitmapImage bitmapImage = new();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imageFilePath);
            bitmapImage.EndInit();
            this.MascotMainImage.Source = bitmapImage;
        }

        private void MascotMainImageOnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ImageMascotWindowOnActivated(object sender, EventArgs e)
        {
            TopResizeBlock.Visibility = Visibility.Visible;
            LeftResizeBlock.Visibility = Visibility.Visible;
            RightResizeBlock.Visibility = Visibility.Visible;
            BottomResizeBlock.Visibility = Visibility.Visible;
        }
    }
}
