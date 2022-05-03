using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.ViewModels
{
    public class TiempoViewModel : INotifyPropertyChanged
    {
        public void RaiseEventChanged(String propertyName)
        {
            if(PropertyChanged!= null)
            {
            PropertyChanged(this,
                new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public String Anyo { get; set; }
        public String Mes { get; set; }
        private String _Hora;
        public String Hora
        {
            get { return this._Hora; }
            set {
                this._Hora = value;
                RaiseEventChanged("Hora");
            }
        }


        public String Dia { get; set; }

        public DateTime _Tiempo;
        public DateTime Tiempo {
            get { return this._Tiempo; }
            set { this._Tiempo = DateTime.Now;
                RaiseEventChanged("Tiempo");
            }
        }
        public TiempoViewModel()
        {
            //this.Dia = DateTime.Now.DayOfWeek.ToString();
            //this.Mes = DateTime.Now.ToString("MMMM");
            //this.Anyo = "Year " + DateTime.Now.Year;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                //this.Hora = DateTime.Now.ToLongTimeString();
                this.Tiempo = DateTime.Now;
                return true;
            });
        }
    }
}
