using PaginasBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.ViewModels
{
    public class TablaMultiplicarViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }

        }
        private int _Numero;
        public int Numero
        {
            get { return this._Numero; }
            set { this._Numero = value;
                RaisePropertyChanged("Numero");
            }
        }
        private List<ModelTabla> _Tabla;
        public List<ModelTabla> Tabla {
            get { return _Tabla; }
            set {
                this._Tabla = value;
                RaisePropertyChanged("Tabla");
            }
        }
        public List<ModelTabla> GenerarTabla()
        {
            List<ModelTabla> tabla = new List<ModelTabla>();
            for(int i = 1; i <= 20; i++)
            {
                tabla.Add(new ModelTabla()
                {
                    Operacion = this.Numero + " x " + i,
                    Resultado = this.Numero * i
                }); ;
            }
            return tabla;
        }

        public Command MostrarTabla {
            get {
                return new Command(()=> {
                    this.Tabla = GenerarTabla();
                }); 
            } 
        }

    }
}
