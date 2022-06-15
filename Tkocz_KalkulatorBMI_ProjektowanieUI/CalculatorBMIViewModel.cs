using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tkocz_KalkulatorBMI_ProjektowanieUI
{
    public class CalculatorBMIViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        private string _height;

        public string height
        {
            get { return _height; }
            set { _height = value;
                OnPropertyChanged("height");
            }
        }
        private string _weight;

        public string weight
        {
            get { return _weight; }
            set { _weight = value;
                OnPropertyChanged("weight");
            }
        }
        private string _resultBMI;

        public string resultBMI
        {
            get { return _resultBMI; }
            set { _resultBMI = value; }
        }
        public void calculateBMI()
        {
            _resultBMI=CalculateBMIModel.GetResult(height, weight);
            OnPropertyChanged("resultBMI");
        }

    }
}
