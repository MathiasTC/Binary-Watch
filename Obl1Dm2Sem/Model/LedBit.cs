using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Model.Obl1Dm2Sem
{
    class LedBit : INotifyPropertyChanged
    {
        #region Properties
        public LedBit()
        {
            Bit = false;
        }
        private bool bit;
        public bool Bit
        {
            set 
            {                 
                bit = value;
                if (bit)
                {
                    EllipseColor = Colors.RoyalBlue;
                    EllipseWidth = EllipseHeight = 20;
                }
                else
                {
                    EllipseColor = Colors.WhiteSmoke;
                    EllipseWidth = EllipseHeight = 15;
                }                
            }
        }
        private Color ellipseColor;
        public Color EllipseColor
        {
            get { return ellipseColor; }
            private set
            {
                if (ellipseColor != value)
                {
                    ellipseColor = value;
                    OnPropertyChanged();
                }
            }
        }
        private int ellipseWidth;
        public int EllipseWidth
        {
            get { return ellipseWidth; }
            private set
            {
                if (ellipseWidth != value)
                {
                    ellipseWidth = value;
                    OnPropertyChanged();
                }
            }
        }
        private int ellipseHeight;
        public int EllipseHeight
        {
            get { return ellipseHeight; }
            private set
            {
                if (ellipseHeight != value)
                {
                    ellipseHeight = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
