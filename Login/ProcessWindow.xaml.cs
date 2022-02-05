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
using System.Windows.Shapes;

namespace Login
{
   
    public partial class ProcessWindow : Window
    {
        Window creatingForm;
        static MainViewModel _main = new MainViewModel();
        public ProcessWindow()
        {
            InitializeComponent();
            DataContext = _main;
        }

       
        public static void setScreen(string _status)
        {
            _main.setScreen(_status);
        }
        public Window setCreatingForm
        {
            get { return creatingForm; }
            set { creatingForm = value; }
        }

       

       
    }
}
