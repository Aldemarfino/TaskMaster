using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Presentation.UserControls
{
    /// <summary>
    /// Lógica de interacción para ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string TextBlockContent;
        public string textBlockContent
        {
            get { return TextBlockContent; }
            set 
            {
                TextBlockContent = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TextBlockContent"));
            }
        }

       public ClearableTextBox()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            txtData.Text = string.Empty;
            txtData.Focus();
        }

        private void txtData_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtData.Text))
            {
                txtbBackText.Visibility = Visibility.Visible;
            }
            else
            {
                txtbBackText.Visibility = Visibility.Hidden;
            }
        }
    }
}
