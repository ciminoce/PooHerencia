using System;
using Microsoft.VisualBasic.CompilerServices;

namespace PooHerencia.Entidades
{
    public class Publicacion
    {
        private string titulo;
        private int paginas;
        protected DateTime fechaPublicacion;
        public Publicacion(string Titulo, int Paginas)
        {
            titulo = Titulo;
            paginas = Paginas;
            fechaPublicacion=DateTime.Today;
        }
        public string Titulo => titulo;
        public int Paginas => paginas;

        public string MostrarDatos()
        {
            return $"Título: {titulo} - Pág.:{paginas} - Fec. Pub:{fechaPublicacion.ToShortDateString()}";
        }
    }
}
