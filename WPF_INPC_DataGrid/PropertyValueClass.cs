using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INPC_DataGrid
{
    /// <summary>
    /// Этот класс используется для создания пары свойство-значение для вывода свойств в DataGrid.
    /// </summary>
    public class PropertyValueClass : INotifyPropertyChanged
    {
        private string _property;

        public string property
        {
            get { return _property; }
            set { _property = value; OnPropertyChanged(); }
        }

        private dynamic _value;

        public dynamic value
        {
            get { return _value; }
            set { _value = value; OnPropertyChanged(); }
        }

        private dynamic _value1;

        public dynamic value1
        {
            get { return _value1; }
            set { _value1 = value; OnPropertyChanged(); }
        }


        private dynamic _value2;

        public dynamic value2
        {
            get { return _value2; }
            set { _value2 = value; OnPropertyChanged(); }
        }

        private dynamic _value3;

        public dynamic value3
        {
            get { return _value3; }
            set { _value3 = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }


}
