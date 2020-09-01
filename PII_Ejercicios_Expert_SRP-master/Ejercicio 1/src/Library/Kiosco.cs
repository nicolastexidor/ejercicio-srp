using System;

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