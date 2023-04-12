using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld {
  class Program {
    static void Main(string[] args) {
      int numSalones;
      Console.Write("Ingrese el numero de clases: ");
      numSalones = Convert.ToInt32(Console.ReadLine());

      int[][] calificaciones = new int[numSalones][];

      for (int i = 0; i < numSalones; ++i) {
        int numAlumnos;
        Console.Write("Numero alumnos para la clase {0}: ", (i + 1));
        numAlumnos = Convert.ToInt32(Console.ReadLine());

        calificaciones[i] = new int[numAlumnos];
      }

      for (int i = 0; i < calificaciones.GetLength(0); ++i) {

        int media = 0, acumulado = 0, max = 0, min = 0;

        Console.WriteLine("\n\nClase {0}", (i + 1));

        for (int j = 0; j < calificaciones[i].Length; ++j) {
          int calificacion;
          Console.Write("Calificacion alumno {0} = ", (j + 1));
          calificacion = Convert.ToInt32(Console.ReadLine());
          calificaciones[i][j] = calificacion;

          acumulado += calificaciones[i][j];
          max = (max < calificaciones[i][j]) ? calificaciones[i][j] : max;
          min = ((min > calificaciones[i][j]) || (min == 0)) ? calificaciones[i][j] : min;
        }

        media = acumulado / calificaciones[i].Length;
        Console.WriteLine("\n\tMedia = {0}.\n\tMaximo = {1}.\n\tMinimo = {2}.", media, max, min);

      }
    }
  }
}
