using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO {
  class Empleado {

    //CAMPOS
    static int id = 0;

    int idObjeto = 0;
    string nombre, apellido, locker, banco, dni;
    

    //PROPIEDADES
    public int IdObjeto {
      get { return idObjeto; }
    }
    
    public string Nombre {
      get => nombre;

    }

    public string Apellido {
      get => apellido;
    }

    public string Locker {
      get => locker;
    }

    public string Banco {
      get => banco;
    }

    public string Dni {
      get => dni;
      set => dni = value;
    }


    //CONSTRUCTOR STATIC
    static Empleado() {
      Console.WriteLine("\nSe ha creado la clase Empleado.");
    }


    //CONSTRUCTORES
    public Empleado() {
      
      this.nombre = "";
      this.apellido = "";
      this.dni = "";

      this.locker = "";
      this.banco = "";

      this.idObjeto = GenerarId();
    }
    public Empleado(string nombre, string apellido) {

      this.nombre = nombre;
      this.apellido = apellido;
      this.dni = "";

      this.locker = GenerarLocker();
      this.banco = AsignarBanco();

      this.idObjeto = GenerarId();
    }

    public Empleado(string nombre, string apellido, string dni) {

      this.nombre = nombre;
      this.apellido = apellido;
      this.dni = dni;

      this.locker = GenerarLocker();
      this.banco = AsignarBanco();

      this.idObjeto = GenerarId();
    }


    //DESTRUCTOR
    ~Empleado() {
      this.nombre = "";
      this.apellido = "";
      this.dni = "";

      this.locker = "";
      this.banco = "";

      EliminarId();
    }


    //METODOS STATICS
    static int GenerarId() {
      ++id;
      Console.WriteLine("Se ha generado el objeto {0} de la clase Empleado.\n", id);

      return id;
    }

    static void EliminarId() {
      --id;
      Console.WriteLine("Se ha eliminado el objeto {0} de la clase Empleado.\n", id);
    }

    //METODOS
    public string GenerarLocker() {

      //Generar numero aleatorio para el numero de Locker.
      Random numRandom = new Random();

      return numRandom.Next(100).ToString();
    }

    public string AsignarBanco() {

      //Asignar un banco aleatorio.
      Random numRandom = new Random();
      string banco = "";
      
      switch (numRandom.Next(5)) {
        case 0:
          banco = "BBVA";
          break;
        case 1:
          banco = "Santander";
          break;
        case 2:
          banco = "Caixa popular";
          break;
        case 3:
          banco = "ING";
          break;
        case 4:
          banco = "Bancaja";
          break;
      }

      return banco;
    }

    //METODO OVERRIDE
    public override string ToString() {

      string mensaje = ("\nEmpleado ID: " + idObjeto + "\n\tNombre: " + nombre + "\n\tApellido: " + apellido + "\n\tNIP: " + dni + "\n\tLocker: " + locker + "\n\tBanco: " + banco) ;
      Console.WriteLine(mensaje);

      return mensaje;
    }



  }
}
