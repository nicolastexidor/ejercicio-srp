using System;
//Creo que debería haber otra clase que convierta la moneda a pesos ya que sino violaría el principio SRP
namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}