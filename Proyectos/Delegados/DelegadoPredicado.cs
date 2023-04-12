using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados {
  class DelegadoPredicado {   // Clase para poner en practica los delegados predicados.

    class Funciones {
      public static bool devolverPares(int _num) {
        if (_num % 2 == 0) return true;
        else return false;
      }
      public static bool EdadMayor(Persona _persona) {
        if (_persona.Edad > 25) return true;
        else return false;
      }
    }

    public static void EjecutarDelegadoPredicadoLista() {

      // Lista con sucesion de numeros.
      List<int> sucesionNumeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      // Declaramos el objeto delegado predicado objetoDelegadoPredicado.
      Predicate<int> objetoDelegadoPredicado;

      // Inicializamos el objeto objetoDelegadoPredicado y hacemos que apunte al metodo devolverPares.
      objetoDelegadoPredicado = new Predicate<int>(Funciones.devolverPares);

      // Pasamos el delegado predicado como argumento al metodo de lista .FindAll para que devuelva solo los numeros pares y los guarde en la lista retornoNumerosPares.
      List<int> retornoNumerosPares = sucesionNumeros.FindAll(objetoDelegadoPredicado);

      foreach (int _num in retornoNumerosPares) {
        Console.WriteLine(_num);
      }

    }

    class Persona {
      private string nombre;
      private int edad;

      public string Nombre { get => nombre; set => nombre = value; }
      public int Edad { get => edad; set => edad = value; }

      public Persona(string _nombre, int _edad) {
        this.nombre = _nombre;
        this.edad = _edad;
      }
    }

    public static void EjecutarDelegadoPredicadoClass() {
      Persona P1 = new Persona("Adrian", 26);
      Persona P2 = new Persona("Juan", 30);
      Persona P3 = new Persona("Jose", 17);
      Persona P4 = new Persona("Maria", 33);

      List<Persona> gente = new List<Persona>() { P1, P2, P3, P4 };

      Predicate<Persona> delegadoPredicadoPersona;
      delegadoPredicadoPersona = new Predicate<Persona>(Funciones.EdadMayor);

      // Comprobamos si hay personas que cumplen la condicion.
      bool hayMayores = gente.Exists(Funciones.EdadMayor);
      // Si las hay las guardamos en una lista y las imprimimos por pantalla.
      if (hayMayores) {
        List<Persona> retornoPersonasMayores = gente.FindAll(Funciones.EdadMayor);

        foreach (Persona _persona in retornoPersonasMayores) {
          Console.WriteLine(_persona.Nombre + ", " + _persona.Edad);
        }
      }

    }


  }
}
