using System;
using System.Collections.ObjectModel;

namespace EnlaceDeDatos
{
    public class Datos : NotificationObject
    {
        private ObservableCollection<Disco> discos;

        public ObservableCollection<Disco> Discos
        {
            get
            {
                return discos;
            }
            set
            {
                discos = value;
                OnPropertyChanged();
            }
        }

        private Disco discoSeleccionado;

        public Disco DiscoSeleccionado
        {
            get
            {
                return discoSeleccionado;
            }
            set
            {
                discoSeleccionado = value;
                OnPropertyChanged();
            }
        }

        public MyCommand AgregarDiscoCommand { get; set; }

        public Datos()
        {
            /*
let it be 8 May 1970
revolver 6 aug 1966
help! 6 aug 1965
 var datos1 = Resources["datos1"] as Datos;
            datos1.Discos.Add(new Disco() { Banda = "Nirvana", Titulo = "Nevermind" });
            datos1.Discos.Add(new Disco() { Banda = "Nirvana", Titulo = "Nevermind" });
*/

            Discos = new ObservableCollection<Disco>();
            Discos.Add(new Disco()
            {
                Banda = "The Beatles",
                Titulo = "Help!",
                Genero = "Rock and Roll",
                FechaLanzamiento = new DateTime(1965, 8, 6),
                Portada = "Help.jpg",
                Precio = (decimal)4.5
            });
            Discos.Add(new Disco()
            {
                Banda = "The Beatles",
                Titulo = "Revolver",
                Genero = "Rock and Roll",
                FechaLanzamiento = new DateTime(1966, 8, 6),
                Portada = "Revolver.jpg",
                Precio = (decimal)5
            });
            Discos.Add(new Disco()
            {
                Banda = "The Beatles",
                Titulo = "Let it be",
                Genero = "Rock and Roll",
                FechaLanzamiento = new DateTime(1970, 5, 8),
                Portada = "LetItBe.jpg",
                Precio = 8
            });
            AgregarDiscoCommand = new MyCommand(AgregarDiscoCommandExecute, AgregarDiscoCommandCanExecute);  
        }

        private void AgregarDiscoCommandExecute()
        {
            //HACER ESTO ES LO MISMO QUE HACER LO DE ABAJO
            //var datos1 = Resources["datos1"] as Datos;
            //datos1.Discos.Add(new Disco() { Banda = "Nirvana", Titulo = "Nevermind" });

            Discos.Add(new Disco() { Banda = "Nirvana", Titulo = "Nevermind", Precio=1, FechaLanzamiento = new DateTime(1996,01,01) });
            AgregarDiscoCommand.ReevaluateCanExecute();
        }
        private bool AgregarDiscoCommandCanExecute()
        {
            return Discos.Count < 10;
        }
    }
}