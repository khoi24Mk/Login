using Login.ModelView;
using Login.SQLquery;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class LoginWindow : Window
    {
        ProcessWindow _processWindow;
        private bool _flag = false; //login
        private MainViewModel x = new MainViewModel();
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = x;
        }

        

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            txtComfirmPass.Visibility = Visibility.Collapsed;
            queryOperation._status = true;
            if (_flag)
            {
                _flag = false;
                return;
            }
            if (SQLquery.queryOperation.SQLlogin(txtLoginUsername, txtLoginPassword))
            {
                MessageBox.Show("OK");
                _processWindow = new ProcessWindow();
                _processWindow.setCreatingForm = this;
                _processWindow.Show();
                
                this.Close();
            }
            else
            {
                MessageBox.Show("INCORRECT");
            }
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            txtComfirmPass.Visibility = Visibility.Visible;
            queryOperation._status = false;
            if (!_flag)
            {
                _flag = true;
                return;
            }


            SQLquery.queryOperation.SQLlogin(txtLoginUsername, txtLoginPassword);



        }

        private void Click_Username(object sender, DependencyPropertyChangedEventArgs e)
        {
            txtLoginUsername.Background = Brushes.Transparent;
        }
        private void Click_Password(object sender, DependencyPropertyChangedEventArgs e)
        {
            txtLoginPassword.Background = Brushes.Transparent;
        }


        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(txtComfirmPass.Password);
            string strPass = txtComfirmPass.Password;
            if(txtLoginPassword.Password != strPass)
            {
                labelComfirmPass.Content = "Password is not matched";
                labelComfirmPass.Foreground = Brushes.Red;
            }
            else
            {
                labelComfirmPass.Content = "Password is matched";
                labelComfirmPass.Foreground = Brushes.Green;
            }
        }
    }
}
