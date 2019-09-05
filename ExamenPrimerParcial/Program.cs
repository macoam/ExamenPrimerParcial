using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlists> playlists = new List<Playlists>();

            Playlists playlists1 = new Playlists("Playlist 1");


            playlists1.Descripcion = "Para un dia lluvioso";

            playlists1.Peliculas1.Add(new Peliculas("Como el deber", 2004));
            playlists1.Peliculas1.Add(new Peliculas("Tu y yo", 2013));
            playlists1.Peliculas1.Add(new Peliculas("Estoy a tus ordenes", 2009));
            playlists1.Peliculas1.Add(new Peliculas("Hoy te llevaré a casa", 1994));
            playlists1.Peliculas1.Add(new Peliculas("Me pondre de tu lado", 1834));
            playlists1.Peliculas1.Add(new Peliculas("Me gustas tanto", 2001));
            playlists1.Peliculas1.Add(new Peliculas("No tengas miedo", 1963));

            Playlists playlists2 = new Playlists("Playlist 2");

            playlists2.Descripcion = "Un dia en pareja";

            playlists2.Peliculas1.Add(new Peliculas("Eres un majo tío", 2007));
            playlists2.Peliculas1.Add(new Peliculas("A todo gas", 2016));
            playlists2.Peliculas1.Add(new Peliculas("Onda vital", 1982));
            playlists2.Peliculas1.Add(new Peliculas("¿Cómo te llamas?", 1993));
            playlists2.Peliculas1.Add(new Peliculas("¡Donde esta mi libro!", 1867));
            playlists2.Peliculas1.Add(new Peliculas("Te deseo lo mejor Angela", 2019));
            playlists2.Peliculas1.Add(new Peliculas("Quisiera tenerte entre mis brazos", 1924));

            playlists.Add(playlists1);
            playlists.Add(playlists2);

            foreach (Playlists playlist in playlists)
            {
                Console.WriteLine("\n Titulo: " + playlist.Titulo + "\n Descripción: " + playlist.Descripcion);
                Console.WriteLine("\n Peliculas: \n ");
                foreach (Peliculas peliculas in playlist.Peliculas1)
                {
                    Console.WriteLine("- " + peliculas.Titulo + " " + peliculas.Año);
                }
            }

            Console.Read();

        }
    }
}
