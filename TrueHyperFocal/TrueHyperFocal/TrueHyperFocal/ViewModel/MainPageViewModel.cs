using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TrueHyperFocal.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        bool busy;
        public bool IsBusy
        {
            get { return busy; }
            set {
                busy = value;
                OnPropertyChanged();

            }
        }
        private HyperfocalCalculator calc = new HyperfocalCalculator();
        public MainPageViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            var changed = PropertyChanged;

            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(name));
        }

        decimal distance;
        public decimal Distance
        {
            get { return distance; }
            set
            {
                distance = value;
                OnPropertyChanged();
            }
        }

        decimal focalLength;
        
        public decimal FocalLength
        {
            get { return focalLength; }
            set
            {
                focalLength = value;
                OnPropertyChanged();
            }
        }

        decimal fStop;
        public decimal FStop
        {
            get { return fStop; }
            set
            {
                fStop = value;
                OnPropertyChanged();
            }
        }

        decimal trueDistance;
        public decimal TrueDistance
        {
            get { return trueDistance; }
            set
            {
                trueDistance = value;
                OnPropertyChanged();
            }
        }

        ICommand calculateCommand;

        public ICommand CalculateCommand =>
            calculateCommand ??
            (calculateCommand = new Command(() => Calculate()));

        private void Calculate()
        {
            // Not really necessary for this simple of an 
            if (IsBusy)
                return;

            TrueDistance = calc.Calculate(FocalLength, Distance, FStop);

        }
    }
}
