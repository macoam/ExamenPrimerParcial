using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Playlists
    {
        private string v;

        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public object Jugadores { get; internal set; }
        public object Playlists1 { get; internal set; }

        public Playlists()
        {
            Titulo = "Ted";
            Descripcion = "Un oso que cobra vida para hacer féliz a su dueño.";
        }

        public Playlists(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
        }

        public Playlists(string v)
        {
            this.v = v;
        }
    }

}
