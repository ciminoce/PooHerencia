using System;
using System.Collections.Generic;
using System.Text;

namespace PooHerencia.Entidades
{
    public class Revista:Publicacion
    {
        private float precio;
        private TipoRevista tipoRevista;

        
        public float Precio
        {
            get => precio;
            set => precio = value;
        }

        public TipoRevista TipoRevista
        {
            get => tipoRevista;
            set => tipoRevista = value;
        }

        public Revista(string Titulo, int paginas, TipoRevista Tipo, float Precio) : base(Titulo, paginas)
        {
            tipoRevista = Tipo;
            precio = Precio;
            fechaPublicacion = DateTime.Now.AddDays(-1);

        }
        public new string MostrarDatos()
        {
            return $"{base.MostrarDatos()} - Tipo Revista:{tipoRevista.ToString()}";
        }

    }
}
