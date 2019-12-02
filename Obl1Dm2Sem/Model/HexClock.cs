using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Obl1Dm2Sem.Model
{
    class HexClock : INotifyPropertyChanged
    {
        DateTime date = DateTime.Now;
        private string hexDecimal;
        public string HexDecimal
        {
            get { return hexDecimal; }
            set
            {
                hexDecimal = value;
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
                HexDecimal = ConvertDateTimeToHex();
                await PutTaskDelay();
            }
        }
        public string ConvertDateTimeToHex()
        {
            date = DateTime.Now;
            string dateHexSecond = date.Second.ToString("x");
            string dateHexMinute = date.Minute.ToString("x");
            string dateHexHour = date.Hour.ToString("x");
            string finalHexDecimal = string.Format("{0} {1} {2}", dateHexHour, dateHexMinute, dateHexSecond);
            return finalHexDecimal;
        }
        public async Task PutTaskDelay()
        {
            await Task.Delay(500);
        }
        #endregion  
    }    
}
