using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diccionario {
  class Program {

    // Merge master con Test.

    static void Main(string[] args) {
      Dictionary<string, long> agenda = new Dictionary<string, long>();

      int menu;
      string nombre;
      long numero;

      do {
        Console.Write("\nAgenda telefonica.\n\nSelecciona una opcion:\n\t1. Agregar Contacto.\n\t2. Eliminar Contacto.\n\t3. Mostrar Contactos.\n\t4. Salir.\n\nSeleecion:");
        menu = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (menu) {
          case 1:
            Console.Write("\nAgregar Contacto.\n\tNombre: ");
            nombre = Console.ReadLine();
            Console.Write("\tTelefono: ");
            numero = Convert.ToInt64(Console.ReadLine());
            agenda[nombre] = numero;
            break;

          case 2:
            Console.Write("\nEliminar Contacto.\n\tNombre: ");
            nombre = Console.ReadLine();
            if (agenda.Remove(nombre)) {
              Console.WriteLine("Contacto eliminado.");
            } else {
              Console.WriteLine("Contacto no encontrado.");
            }
            Console.ReadKey();
            break;

          case 3:
            Console.Write("\nMostrar Contactos.\n");
            foreach (KeyValuePair<string, long> elemento in agenda) {
              Console.WriteLine("\t{0} {1}.", elemento.Key, elemento.Value);
            }
            Console.ReadKey();
            break;
        }

        Console.Clear();

      }
      while (menu >= 1 && menu <= 3);
    }
  }
}
