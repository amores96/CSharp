using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadenas {
  class Program {
    static void Main(string[] args) {
      // INICIALIZACION y DECLARACION
      // Inicializacion con el alias "string".
      string cadena1 = "";

      // Instanciando con el constructor de String.
      char[] caracteres = { 'H', 'o', 'l', 'a', ' ', 'M', 'u', 'n', 'd', 'o' };
      String cadena2 = new string(caracteres);

      //METODOS de STRING
      // CONCATENAR
      // .Concat()
      string cadena3 = "Hola";
      string cadena4 = "Mundo";
      string cadena5 = string.Concat(cadena3, cadena4);
      Console.WriteLine(cadena5);

      // .Join()
      string cadena6 = "Hola";
      string cadena7 = "Mundo";
      string cadena8 = string.Join(" ", cadena6, cadena7);
      Console.WriteLine(cadena8);

      // SEPARAR
      // .Split()
      string[] cadena9 = cadena8.Split(' ');
      foreach (string elemento in cadena9) {
        Console.WriteLine(elemento);
      }

      // BUSCAR
      string cadena10 = "Hola Mundo";

      // .Contains()
      bool estadoBusqueda = cadena10.Contains("Mundo");
      if (estadoBusqueda) Console.WriteLine("Si que lo contiene.");

      // .IndexOf()
      string cadena12 = "Adrian Amores Albelda";
      int indice1 = cadena12.IndexOf('d');
      Console.WriteLine("El indice de la primera d es = {0}", indice1);

      // .LastIndexOf()
      int indice2 = cadena12.LastIndexOf('d');
      Console.WriteLine("El indice de la ultima d es = {0}", indice2);

      // MODIFICAR
      // .Replace()
      string cadena13 = "Texto de prueba para comprobar como podemos reemplazar o modificar texto de un string sin crear un nuevo objeto debido a la inmutabilidad de los strings.";
      string cadena14 = cadena13.Replace("a", "@");
      Console.WriteLine(cadena14);

      // Test.

      Console.ReadKey();
    }
  }
}
