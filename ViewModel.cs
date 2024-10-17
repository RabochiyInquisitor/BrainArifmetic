using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MyTest
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string _currentTheme = LocalStorage.GetValue();
        public string CurrentTheme
        {
            get => _currentTheme;
            set
            {
                if (_currentTheme != value) {
                    _currentTheme = value;
                    OnPropertyChanged(nameof(CurrentTheme));
                  

                }

            }

        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

