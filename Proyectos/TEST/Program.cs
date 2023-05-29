using System;
using System.IO;
using System.Linq;

namespace TEST {
  class Program {

    static void bufferCircular(string _path, int _filesNumberMax) {

      // Obtener la lista de archivos en el directorio
      string[] files = Directory.GetFiles(_path);

      // Verificar si hay más archivos que el máximo permitido
      if (files.Length > _filesNumberMax) {
        // Ordenar los archivos por fecha de creación (de más antiguo a más reciente)
        var sortedFiles = files.Select(a => new FileInfo(a)).OrderBy(a => a.CreationTime).ToList();

        // Calcular la cantidad de archivos que se deben eliminar
        int fileNumberToRemove = sortedFiles.Count - _filesNumberMax;

        // Eliminar los archivos más antiguos
        for (int i = 0; i < fileNumberToRemove; i++) {
          FileInfo fileToRemove = sortedFiles[i];
          fileToRemove.Delete();
          Console.WriteLine("Se ha eliminado el archivo: " + fileToRemove.Name);
        }
      }

      // Mostrar la lista de archivos restante
      Console.WriteLine("Archivos en el directorio:");
      foreach (string archivo in Directory.GetFiles(_path)) {
        Console.WriteLine(archivo);
      }


    }

    static void Main(string[] args) {

      string path = @"C:\Users\aamores\Desktop\Archivos";
      int filesMax = 10;
      bufferCircular(path, filesMax);

      Console.ReadKey();

    }
  }
}
