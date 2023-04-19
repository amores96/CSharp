using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados {
  class DelegadoEnLinea {


    public delegate string ObtenerDelegadoTexto(string nombre);




    public static void EjecutarMetodoAnonimo() {

      // Declaramos un delegado miDelegado que no apunta a ninguna funcion, se declara en dinamico su funcion propia.
      ObtenerDelegadoTexto miDelegado = delegate (string nombre) {
        return ($"Hola, {nombre}");
      };

      string retorno = miDelegado("Adrian");
      Console.WriteLine(retorno);

      miDelegado = delegate (string nombre) {
        return ($"Adios, {nombre}");
      };

      retorno = miDelegado("Jose");
      Console.WriteLine(retorno);

      // Pasar metodo anonimo como argumento a un metodo.
      DecirAdios(miDelegado);

      // Pasar metodo anonimo como argumento a un metodo y lo modificamos dentro del metodo.
      CambiarMetodoAnonimo(miDelegado);


      // <<<<<<<<<<<<<<<<<<<<  METODO ANONIMO CON LISTAS  >>>>>>>>>>>>>>>>>>>>
      // Declaramos la lista de numeros.
      List<int> sucesionNumeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      // Filtramos de la lista de numeros los numeros pares con un metodo anonimo.
      // Pasamos un filtro con la funcion .FindAll() a la clase List. Esta funcion hace loop por todos los elementos y solo recolecta los que cumplen la condicion.
      // El delegado devuelve un bool, cuando es true se añade a la nueva lista (numerosPares) el valor de la lista sobre la que filtramos (sucesionNumeros).
      List<int> numerosPares = sucesionNumeros.FindAll(delegate (int i) {
        return (i % 2 == 0);
      });

      // Imprimimos la lista de enteros pares.
      foreach (int num in numerosPares) Console.WriteLine($"Numero par = {num}");


    }



    // Metodo al que le pasamos un metodo anonimo como argumento.
    private static void DecirAdios(ObtenerDelegadoTexto _miDelegado) {
      string retorno = _miDelegado("Maria");
      Console.WriteLine(retorno);
    }

    // Metodo al que le pasamos un metodo anonimo como argumento y modificamos el metodo anonimo dentro.
    private static void CambiarMetodoAnonimo(ObtenerDelegadoTexto _miDelegado) {
      _miDelegado = delegate (string nombre) {
        return ($"Hola compañer@ {nombre}, le mando un saludo.");
      };

      string retorno = _miDelegado("Ana");
      Console.WriteLine(retorno);

    }





  }
}
