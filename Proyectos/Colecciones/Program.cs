using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colecciones {
  class Program {
    static void Main(string[] args) {
      //Guardamos elementos de tipo string.
      GuardaObjetos<string> objeto1 = new GuardaObjetos<string>(3);

      objeto1.AgregarElemento("Texto 1.");
      objeto1.AgregarElemento("Texto 2.");
      objeto1.AgregarElemento("Texto 3.");

      string lectura;
      lectura = objeto1.ObtenerElemento(0);
      Console.WriteLine("Texto string 1: {0}", lectura);
      lectura = objeto1.ObtenerElemento(1);
      Console.WriteLine("Texto string 2: {0}", lectura);
      lectura = objeto1.ObtenerElemento(2);
      Console.WriteLine("Texto string 3: {0}", lectura);


      //Guardamos elementos de tipo de la clase ClasePrueba.
      ClasePrueba clasePrueba1 = new ClasePrueba(10);
      ClasePrueba clasePrueba2 = new ClasePrueba(20);
      ClasePrueba clasePrueba3 = new ClasePrueba(30);

      GuardaObjetos<ClasePrueba> objeto2 = new GuardaObjetos<ClasePrueba>(3);    //Esta instancia de la clase GuardarObjetos (objetos1) trabajará con el tipo de la clase ClasePrueba. 

      objeto2.AgregarElemento(clasePrueba1);
      objeto2.AgregarElemento(clasePrueba2);
      objeto2.AgregarElemento(clasePrueba3);

      ClasePrueba clasePruebaLectura;
      clasePruebaLectura = objeto2.ObtenerElemento(0);
      Console.WriteLine("Valor objeto 1: {0}", clasePruebaLectura.Valor);
      clasePruebaLectura = objeto2.ObtenerElemento(1);
      Console.WriteLine("Valor objeto 2: {0}", clasePruebaLectura.Valor);
      clasePruebaLectura = objeto2.ObtenerElemento(2);
      Console.WriteLine("Valor objeto 3: {0}", clasePruebaLectura.Valor);



      Console.ReadKey();
    }
  }
}
