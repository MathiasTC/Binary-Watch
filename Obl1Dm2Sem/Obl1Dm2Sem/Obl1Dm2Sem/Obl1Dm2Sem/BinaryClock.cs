using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Obl1Dm2Sem
{
    class BinaryClock 
    {
        static Random rnd = new Random(); //for test purpose only, remove in final version
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
        
        public async void Demo()
        {
            for (int i = 0; i < 80; i++)
            {
                Hour10[0].Bit = rnd.Next(2) == 1;
                Hour10[1].Bit = rnd.Next(2) == 1;
                hour1[0].Bit = rnd.Next(2) == 1;
                hour1[1].Bit = rnd.Next(2) == 1;
                hour1[2].Bit = rnd.Next(2) == 1;
                hour1[3].Bit = rnd.Next(2) == 1;

                await PutTaskDelay();
            }
        }

        private async Task PutTaskDelay()
        {
            await Task.Delay(500);
        }

        private LedBit[] makeLed(int size)
        {
            LedBit[] led = new LedBit[size];
            for (int i = 0; i < led.Length; i++)
                led[i] = new LedBit();
            return led;
        }
    }
}
