using Login.ModelView;
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

namespace Login.View
{
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : UserControl
    {
        MainViewModel _main = new MainViewModel();
        public TestView()
        {
            InitializeComponent();
            DataContext = _main;
            _main.setImage();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            /*DataContext = null;*/
            _main.setImage();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (_main.checkWord(txtWord.Text))
            {
                /*_main.MyMainFlag = new CorrectFlagViewModel();*/
                _main.setFlag("true");
            }
            else
            {
                /* _main.MyMainFlag = new IncorrectFlagViewModel();*/
                _main.setFlag("false");
            }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ProcessWindow.setScreen("OPTION");
        }
    }
}
