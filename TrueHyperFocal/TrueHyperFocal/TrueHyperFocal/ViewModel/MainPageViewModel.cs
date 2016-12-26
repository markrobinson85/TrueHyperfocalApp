using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
    }
}
