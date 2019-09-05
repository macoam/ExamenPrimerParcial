using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Playlists
    {

        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Peliculas> Peliculas1 { get; set; }

        public Playlists()
        {
            Titulo = "No tiene";
            Descripcion = "No hay";
            Peliculas1 = new List<Peliculas>();
        }


        public Playlists(string titulo)
        {
            Titulo = titulo;
            Descripcion = "Sin Descripción";
            Peliculas1 = new List<Peliculas>();
        }

    }

}
