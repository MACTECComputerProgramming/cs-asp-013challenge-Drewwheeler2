using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
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

namespace CS_ASP_013_Drew_Wheeler_Subs
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

        private void buttonOrderHere_Click(object sender, RoutedEventArgs e)
        {
            labelAnswer.Content = "  ";
            labelCost.Content = "   ";
            //choices
            string subsize = "";
            string meat = "";
            string bread = "";
            string american = "";
            string swiss = "";
            string pepperjack = "";
            string cucumber = "";
            string greenpepper = "";
            string lettuce = "";
            string redoinion = "";
            string allveggies = "";

            //cost
            double cost = 0;
            double greenpeppercost = 0;
            double lettucecost = 0;
            double redonioncost = 0;

            //subsize
            if (radioButtonSixInch.IsChecked == true)
            {
                subsize = "Six Inch Sub, ";
                cost = cost + 3.50;
            }
            else if (radioButtonFootLong.IsChecked == true)
            {
                subsize = "Foot Long Sub, ";
                cost = cost + 5.00;
            }

            //bread
            if (radioButtonWheat.IsChecked == true)
            {
                bread = "Wheat, ";
            }
            else if (radioButtonItalian.IsChecked == true)
            {
                bread = "Italian, ";
            }
            else if (radioButtonFlatBread.IsChecked == true)
            {
                bread = "Flatbread, ";
                cost = cost + .5;
            }

            //meat
            if (radioButtonFlatBread1.IsChecked == true)
            {
                meat = "Ham, ";
            }
            else if (radioButtonRoasted.IsChecked == true)
            {
                meat = "Roasted Chicken, ";
            }
            else if (radioButtonMeatBall.IsChecked == true)
            {
                meat = "MeatBall, ";
                cost = cost + 1.00;
            }
            else if (radioButtonSteak.IsChecked == true)
            {
                meat = "Steak, ";
                cost = cost + 1.50;
            }

            //cheese
            if (checkBoxAmerican.IsChecked == true)
            {
                american = "American Cheese, ";
                cost = cost + .25;
            }
            else if (checkBoxPepperJack.IsChecked == true)
            {
                american = "Pepper Jack, ";
                cost = cost + .75;
            }
            else if (checkBoxSwiss.IsChecked == true)
            {
                american = "Swiss, ";
                cost = cost + .30;
            }

            //veggies
            if (checkBoxCucumber.IsChecked == true)
            {
                cucumber = "Cucumber, ";
            }
            if (checkBoxGreenPepper.IsChecked == true)
            {
                greenpepper = "Green Pepper, ";
                greenpeppercost = .25;
            }
            if (checkBoxLettuce.IsChecked == true)
            {
                lettuce = "Lettuce, ";
                lettucecost = .15;
            }
            if (checkBoxRedOnion.IsChecked == true)
            {
                redoinion = "Red Onion, ";
                redonioncost = .10;
            }
            if (checkBoxAllVeggies.IsChecked == true)
            {
                allveggies = "All Veggies, ";
                cost = cost + .25 - greenpeppercost - lettucecost - redonioncost;
            }

            if ((radioButtonFootLong.IsChecked == true) && (radioButtonWheat.IsChecked == true) && (radioButtonMeatBall.IsChecked == true) && (checkBoxAmerican.IsChecked == true))
            {
                cost = cost - 2.00;
            }

            cost = cost + greenpeppercost + lettucecost + redonioncost;
            labelAnswer.Content = subsize + bread + meat + american + swiss + pepperjack + cucumber + greenpepper + lettuce + redoinion + allveggies;
            labelCost.Content = "$" + cost;


        }
    }
}
