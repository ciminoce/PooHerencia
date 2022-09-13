using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PooHerencia.Entidades
{
    public class RepositorioDePublicaciones
    {
        private List<Publicacion> lista;

        public RepositorioDePublicaciones()
        {
            lista = new List<Publicacion>();
        }

        public static bool operator +(RepositorioDePublicaciones r, Publicacion p)
        {
            if (r!=p)
            {
                r.lista.Add(p);
                return true;
            }
            return false;
        }

        public static bool operator ==(RepositorioDePublicaciones r, Publicacion p)
        {
            foreach (var publicacion in r.lista)
            {
                if (publicacion==p)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(RepositorioDePublicaciones r, Publicacion p)
        {
            return !(r == p);
        }
        public int GetCantidad() => lista.Count;

        public Publicacion this[int index] => lista[index];
    }
}
