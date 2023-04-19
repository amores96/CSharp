using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados {
  class DelegadoMultidifusion {

    // Los delegados multidifusion nos permiten asignar varios metodos a un mismo delegado.

    public delegate double HacerCalculo(double x, double y); 


    public static void EjecutarDelegadoMultidifusion() {

      double resultadoDelegado = 0.0;

      HacerCalculo calculoSuma = Metodos.Suma;
      HacerCalculo calculoResta = Metodos.Resta;
      HacerCalculo calculos = calculoSuma + calculoResta;

      calculos += Metodos.Multiplicacion;
      calculos += Metodos.Division;

      resultadoDelegado = calculos(2, 3);
      Console.WriteLine($"Retorno delegado 1 = {resultadoDelegado}\n\n");

      calculos -= calculoSuma;
      calculos -= Metodos.Resta;

      resultadoDelegado = calculos.Invoke(2, 3);
      Console.WriteLine($"Retorno delegado 2 = {resultadoDelegado}");
    }



    public class Metodos {

      public static double Suma(double a, double b) {
        Console.WriteLine($"a+b = {(a + b)}");
        return (a + b);
      }

      public static double Resta(double a, double b) {
        Console.WriteLine($"a-b = {(a - b)}");
        return (a - b);
      }

      public static double Multiplicacion(double a, double b) {
        Console.WriteLine($"a*b = {(a * b)}");
        return (a * b);
      }

      public static double Division(double a, double b) {
        Console.WriteLine($"a/b = {(a / b)}");
        return (a / b);
      }

    }


  }
}
