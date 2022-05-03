using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PaginasBinding.Models
{
    public class NumerosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnProperyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private int _Valor;
        public int Valor
        {
            get { return this._Valor; }
            set
            {
                this._Valor = value;
                OnProperyChanged("Valor");
            }
        }
    }
}
