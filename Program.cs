using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaAhorroImpl cuentaUno = new CuentaAhorroImpl();
            cuentaUno.Monto=2000;

            CuentaAhorroImpl clonada = (CuentaAhorroImpl)cuentaUno.Clonar();

            if (clonada != null) Console.WriteLine("Clonada existe");
          

            Console.WriteLine($"Cuenta Clonada tiene un monto de {clonada.Monto} ,Cuenta original tiene un monto de  {cuentaUno.Monto}");

            Console.ReadKey();
        }
    }
}
