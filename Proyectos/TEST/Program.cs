using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.IO.Compr‌​‌​‌​ession;

using System.Diagnostics;

using System.Xml;

namespace TEST {
  class Program {

    static void ZipFolder(string _sourceDirectory, string _zipFileName) {
      try {

        // Obtener el nombre de la carpeta fuente
        string folderName = new DirectoryInfo(_sourceDirectory).Name;

        // creamos la ruta del archivo .zip
        string zipFilePath = _sourceDirectory.Replace(folderName, _zipFileName);

        // Si el archivo ZIP ya existe, eliminarlo para evitar conflictos
        if (File.Exists(zipFilePath)) {
          File.Delete(zipFilePath);
        }

        // Comprimir la carpeta en un archivo ZIP
        ZipFile.CreateFromDirectory(_sourceDirectory, zipFilePath);

        Console.WriteLine("Carpeta comprimida correctamente en el archivo ZIP: " + zipFilePath);
      } catch (Exception ex) {
        Console.WriteLine("Error al comprimir la carpeta: " + ex.Message);
      }
    }

    static void ExtractZipFile(string _zipFilePath) {

      string _extractPath = Path.ChangeExtension(_zipFilePath, null);

      try {
        // Si la carpeta de extracción no existe, crearla
        if (!Directory.Exists(_extractPath)) {
          Directory.CreateDirectory(_extractPath);
        }

        // Descomprimir el archivo ZIP en la carpeta de extracción
        ZipFile.ExtractToDirectory(_zipFilePath, _extractPath);

        Console.WriteLine("Archivo ZIP descomprimido correctamente en la carpeta: " + _extractPath);

        

        // Eliminamos el archivo .zip despues de comprimirlo.
        try {
          // Verificar si el archivo ZIP existe
          if (File.Exists(_zipFilePath)) {
            // Eliminar el archivo ZIP
            File.Delete(_zipFilePath);

            Console.WriteLine("Archivo ZIP eliminado correctamente: " + _zipFilePath);
          } else {
            Console.WriteLine("El archivo ZIP no existe: " + _zipFilePath);
          }
        } catch (Exception ex) {
          Console.WriteLine("Error al eliminar el archivo ZIP: " + ex.Message);
        }


      } catch (Exception ex) {
        Console.WriteLine("Error al descomprimir el archivo ZIP: " + ex.Message);
      }
    }

    static void copyInstallation(string _pathMAF, string _installationName, string _copyInstallationName) {
      
      // Definimos los path de la instalacion. Del actual y de la copia.
      string pathInstallation = _pathMAF + _installationName;
      string pathinstallationCopy = _pathMAF + _copyInstallationName;

      // Comprobamos que existe la carpeta de la instalacion.
      //if (Directory.Exists(pathInstallation)) {
      //  // Comprobamos que no existe la carpeta donde se va a realizar la copia de la instalacion.
      //  if (!Directory.Exists(pathinstallationCopy)) {

      //  } else {
      //    Console.WriteLine("La carpeta donde se va a copiar la instalación ya existe.");
      //  }
      //} else {
      //  Console.WriteLine("La carpeta de la instalación no existe.");
      //}
      
      // Copiamos la carpeta de la instalacion por línea de comandos en el cmd.
      string cmdCommandType = "xcopy";
      string cmdAtributes = "/h /i /c /k /e /r /y";
      string[] cmdCommandParts = { cmdCommandType, pathInstallation, pathinstallationCopy, cmdAtributes };
      string cmdCommand = string.Join(" ", cmdCommandParts);

      try {

        Console.WriteLine("Se ha iniciado la copia de la instalacion...");
        
        Process cmd = new Process();
        cmd.StartInfo.FileName = "cmd.exe";
        cmd.StartInfo.RedirectStandardInput = true;
        cmd.StartInfo.RedirectStandardOutput = true;
        cmd.StartInfo.CreateNoWindow = true;
        cmd.StartInfo.UseShellExecute = false;
        cmd.Start();

        cmd.StandardInput.WriteLine(cmdCommand);
        cmd.StandardInput.Flush();
        cmd.StandardInput.Close();
        Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        cmd.Close();

        Console.WriteLine("Ha finalizado la copia de la instalacion correctamente.");

      } catch (Exception ex) {
        
        Console.WriteLine("Error al realizar la copia de la carpeta de la instalacion\n\tExcepcion = " + ex.Message);

      } finally {
        
        // Modificamos el parametro GS_Path del CM_Settings.xml
        try {

          // Path archivo .xml
          string xmlFilePath = pathinstallationCopy + @"\Program-ClusterManagement\CM_Settings.xml";

          Console.WriteLine("Modificando parametro 'GS_Path' del fihcero {0}", xmlFilePath);

          // Cargar el archivo .xml
          XmlDocument xmlDoc = new XmlDocument();
          xmlDoc.Load(xmlFilePath);

          // Obtener el nodo del parámetro a modificar
          XmlNode parametroNode = xmlDoc.SelectSingleNode($"/configuration/userSettings/ClusterManagementUserControl.Properties.Settings/setting[@name='GS_Path']");

          if (parametroNode != null) {
            // Modificar el valor del parámetro
            parametroNode.InnerText = pathinstallationCopy;

            // Guardar los cambios en el archivo .xml
            xmlDoc.Save(xmlFilePath);

            Console.WriteLine($"Parámetro 'GS_Path' modificado correctamente en el archivo: {xmlFilePath}");
          } else {
            Console.WriteLine($"No se encontró el parámetro 'GS_Path' en el archivo: {xmlFilePath}");
          }
        } catch (Exception ex) {
          Console.WriteLine("Error al modificar el parámetro en el archivo XML: " + ex.Message);
        }

      }

      Console.WriteLine("FIIN");
      Console.ReadKey();
    }

    static void Main(string[] args) {

      string pathMAF = @"C:\MAF\";
      string installationName = "G7_Kaki_Principal";
      string copyInstallationName = "G7_Kaki_Secundaria";

      copyInstallation(pathMAF, installationName, copyInstallationName);

    }
  }
}
