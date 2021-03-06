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
namespace Tkocz_KalkulatorBMI_ProjektowanieUI
{
    /// <summary>
    /// Interaction logic for calculatorBMI.xaml
    /// </summary>
    public partial class calculatorBMI : Window
    {
        CalculatorBMIViewModel CalculatorBMIViewModel = new CalculatorBMIViewModel();
        public calculatorBMI()
        {
            InitializeComponent();
            DataContext = CalculatorBMIViewModel;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            CalculatorBMIViewModel.calculateBMI();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
