using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Obl1Dm2Sem.Model
{
    class DecimalClock : INotifyPropertyChanged
    {
        private string decimalClock;
        public string DecimalClockProp
        {
            get { return decimalClock; }
            set
            {
                decimalClock = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #region Methods
        public async void RunClock()
        {
            while (true)
            {
                DecimalClockProp = DateTimeToString();
                await PutTaskDelay();
            }                           
        }
        public string DateTimeToString()
        {
            DateTime date = DateTime.Now;
            string decimalTime = date.ToString("hh:mm:ss");
            return decimalTime;
        }
        public async Task PutTaskDelay()
        {
            await Task.Delay(500);
        }
        #endregion 
    }
}
