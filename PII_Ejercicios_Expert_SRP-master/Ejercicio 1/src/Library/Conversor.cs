using System;

namespace Expert_SRP
{
    public class Conversor
    {
        public double dinero {get;set;}

        public double moneda {get;set;}

        public double ConvertirAPesos(double Dinero, double Moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                this.dinero = Dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                this.dinero = Dinero;
            }
            else 
            {
                this.dinero = -1;
            }
        }
}