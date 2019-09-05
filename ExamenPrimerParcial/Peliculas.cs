using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Peliculas
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string PaisDeOrigen { get; set; }
        public string Sinopsis { get; set; }
        public List<Playlists> Playlists1 { get; set; }
        private int _año;
        public int Año
        {
            get
            {
                return _año;
            }

            set
            {
                if (value >= 1800 && value <= 2019)
                {
                    _año = value;
                }

                else
                {
                    throw new Exception("Películas solo del año 1800 al 2019");
                }
            }
        }

        private int _duraciondeminutos;
        public int DuracionDeMinutos
        {
            get
            {
                return _duraciondeminutos;
            }

            set
            {
                if (value < 0)
                {
                    _duraciondeminutos = value;
                }

                else
                {
                    throw new Exception("Todas las películas duran más de 0 minutos");
                }
            }
        }

        private double _rantingimdb;
        public double RantingImdb
        {
            get
            {
                return _rantingimdb;
            }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    _rantingimdb = value;
                }

                else
                {
                    throw new Exception("La calificación debe de ser del 1 al 10");
                }
            }
        }

        public Peliculas()
        {
            Titulo = "Sin titulo";
            Director = "Sin establecer";
            Genero = "No género";
            Sinopsis = "No hay";
        }

        public Peliculas(string titulo, string director, string genero, string sinopsis, int año, int duraciondeminutos, double rantingimdb)
        {
            Titulo = titulo;
            Director = director;
            Genero = genero;
            Sinopsis = sinopsis;
        }

        public Peliculas(string titulo, int año)
        {
            Titulo = titulo;
            Año = año;
        }
    }
}
