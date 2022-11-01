using oop_task_1_console_p_20_1_Pavlov.Core;
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

namespace oop_task_1_wpf_p_20_1_Pavlov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Adress adress = new Adress();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{adress.Index}, {adress.Counrty}, {adress.City}, {adress.Street}, {adress.House}, {adress.Apartment}");
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            adress.Index = TxtBoxIndex.Text;
            adress.Counrty = TxtBoxCountry.Text;
            adress.City = TxtBoxCity.Text;
            adress.Street = TxtBoxStreet.Text;
            adress.House = TxtBoxHouse.Text;
            adress.Apartment = TxtBoxAppartment.Text;
        }
    }
}
