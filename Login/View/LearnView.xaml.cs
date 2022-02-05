using Login.ModelView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Login.View
{
    /// <summary>
    /// Interaction logic for LearnView.xaml
    /// </summary>
    public partial class LearnView : UserControl
    {
        MainViewModel _main = new MainViewModel();
        public LearnView()
        {
            InitializeComponent();
            DataContext = _main;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("NEXT");
            _main.setImage();
        }
    }
}
