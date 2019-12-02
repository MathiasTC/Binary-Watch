using Obl1Dm2Sem.ViewModel;
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
using System.Threading;

namespace Obl1Dm2Sem
{
    /// <summary>
    /// Interaction logic for HexPage.xaml
    /// </summary>
    public partial class HexPage : Page
    {
        ClockViewModel clock = new ClockViewModel();
        public HexPage()
        {
            InitializeComponent();
            DataContext = clock.HexClock;
            Thread threadClock = new Thread(clock.Run);
            threadClock.Start();
        }
    }
}
