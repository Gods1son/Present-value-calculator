using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Present_value_calculator
{
    class VM: INotifyPropertyChanged
    {
        public double FutureValue
        {
            get { return _futureValue; }
            set { _futureValue = value; OnPropertyChanged(); }
        }
        private double _futureValue;
        public double Rate
        {
            get { return _rate; }
            set { _rate = value; OnPropertyChanged(); }
        }
        private double _rate;
        public double Years
        {
            get { return _years; }
            set { _years = value; OnPropertyChanged(); }
        }
        private double _years;
        public double PV
        {
            get { return _pV; }
            set { _pV = value; OnPropertyChanged(); }
        }
        private double _pV;
        public double CalcPresentValue()
        {
            double money = 0;
            money = FutureValue/(Math.Pow((1 + (Rate/100)), Years));
            return money;
        }
        public void docalc()
        {
           PV = CalcPresentValue();
        }
        public void clear()
        {
            FutureValue = 0;
            Rate = 0;
            Years = 0;
            PV = 0;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
