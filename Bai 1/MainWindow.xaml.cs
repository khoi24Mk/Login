using Bai_1.ViewModels;
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

namespace Bai_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageViewModel _main = new ImageViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _main;

            _main.setImage();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            _main.setImage();
        }

        private void Windo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
