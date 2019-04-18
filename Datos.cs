using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EnlaceDeDatos
{
    public class Datos : NotificationObject
    {
        public ObservableCollection<Disco> disco;

        public ObservableCollection<Disco> Disco
        {
            get { return disco; }
            set
            {
                disco = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Disco> discos;
        public ObservableCollection<Disco> Discos
        {
            get {  return discos; }
            set
            {
                discos = value;
                OnPropertyChanged();
            }
        }
        private Disco discoSeleccionado;
        public Disco DiscoSeleccionado
        {
            get { return discoSeleccionado; }
            set
            {
                discoSeleccionado = value;
                OnPropertyChanged();
            }
        }

        public Datos()
        {
            Discos = new ObservableCollection<Disco>();
            Discos.Add(new Disco() { Banda = "The Beatles", Titulo = "Help!", Genero=  "Pop" });
            Discos.Add(new Disco() { Banda = "The Beatles", Titulo = "Revolver!", Genero=  "Rock" });
            Discos.Add(new Disco() { Banda = "The Beatles", Titulo = "Velvet!", Genero=  "Rock" });
        }


    }
}
