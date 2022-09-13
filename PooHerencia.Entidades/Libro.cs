using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PooHerencia.Entidades
{
    public class Libro:Publicacion
    {
        private int isbn;
        private float precio;

        public Libro(string Titulo, int Paginas, int Isbn, float Precio, DateTime Fecha)
            :base(Titulo, Paginas)
        {
            isbn = Isbn;
            precio = Precio;
            fechaPublicacion = Fecha;
        }
        public int Isbn => isbn;

        public float Precio
        {
            get => precio;
            set => precio = value;
        }

        public new string MostrarDatos()
        {
            return $"{base.MostrarDatos()} - ISBN:{isbn}";
        }

        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is Libro))
            {
                return false;
            }

            return this.isbn == ((Libro)obj).isbn;
        }

        public static bool operator ==(Libro l1, Libro l2)
        {
            return l1.Equals(l2);
        }

        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }
    }
}
