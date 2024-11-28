using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using BLL;
using ENTITY;
using Microsoft.Win32;

namespace Presentation.UserControls
{
    /// <summary>
    /// Lógica de interacción para HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        ProjectLogic projectLogic;
        private User User;
        public HomeView(User user)
        {
            projectLogic = new ProjectLogic();
            InitializeComponent();

            User = user;
            DataContext = this;
            LoadGridData();
        }

        private void LoadGridData()
        {
            Projects = new ObservableCollection<Project>(projectLogic.ProjectsByUser(User.UserName));
            ProjectsDataGrid.ItemsSource = Projects;
        }

        private ObservableCollection<Project> projects;

        public ObservableCollection<Project> Projects
        {
            get { return projects; }
            set { projects = value; }
        }

        private void ProjectsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProjectsDataGrid.SelectedItem is Project selectedProject)
            {
                MessageBox.Show($"Proyecto seleccionado: {selectedProject.Name}");
            }
        }

        private void FilteredProjectsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tgbNewProject_Checked(object sender, RoutedEventArgs e)
        {
            PopupNewProject.IsOpen = true;
        }

        private void tgbNewProject_Unchecked(object sender, RoutedEventArgs e)
        {
            PopupNewProject.IsOpen = false;
        }

        private void btnAttachFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleccionar Archivo",
                Filter = "Todos los Archivos (*.*)|*.*"
            };

            PopupNewProject.IsOpen = false;

            if (openFileDialog.ShowDialog() == true)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
            PopupNewProject.IsOpen = true;
        }

        private void btnAddProject_Click(object sender, RoutedEventArgs e)
        {
            CreateNewProject();
        }

        private void CreateNewProject()
        {
            if (ValidateCreateProjectPopup())
            {
                Project project = new Project
                {
                    Name = txtProjectName.txtData.Text,
                    Description = (string.IsNullOrWhiteSpace(DescriptionTextBox.Text)) ? null : DescriptionTextBox.Text,
                    StartDate = dtpStartDate.SelectedDate.GetValueOrDefault(DateTime.Now),
                    Deadline = dtpDeadline.SelectedDate.GetValueOrDefault(DateTime.Now),
                    State = (dtpStartDate.SelectedDate > DateTime.Now) ? "Programado" : "Pendiente",
                    FileContent = (string.IsNullOrWhiteSpace(txtFilePath.Text)) ? null : File.ReadAllBytes(txtFilePath.Text),
                    CreatorUser = User
                };

                MessageBox.Show(projectLogic.Add(project));
                LoadGridData();
            }
        }

        private bool ValidateCreateProjectPopup()
        {
            if (string.IsNullOrWhiteSpace(txtProjectName.txtData.Text))
            {
                MessageBox.Show("Digite un nombre para el proyecto.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (dtpDeadline.SelectedDate == null)
            {
                MessageBox.Show("Seleccione una fecha límite", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            return true;
        }

        private void PopupNewProject_Closed(object sender, EventArgs e)
        {
            tgbNewProject.IsChecked = false;
        }
    }
}
