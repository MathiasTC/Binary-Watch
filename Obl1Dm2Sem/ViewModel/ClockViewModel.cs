using Model.Obl1Dm2Sem;
using Obl1Dm2Sem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Obl1Dm2Sem.ViewModel
{
    class ClockViewModel
    {
        BinaryClock binaryClock = new BinaryClock();
        HexClock hexClock = new HexClock();
        DecimalClock decClock = new DecimalClock();
        public HexClock HexClock { get => hexClock; }
        public LedBit[] Hour10
        {
            get { return binaryClock.Hour10; }
        }

        public LedBit[] Hour1
        {
            get { return binaryClock.Hour1; }
        }

        public LedBit[] Minute10
        {
            get { return binaryClock.Minute10; }
        }

        public LedBit[] Minute1
        {
            get { return binaryClock.Minute1; }
        }

        public LedBit[] Second10
        {
            get { return binaryClock.Second10; }
        }

        public LedBit[] Second1
        {
            get { return binaryClock.Second1; }
        }
        public HexClock HexDecimal
        {
            get { return HexDecimal; }
            set { hexClock = value; }
        }
        public DecimalClock DecimalTime
        {
            get { return decClock; }
            set { decClock = value; }            
        }
        public void Run()
        {
            binaryClock.RunClock();
            hexClock.RunClock();
            decClock.RunClock();
        }
    }
}
