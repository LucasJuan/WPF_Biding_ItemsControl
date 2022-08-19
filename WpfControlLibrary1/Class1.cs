using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Class1
    {

        private UserControl2 _userControl2;
        private int _boundNumber;

        public Class1(UserControl2 userControl2)
        {
            _userControl2 = userControl2;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public int BoundNumber
        {
            get { return _boundNumber; }
            set
            {
                if (_boundNumber != value)
                {
                    _boundNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
