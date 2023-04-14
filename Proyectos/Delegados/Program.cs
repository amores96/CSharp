using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados {
  class Program {


    static void Main(string[] args) {

      // Comentario 1.

      // Comentario 2.

      // Comentario 3.

      // DELEGADO.  Ejecutamos el metodo ejecutarDelegado donde se aplica un ejemplo de delegado.
      Delegados.EjecutarDelegado();

      // DELEGADO PREDICADO LISTA.  Ejecutamos el metodo EjecutarDelegadoPredicadoLista donde se aplica un ejemplo de delegado predicado con una lista.
      DelegadoPredicado.EjecutarDelegadoPredicadoLista();

      // DELEGADO PREDICADO CLASE.  Ejecutamos el metodo EjecutarDelegadoPredicadoClass donde se aplica un ejemplo de delegado predicado con una clase.
      DelegadoPredicado.EjecutarDelegadoPredicadoClass();

      // EXPRESION LAMBDA.
      ExpresionLambda.EjecutarExpresionLambda();

      Console.ReadKey();

      // Commit main.

      // Cambios main.
    }


  }
}
