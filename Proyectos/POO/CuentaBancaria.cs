using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO {
  class CuentaBancaria : Empleado     //Clase derivada de la clase base Empleado.
  {
    //CAMPOS
    int idObjeto;
    double saldo;

    //PROPIEDADES
    public double Saldo {
      get => saldo;
    }


    //CONSTRUCTOR STATIC
    static CuentaBancaria() {
      Console.WriteLine("\nSe ha creado la clase CuentaBancaria.");
    }

    //CONSTRUCTOR
    public CuentaBancaria() : base() {
      this.idObjeto = IdObjeto;

      this.saldo = 0.0;
    }

    public CuentaBancaria(string nombre, string apellido): base(nombre, apellido) {
      this.idObjeto = IdObjeto;

      this.saldo = 0.0;
    }

    public CuentaBancaria(string nombre, string apellido, string dni) : base(nombre, apellido, dni) {
      this.idObjeto = IdObjeto;

      this.saldo = 0.0;
    }

    public CuentaBancaria(string nombre, string apellido, string dni, double saldo) : base(nombre, apellido, dni) {
      this.idObjeto = IdObjeto;

      this.saldo = saldo;
    }


    //DESTRUCTOR
    ~CuentaBancaria() {

      this.saldo = 0.0;
    }


    //METODOS
    public double Deposito(double cantidad) {

      this.saldo += cantidad;

      return this.saldo;
    }

    public double Retiro(double cantidad) {
      
      this.saldo -= cantidad;

      return this.saldo;
    }

    public void ConsultarSaldo() {
      Console.WriteLine("\nSu saldo actual es de {0} $.\n", this.saldo);
    }

    //METODO OVERRIDE
    public override string ToString() {

      string mensaje = ("\nEmpleado y Cuenta ID: " + idObjeto + "\n\tNombre: " + Nombre + "\n\tApellido: " + Apellido + "\n\tDNI: " + Dni + "\n\tLocker: " + Locker + "\n\tBanco: " + Banco + "\n\tSaldo: " + saldo);     //Debemos acceder por propiedades a los campos de la clase base Empleado ya que los campos son privados.
      Console.WriteLine(mensaje);

      return mensaje;
    }
  }
}
