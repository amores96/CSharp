using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estructuras {
  class Program {
    static void Main(string[] args) {
      Agenda amigo = new Agenda("Adrian", "607493549", 26);

      Console.WriteLine(amigo.ToString());

      Console.ReadKey();

    }


    public struct Agenda {

      public string Nombre, Telefono;
      public int Edad;

      public Agenda(string Nombre, string Telefono, int Edad) {
        this.Nombre = Nombre;
        this.Telefono = Telefono;
        this.Edad = Edad;
      }

      public override string ToString() {

        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("Nombre = {0}, Telefono = {1}, Edad = {2}.", Nombre, Telefono, Edad);

        return (sb.ToString());
      }

    }
  }
}

