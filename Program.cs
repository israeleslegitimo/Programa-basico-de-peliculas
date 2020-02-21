using System;

namespace Peliculas
{
    class Program
    {
        
         static void Main(string[] args)
        {
            //crear dos objetos tipo pelicula
          Peliculas p1= new Peliculas();
          Peliculas p2 = new Peliculas();

          //
          p1.Titulo=("parasitos");
          p1.Año=2020;

          //
          p2.Titulo=("EL IRLANDÉS");
          p2.Año=2020;

          
          //imprimir,
          Console.WriteLine("Titulo: "+p1.Titulo);
          Console.WriteLine("Año:"+p1.Año);

          Console.WriteLine("Titulo: "+p2.Titulo);
          Console.WriteLine("Año:"+p2.Año);
          




        }
    }
    class Peliculas
    {
        //crear atributos en publico
        public string Titulo,Pais,Director;
        public int Año;

        

    }
}