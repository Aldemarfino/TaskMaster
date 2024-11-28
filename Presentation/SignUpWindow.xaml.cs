using BLL;
using ENTITY;
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
using System.Windows.Shapes;

namespace Presentation
{
    /// <summary>
    /// Lógica de interacción para SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        UserLogic userLogic;
        public SignUpWindow()
        {
            InitializeComponent();
            userLogic = new UserLogic();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.txtData.Text) || string.IsNullOrEmpty(txtLastname.txtData.Text) ||
                string.IsNullOrEmpty(txtEmail.txtData.Text) || string.IsNullOrEmpty(txtUsername.txtData.Text) ||
                string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                string name = txtName.txtData.Text;
                string lastName = txtLastname.txtData.Text;
                string email = txtEmail.txtData.Text;
                string username = txtUsername.txtData.Text;
                string password = txtPassword.Password;
                User user = new User(null, username, password, name, lastName, email);

                MessageBox.Show(userLogic.Add(user),"Registro de Sesion",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            txtPassword.Password = string.Empty;
            txtPassword.Focus();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Password))
            {
                txtbBackText.Visibility = Visibility.Visible;
            }
            else
            {
                txtbBackText.Visibility= Visibility.Hidden;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridTitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
