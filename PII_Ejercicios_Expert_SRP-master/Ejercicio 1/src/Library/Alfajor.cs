using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
         public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
        public Double Dinero {get;set;}
        public Alfajor(double precioMasa, double precioDulce, double Dinero)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
            this.Dinero = this.Dinero.ConvertirAPesos;
        }
        
        public string PuedeComprar (double Dinero, double PrecioMasa, double PrecioDulce)
        {

            if (this.Dinero >= this.PrecioDulce + this.PrecioMasa)
            {

                Console.WriteLine("Felicidades puede comprar alfajor");
            }
            else
            {
                Console.WriteLine("No puede comprarlo");
            }

        }
        
       
    }
}