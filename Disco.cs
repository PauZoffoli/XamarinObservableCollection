using System;
using System.Collections.Generic;
using System.Text;

namespace EnlaceDeDatos
{
    public class Disco:NotificationObject 
    {
        

        private string titulo;

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
                OnPropertyChanged();
            }
        }



        private string banda;
        public string Banda
        {
            get
            {
                return banda;
            }

            set
            {
                banda = value;
                OnPropertyChanged();
            }
        }

        private string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; OnPropertyChanged(); }
        }

        public override string ToString()
        {
            return $"{Titulo} {Banda} {Genero}";
        }
    }
}
