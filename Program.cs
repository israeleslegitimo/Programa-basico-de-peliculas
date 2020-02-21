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
          p1.setTitulo("parasitos");
          p1.setAño(2020);

          //
          p2.setTitulo("EL IRLANDÉS");
          p2.setAño(2020);

          
          //imprimir,
          Console.WriteLine("Titulo: "+p1.getTitulo());
          Console.WriteLine("Año:"+p1.getAño());

          Console.WriteLine("Titulo: "+p2.getTitulo());
          Console.WriteLine("Año:"+p2.getAño());
          




        }
    }
    class Peliculas
    {
        //crear atributos en publico
        private string Titulo,Pais,Director;
        private int Año;
        
        //creas los metodos
        public int getAño()
        {
            return Año;
        }

        public void setAño(int n)
        {
            Año=n;

        } 
        public string getTitulo()
        {
            return Titulo;
        }

        public void setTitulo(string m)
        {
            Titulo=m;
        }




        

    }
}