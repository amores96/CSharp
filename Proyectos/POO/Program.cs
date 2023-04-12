using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Creación empleado bancario.\n\nIntroduce los siguientes datos:");

      Console.Write("\tNombre: ");
      string nombre = Console.ReadLine();

      Console.Write("\tApellido: ");
      string apellido = Console.ReadLine();

      Console.Write("\tDNI: ");
      string dni = Console.ReadLine();

      CuentaBancaria cuentaEmpleado1 = new CuentaBancaria(nombre, apellido, dni, 13450.68);
      cuentaEmpleado1.ToString();

      cuentaEmpleado1.Deposito(25000);
      cuentaEmpleado1.ToString();

      cuentaEmpleado1.Retiro(7777);
      cuentaEmpleado1.ToString();

      cuentaEmpleado1.ConsultarSaldo();

      Console.ReadKey();
    }
  }
}
