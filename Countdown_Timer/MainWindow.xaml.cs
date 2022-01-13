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

namespace Countdown_Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan maths;
            DateTime Date = (DateTime)Calandar.SelectedDate;
            Date_Selected.Text = $"Date Selected :  {Date.ToShortDateString()}";

            if (Date > DateTime.Now)
            {
                maths = Date - DateTime.Now;
                Time_UntilDate.Text = $"Time until Date : {maths.Days} Days {maths.Hours} hours {maths.Minutes} Minutes";
            }
            else if (Date < DateTime.Now)
            {
                maths = DateTime.Now - Date;
                Time_UntilDate.Text = $"Time until Date : {maths.Days} Days {maths.Hours} hours {maths.Minutes} Minutes";
            }
            
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tblk_TodaysDate.Text = $"Todays Date : {DateTime.Now.ToShortDateString()}";
           
            
        }
    }
}
