using System;
//Creo que esta clase conoce demasiadas cosas (error de expert) y tiene más responsabilidades de las necesaria (error de srp).
//Se podría crear otra clase que sepa únicamente el SectorBiblioteca y el EstanteBiblioteca. 
//Además de esto, dicha clase debería tener la responsabilidad de AlmacenarLibro en lugar de esta.
//De esta forma si el libro cambiase de estante o de sector se podría cambiar fácilmente accediendo a la otra clase en lugar de entrar a esta que está llena de otra info.
namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
