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
            setScreen("OPTION");
            
        }

       public void setUsername(string username)
        {
            _main.UserModelview.Username = username;
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            setScreen("OPTION");
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow x = new LoginWindow();
            x.Show();
            this.Close();
            
        }

        private void onMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
