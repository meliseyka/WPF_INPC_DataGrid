using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INPC_DataGrid.VM
{
    class ViewModel : INotifyPropertyChanged
    {
        private Rectangle _rectangle;

        public Rectangle rectangle
        {
            get { return _rectangle; }
            set { _rectangle = value; OnPropertyChanged(); }
        }

        private ObservableCollection<PropertyValueClass> _Geometry;

        public ObservableCollection<PropertyValueClass> Geometry
        {
            get { return _Geometry; }
            set { _Geometry = value; OnPropertyChanged(); }
        }



        public ViewModel()
        {
            rectangle = new Rectangle(10, 5);
            rectangle.Square = rectangle.a * rectangle.b;

            Geometry = new ObservableCollection<PropertyValueClass>
                {

                    new PropertyValueClass {property="a = ", value=Math.Round((decimal)(rectangle.a),1) },
                    new PropertyValueClass {property="b = ", value=Math.Round((decimal)(rectangle.b),1) },
                    new PropertyValueClass {property="Общая площадь поперечного сечения, ед.изм", value=Math.Round((decimal)(rectangle.Square),2) },
            };

        }

        private RelayCommand _UpdateRectangle;

        /// <summary>
        /// Команда, предназначенная для изменения Rectangle засчёт создания нового экземпляра (через конструктор)
        /// </summary>
        public RelayCommand UpdateRectangleByCtor
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    UpdateRectangleMethodByCtor();
                });
            }
        }

        private RelayCommand _UpdateRectangleByChangingProperties;

        /// <summary>
        /// Команда изменяет свойства Rectangle внешним кодом.
        /// </summary>
        public RelayCommand UpdateRectangleByChangingProperties
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    UpdateRectangleMethodByChangingProperties();
                });
            }
        }

        void UpdateRectangleMethodByCtor()
        {
            rectangle = new Rectangle(20, 20);
            rectangle.Square = rectangle.a * rectangle.b;
        }


        void UpdateRectangleMethodByChangingProperties()
        {
            rectangle.a = 15;
            rectangle.b = 30;
            rectangle.Square = rectangle.a * rectangle.b;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
