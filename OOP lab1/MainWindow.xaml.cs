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
using System.Drawing;
using OOP_lab1.Structs;
using OOP_lab1.Extentions;
using OOP_lab1.Shapes;

namespace OOP_lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WriteableBitmap _bitmap;
        public MainWindow()
        {
            InitializeComponent();
            _bitmap = new((int)Palette.Width, (int)Palette.Height, 96, 96, PixelFormats.Bgr32, null);
            Button_Click(null, null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BaseShape shape = new Shapes.Rectangle();
            _bitmap.DrawShape(shape);
            Palette.Source = _bitmap;
        }
    }
}
