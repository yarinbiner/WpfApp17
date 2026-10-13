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

namespace WpfApp17
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

        private void ArrivingCal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            int pricePerNight = 0;
            int satPrice = 0;
            var hotel = ((ComboBoxItem)hotelBox.SelectedItem) .Content.ToString();
            if (hotel == "MARRIOT")
            {
                pricePerNight = 500;
                satPrice = 1200;
            }
            if (hotel == "HYATT")
            {
                pricePerNight = 800;
                satPrice = 2000;
            }
            if (hotel == "HILTON")
            {
                pricePerNight = 300;
                satPrice = 700;
            }
            if (leavingCal.SelectedDate != null && leavingCal.SelectedDate.Value != null)
            {
                nightsNum.Text = $"NIGHTS: {(leavingCal.SelectedDate.Value - arrivingCal.SelectedDate.Value).Days}";
                int sum = 0;
                for (var i = arrivingCal.SelectedDate.Value; i < leavingCal.SelectedDate.Value; i = i.AddDays(1))
                {
                    if (i.DayOfWeek == DayOfWeek.Saturday)
                    {
                        sum += satPrice;
                    }
                    else
                        sum += pricePerNight;
                }
                price.Text = $"PRICE: {sum} ₪" ;


            }
        }

        private void Chosing_Arrival_Date(object sender, RoutedEventArgs e)
        {
            arrivingCal.Visibility = Visibility.Visible;

        }

        private void LeavingCal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            int pricePerNight =0;
            int satPrice = 0;
            var hotel = ((ComboBoxItem)hotelBox.SelectedItem)
               .Content.ToString();
            if(hotel == "MARRIOT")
            {
                pricePerNight = 500;
                satPrice = 1200;
            }
            if(hotel == "HYATT")
            {
                pricePerNight = 800;
                satPrice = 2000;
            }
            if (hotel == "HILTON")
            {
                pricePerNight = 300;
                satPrice = 700;
            }

           

            if (arrivingCal.SelectedDate != null && arrivingCal.SelectedDate.Value != null)
            {
                nightsNum.Text = $"NIGHTS: {(leavingCal.SelectedDate.Value - arrivingCal.SelectedDate.Value).Days}";
                int sum = 0;
                for (var i = arrivingCal.SelectedDate.Value; i < leavingCal.SelectedDate.Value; i = i.AddDays(1))
                {
                    if (i.DayOfWeek == DayOfWeek.Saturday)
                    {
                        sum += satPrice;
                    }
                    else
                        sum += pricePerNight;
                }
                price.Text = $"PRICE: {sum} ₪";
            }

        }

        private void Chosing_Leaving_Date(object sender, RoutedEventArgs e)
        {
            leavingCal.Visibility = Visibility.Visible;
        }

        private void Selected(object sender, RoutedEventArgs e)
        {
            if(sender is RadioButton selctedRadio)
            {
                string hotel = selctedRadio.Content.ToString();
                if (hotel == "Single")
                {
                    MessageBox.Show("Your treats are : 1 chochlate and a bottle of water");
                }
                else if (hotel == "Double")
                {
                    MessageBox.Show("Your treats are : 2 chochlate and a bottle of wine");
                }
                else if (hotel == "Triple")
                {
                    MessageBox.Show("Your treats are : 3 chochlate and a snacks");
                }
                else if(hotel == "Family")
                {
                    MessageBox.Show("Your treats are : 4 chochlate  2 snacks and a bottle of wine");
                }


            }
        }
    }
}