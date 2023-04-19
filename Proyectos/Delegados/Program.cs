using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados {
  class Program {


    static void Main(string[] args) {

      // DELEGADO.
      //Delegados.EjecutarDelegado();

      // DELEGADO MULTIDIFUSION.
      //DelegadoMultidifusion.EjecutarDelegadoMultidifusion();

      // DELEGADO EN LINEA o METODO ANONIMO.   
      //DelegadoEnLinea.EjecutarMetodoAnonimo();

      // DELEGADO PREDICADO LISTA.
      //DelegadoPredicado.EjecutarDelegadoPredicadoLista();

      // DELEGADO PREDICADO CLASE.
      //DelegadoPredicado.EjecutarDelegadoPredicadoClass();

      // EXPRESION LAMBDA.
      ExpresionLambda.EjecutarExpresionLambda();
      ExpresionLambda_2.EjecutarExpresionesLambda_2();


      Console.ReadKey();


    }


  }
}
