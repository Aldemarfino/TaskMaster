using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL;
using ENTITY;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserLogic userLogic;
        public MainWindow()
        {
            InitializeComponent();
            userLogic = new UserLogic();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            User user = userLogic.ObtainByUsername(txtUser.Text);
            if (user == null)
            {
                MessageBox.Show("El usuario no existe");
            }
            else
            {
                if (user.Password == txtPassword.Password)
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    MainMenuWindow mainMenuWindow = new MainMenuWindow(user);
                    mainMenuWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciales erroneas");
                }
            }
        }

        private void btnRegistrar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow();
            signUpWindow.Show();
            this.Close();
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