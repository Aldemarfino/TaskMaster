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
using System.Runtime.InteropServices;
using System.Windows.Interop;
using Presentation.UserControls;
using FontAwesome.Sharp;
using System.ComponentModel;
using ENTITY;

namespace Presentation
{
    /// <summary>
    /// Lógica de interacción para MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window, INotifyPropertyChanged
    {
        public MainMenuWindow(User user)
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.User = user;
            rdbHome.IsChecked = true;

            CurrentUser1 = user.UserName;
        }

        private User User;
        private string Title;
        private IconChar Icon;
        private string CurrentUser;


        public event PropertyChangedEventHandler? PropertyChanged;
        public string Title1
        {
            get{ return Title; } 
            set 
            { 
                Title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title1"));
            } 
        }
        public IconChar Icon1 
        { 
            get { return Icon; } 
            set 
            {
                Icon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Icon1"));
            } 
        }
        public string CurrentUser1 
        { 
            get { return CurrentUser; } 
            set 
            {
                CurrentUser = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentUser1"));
            } 
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnSize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
           this.WindowState = WindowState.Minimized;
        }
        private void LoadUserControl(UserControl userControl)
        {
            ViewContent.Content = userControl;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Name)
            {
                case "rdbHome":
                    LoadUserControl(new HomeView(User));
                    Title1 = "Mis Proyectos";
                    Icon1 = IconChar.Home;
                    break;

                case "rdbCalendar":
                    LoadUserControl(new CalendarView());
                    Title1 = "Calendario";
                    Icon1 = IconChar.Calendar;
                    break;

                case "rdbInvProjects":
                    LoadUserControl(new InvitedProjectsView());
                    Title1 = "Proyectos Invitados";
                    Icon1 = IconChar.Users;
                    break;

                case "rdbLogOut":
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
