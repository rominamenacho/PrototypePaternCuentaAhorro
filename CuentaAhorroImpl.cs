using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
   public class CuentaAhorroImpl : ICuenta
    {
        public string Tipo { get; set; }
        public double Monto { get; set; }

        public CuentaAhorroImpl()
        {
            Tipo = "AHORRO";
        }

       public ICuenta Clonar()
        {
            CuentaAhorroImpl cuenta = null;
            try
            {
                cuenta = (CuentaAhorroImpl) MemberwiseClone();
            }catch(Exception e)
            {
              Console.WriteLine( e.Message);
            }
            return cuenta;
        }
  
      
       
    }
}
