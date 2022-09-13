using System;
using PooHerencia.Datos;
using PooHerencia.Entidades;

namespace PooHerencia.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Publicacion pub = new Publicacion("Herencia en POO", 2);
            Libro libro1 = new Libro("Visual C#", 400, 123654, 5500,new DateTime(2020,10,10));
            Revista revista1 = new Revista("Users", 100, TipoRevista.Programacion, 500);


            Console.WriteLine(pub.MostrarDatos());
            Console.WriteLine(libro1.MostrarDatos());
            Console.WriteLine(revista1.MostrarDatos());

            Publicacion pub2 = new Libro("Diseño Web", 500, 32145, 6500, new DateTime(2022, 5, 27));
            Publicacion pub3 = new Revista("El Gráfico", 120, TipoRevista.Informacion_Gral, 160);
            if (pub2 is Libro)
            {
                Console.WriteLine(((Libro)pub2).MostrarDatos());
            }
            else
            {
                Console.WriteLine(pub2.MostrarDatos());
                
            }
            Console.WriteLine(pub3.MostrarDatos());

            var repo = new Repositorio();
            if (repo+libro1)
            {
                Console.WriteLine("Libro agregado");
            }
            else
            {
                Console.WriteLine("Libro no agregado");
            }
            if (repo + libro1)
            {
                Console.WriteLine("Libro agregado");
            }
            else
            {
                Console.WriteLine("Libro no agregado");
            }

            Console.WriteLine(repo.GetCantidad);
            var pub4 = repo[0];
           
            Console.ReadLine();
        }
    }
}
