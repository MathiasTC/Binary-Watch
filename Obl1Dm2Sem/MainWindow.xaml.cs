using Obl1Dm2Sem.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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

namespace Obl1Dm2Sem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClockViewModel clock = new ClockViewModel();
        public MainWindow()
        {            
            InitializeComponent();
            DataContext = clock;
            Thread threadClock = new Thread(clock.Run);
            threadClock.Start();
        }
        #region Buttons
        private void ButtonShowHex_Click(object sender, RoutedEventArgs e)
        {
            mainPage.Content = new HexPage();
        }
        private void ButtonShowDecimal_Click(object sender, RoutedEventArgs e)
        {
            mainPage.Content = new DecimalPage();
        }
        private void ButtonShowBin_Click(object sender, RoutedEventArgs e)
        {
            mainPage.Content = new BinaryPage();
        }
        #endregion
    }
}

