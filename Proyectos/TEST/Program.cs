using System;
using System.Diagnostics;

namespace TEST {
  class Program {

    static void Main(string[] args) {

      // El comando de PowerShell que quieres ejecutar
      string command = "Get-Process";

      // Crea una nueva instancia de la clase Process
      Process proc = new Process();
      proc.StartInfo.FileName = "powershell.exe";
      proc.StartInfo.Arguments = command;
      proc.StartInfo.RedirectStandardOutput = true;
      proc.StartInfo.UseShellExecute = false;
      proc.StartInfo.CreateNoWindow = true;

      // Inicia el proceso
      proc.Start();

      // Lee la salida del comando
      while (!proc.StandardOutput.EndOfStream) {
        string line = proc.StandardOutput.ReadLine();
        Console.WriteLine(line);
      }

      Console.ReadKey();

    }
  }
}
