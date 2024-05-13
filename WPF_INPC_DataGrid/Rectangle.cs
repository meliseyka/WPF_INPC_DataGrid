using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INPC_DataGrid
{
    public class Rectangle : INotifyPropertyChanged
    {
        private double _a;

        public double a
        {
            get { return _a; }
            set { _a = value; OnPropertyChanged(); }
        }

        private double _b;
                
        public double b
        {
            get { return _b; }
            set { _b = value; OnPropertyChanged(); }
        }

        private double _Square;

        public double Square
        {
            get { return _Square; }
            set { _Square = value; OnPropertyChanged(); }
        }

        public Rectangle(double a, double b)
        {
            this.a= a;
            this.b = b;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
