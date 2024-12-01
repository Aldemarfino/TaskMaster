using FontAwesome.Sharp;
using Presentation.UserControls;
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
using en = ENTITY;
using BLL;
using System.Collections.ObjectModel;

namespace Presentation
{
    /// <summary>
    /// Lógica de interacción para ProjectSettings.xaml
    /// </summary>
    public partial class ProjectSettings : Window
    {
        private en.Project Project;
        TaskLogic taskLogic;
        public ProjectSettings(en.Project project)
        {
            taskLogic = new TaskLogic();
            this.Project = project;
            this.DataContext = this;
            tasks = new ObservableCollection<en.Task>();

            InitializeComponent();
            rdbProjectInfo.IsChecked = true;
        }

        private void LoadTasksGridData()
        {
            Tasks = new ObservableCollection<en.Task>(taskLogic.TasksByProject(Project.IdProject));
            TaskDataGrid.ItemsSource = Tasks;
        }

        private ObservableCollection<en.Task> tasks;

        public ObservableCollection<en.Task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Name)
            {
                case "rdbProjectInfo":
                    projectDetailsGrid.Visibility = Visibility.Visible;
                    taskGrid.Visibility = Visibility.Collapsed;
                    break;

                case "rdbProjectTask":
                    taskGrid.Visibility = Visibility.Visible;
                    projectDetailsGrid.Visibility = Visibility.Collapsed;
                    break;

                case "rdbInvitedUsers":
                    break;

            }
        }

        private async void btnIASuggestedTasks_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<en.Task> tasks = await taskLogic.IASuggestedTask(Project);
                if (tasks == null)
                {
                    MessageBox.Show("No fue posible sugerir tareas");
                }
                else
                {
                    this.Tasks = new ObservableCollection<en.Task>(tasks);
                    TaskDataGrid.ItemsSource = Tasks;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No fue posible sugerir tareas");
            }
        }

        private void btnCreateTask_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTaskOptions_Click(object sender, RoutedEventArgs e)
        {
            TaskOptionsPopUp.IsOpen = true;
        }
    }
}
