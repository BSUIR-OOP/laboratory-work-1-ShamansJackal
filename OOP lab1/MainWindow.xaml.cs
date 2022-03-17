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
using Rectangle = OOP_lab1.Shapes.Rectangle;

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
            _bitmap = new(800, 388, 96, 96, PixelFormats.Bgr32, null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            BaseShape shape = new Rectangle(40, 40, 300, 200) { color = PixelColors.Blue };
            BaseShape shape2 = new Square(450, 100, 50) { color = PixelColors.Red};
            BaseShape shape3 = new Triangle(470, 20, 470, 200, 600, 300);
            _bitmap.DrawShape(shape);
            _bitmap.DrawShape(shape2);
            _bitmap.DrawShape(shape3);
            Palette.Source = _bitmap;
        }
    }
}
