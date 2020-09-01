using System;
//Creo que debería haber otra clase que convierta la moneda a pesos ya que sino violaría el principio SRP
namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a) 
        {
            Double pesos = Conversor.ConvertirAPesos;
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        
        }
    }
}