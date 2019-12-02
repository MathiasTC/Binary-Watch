using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Model.Obl1Dm2Sem
{
    class BinaryClock
    {
        DateTime date;
        #region Hours
        // Timer
        private LedBit[] hour10 = { new LedBit(), new LedBit() };

        public LedBit[] Hour10
        {
            get { return hour10; }
        }

        private LedBit[] hour1 = { new LedBit(), new LedBit(), new LedBit(), new LedBit() };

        public LedBit[] Hour1
        {
            get { return hour1; }
        }
        #endregion

        #region Minutes
        //Minutter
        private LedBit[] minute10 = { new LedBit(), new LedBit(), new LedBit() };

        public LedBit[] Minute10
        {
            get { return minute10; }
        }

        private LedBit[] minute1 = { new LedBit(), new LedBit(), new LedBit(), new LedBit() };

        public LedBit[] Minute1
        {
            get { return minute1; }
        }
        #endregion

        #region Seconds
        // Sekunder
        private LedBit[] second10 = { new LedBit(), new LedBit(), new LedBit() };

        public LedBit[] Second10
        {
            get { return second10; }
        }
        private LedBit[] second1 = { new LedBit(), new LedBit(), new LedBit(), new LedBit() };

        public LedBit[] Second1
        {
            get { return second1; }
        }
        #endregion
        #region Methods
        public async void RunClock()
        {
            while(true)           
            {
                CalcHour();
                CalcMinute();
                CalcSecond();
                await PutTaskDelay();
            }
        }
        public void CalcHour()
        {
            date = DateTime.Now;
            // Hour calculator
            string s10 = Convert.ToString((date.Hour / 10), 2).PadLeft(2, '0');
            Hour10[0].Bit = s10[1] == '1';
            string s20 = Convert.ToString((date.Hour / 10), 2).PadLeft(2, '0');
            Hour10[1].Bit = s20[0] == '1';

            string s1 = Convert.ToString((date.Hour % 10), 2).PadLeft(4, '0');
            Hour1[0].Bit = s1[3] == '1';
            string s2 = Convert.ToString((date.Hour % 10), 2).PadLeft(4, '0');
            Hour1[1].Bit = s2[2] == '1';
            string s3 = Convert.ToString((date.Hour % 10), 2).PadLeft(4, '0');
            Hour1[2].Bit = s3[1] == '1';
            string s4 = Convert.ToString((date.Hour % 10), 2).PadLeft(4, '0');
            Hour1[3].Bit = s4[0] == '1';
        }
        public void CalcMinute()
        {
            // Minute calculator
            string s10 = Convert.ToString((date.Minute / 10), 2).PadLeft(3, '0');
            Minute10[0].Bit = s10[2] == '1';
            string s20 = Convert.ToString((date.Minute / 10), 2).PadLeft(3, '0');
            Minute10[1].Bit = s20[1] == '1';
            string s30 = Convert.ToString((date.Minute / 10), 2).PadLeft(3, '0');
            Minute10[2].Bit = s30[0] == '1';

            string s1 = Convert.ToString((date.Minute % 10), 2).PadLeft(4, '0');
            Minute1[0].Bit = s1[3] == '1';
            string s2 = Convert.ToString((date.Minute % 10), 2).PadLeft(4, '0');
            Minute1[1].Bit = s2[2] == '1';
            string s3 = Convert.ToString((date.Minute % 10), 2).PadLeft(4, '0');
            Minute1[2].Bit = s3[1] == '1';
            string s4 = Convert.ToString((date.Minute % 10), 2).PadLeft(4, '0');
            Minute1[3].Bit = s4[0] == '1';
        }
        public void CalcSecond()
        {            
            // Second calculator
            string s10 = Convert.ToString((date.Second / 10), 2).PadLeft(3, '0');
            Second10[0].Bit = s10[2] == '1';
            string s20 = Convert.ToString((date.Second / 10), 2).PadLeft(3, '0');
            Second10[1].Bit = s20[1] == '1';
            string s30 = Convert.ToString((date.Second / 10), 2).PadLeft(3, '0');
            Second10[2].Bit = s30[0] == '1';

            string s1 = Convert.ToString((date.Second % 10), 2).PadLeft(4, '0');
            Second1[0].Bit = s1[3] == '1';
            string s2 = Convert.ToString((date.Second % 10), 2).PadLeft(4, '0');
            Second1[1].Bit = s2[2] == '1';
            string s3 = Convert.ToString((date.Second % 10), 2).PadLeft(4, '0');
            Second1[2].Bit = s3[1] == '1';
            string s4 = Convert.ToString((date.Second % 10), 2).PadLeft(4, '0');
            Second1[3].Bit = s4[0] == '1';
        }
        private async Task PutTaskDelay()
        {
            await Task.Delay(500);
        }
        #endregion
    }
}
