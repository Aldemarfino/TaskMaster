using DAL;
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
using ENTITY;

namespace Presentation.UserControls
{
    /// <summary>
    /// Lógica de interacción para InvitedProjectsView.xaml
    /// </summary>
    public partial class InvitedProjectsView : UserControl
    {
        TaskRepository taskRepository;
        User User;
        public InvitedProjectsView(User user)
        {
            InitializeComponent();

            User = user;
            taskRepository = new TaskRepository();
            LoadInvitedTasksDataGrid();
        }

        public void LoadInvitedTasksDataGrid()
        {
            invitedTasksDataGrid.DataContext = taskRepository.GetInvitedTasks(User.UserName);
        }
    }
}
