﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados {
  class Program {


    static void Main(string[] args) {

      // First commit branch.

      // Commit 2 sin insertar.

      // Commit 3 sin insertar.

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

      // Cambios master....
    }


  }
}
