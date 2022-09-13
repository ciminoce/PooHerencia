using System;
using System.Collections.Generic;
using PooHerencia.Entidades;

namespace PooHerencia.Datos
{
    public class Repositorio
    {
        private List<Publicacion> lista;

        public Repositorio()
        {
            lista = new List<Publicacion>();
        }

        public static bool operator ==(Repositorio r, Publicacion p)
        {
            foreach (var publicacion in r.lista)
            {
                if (publicacion == p)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Repositorio r, Publicacion p)
        {
            return !(r == p);
        }

        public static bool operator +(Repositorio r, Publicacion p)
        {

            if (r!=p)
            {
                r.lista.Add(p);
                return true;

            }

            return false;
        }

        public int GetCantidad => lista.Count;

        public Publicacion this[int index]
        {

            get
            {
                if (index < lista.Count)
                {
                    return lista[index];
                }

                throw new ArgumentException("Indice fuera de rango");

            }
        }
    }
}
