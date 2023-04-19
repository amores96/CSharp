using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Delegados {
  class Delegados {     // Clase para poner en practica los delegados.

    // Declaramos el objeto para el tipo de delegado. Debe tener la misma estructura que el metodo al que apunta.
    private delegate string tipoDelegado(string _mensaje);

    public static void EjecutarDelegado() {

      string tipoMensaje;

      // Creamos una instancia (objeto) del delegado tipoDelegado.
      tipoDelegado objetoDelegado;

      // Cambiamos el metodo al que apunta el objeto objetoDelegado a SaludoBienvenida.
      objetoDelegado = new tipoDelegado(MensajeBienvenida.SaludoBienvenida);
      // Llamada del objeto objetoDelegado para llamar al metodo SaludoBienvenida.
      // objetoDelegado es un delegado de tipo tipoDelegado que llama al metodo SaludoBienvenida. A continuacion llamamos al delegado y le pasamos el argumento del metodo al que apunta, en este caso SaludoBienvenida.
      // Basicamente le hemos asignado un metodo a la variable objetoDelegado.
      tipoMensaje = objetoDelegado("Hola, bienvenido.");
      Console.WriteLine(tipoMensaje);

      // Cambiamos el metodo al que apunta el objeto objetoDelegado a SaludoDespedida.
      objetoDelegado = MensajeDespedida.SaludoDespedida;
      // Llamada del objeto objetoDelegado para llamar al metodo SaludoDespedida.
      tipoMensaje = objetoDelegado.Invoke("Adios, hasta pronto.");
      Console.WriteLine(tipoMensaje);

    }

  }

  class MensajeBienvenida {
    public static string SaludoBienvenida(string _mensajeBienvenida) {
      Console.WriteLine(_mensajeBienvenida);
      return "Mensaje de bienvenida.";
    }
  }

  class MensajeDespedida {
    public static string SaludoDespedida(string _mensajeDespedida) {
      Console.WriteLine(_mensajeDespedida);
      return "Mensaje de despedida.";
    }
  }


}
