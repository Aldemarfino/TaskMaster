using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Lógica de interacción para CalendarView.xaml
    /// </summary>
    public partial class CalendarView : UserControl
    {
        List<DateTime> fechasSeleccionadas = new List<DateTime>
            {
                new DateTime(2024, 12, 5),
                new DateTime(2024, 12, 10),
                new DateTime(2024, 12, 15)
            };
        public CalendarView()
        {
            InitializeComponent();
        }

        private void projectsCalendar_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void projectsCalendar_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {

        }

        private void HighlightDates()
        { // Lista de fechas importantes
            List<DateTime> importantDates = new List<DateTime>
            {
              new DateTime(2024, 12, 25),
              new DateTime(2024, 12, 1),
              new DateTime(2024, 12, 20)
            };

            projectsCalendar.DisplayDateChanged += (s, e) => UpdateHighlightedDates(importantDates);
            UpdateHighlightedDates(importantDates);

        }

        private void UpdateHighlightedDates(List<DateTime> importantDates)
        {
            var calendarItem = GetCalendarItem(projectsCalendar);
            if (calendarItem != null) 
            { 
                foreach (var button in GetCalendarDayButtons(calendarItem)) 
                { 
                    if (button.DataContext is DateTime date && importantDates.Contains(date)) 
                    { 
                        button.Background = Brushes.OrangeRed; button.Foreground = Brushes.White; 
                    } 
                } 
            }
        }

        private IEnumerable<CalendarDayButton> GetCalendarDayButtons(object calendarItem)
        {
            var monthViewField = calendarItem.GetType().GetField("MonthView", BindingFlags.NonPublic | BindingFlags.Instance);
            var monthView = monthViewField.GetValue(calendarItem) as UIElement; 
            var buttonsField = monthView.GetType().GetField("_dayButtons", BindingFlags.NonPublic | BindingFlags.Instance); 
            var buttons = buttonsField.GetValue(monthView) as CalendarDayButton[]; 
            return buttons;
        }

        private object GetCalendarItem(System.Windows.Controls.Calendar projectsCalendar)
        {
            var calendarItem = projectsCalendar.Template.FindName("PART_CalendarItem", projectsCalendar) as CalendarItem; 
            return calendarItem;
        }
    }
}
