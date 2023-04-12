using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;         // Thread
using System.Threading.Tasks;   // TaskCompletionSource<generico>;

namespace ThreadsTasks {
  class ThreadTest {

    #region THREAD SIMPLE
    public static void EjecucionParalelaThreads() {

      // Creacion del hilo 1:
      System.Threading.Thread t1 = new System.Threading.Thread(
        () => {
          for (int i = 0; i < 10; ++i) {
            Console.WriteLine("Mensaje {0} del hilo 1.", i);
            System.Threading.Thread.Sleep(500);
          }
        });

      t1.Start();

      // Creacion del hilo 2:
      System.Threading.Thread t2 = new System.Threading.Thread(MostrarMensaje);
      t2.Start();


      // Ejecucion del programa principal.
      for (int i = 0; i < 10; ++i) {
        Console.WriteLine("Mensaje {0} del hilo principal.", i);
        System.Threading.Thread.Sleep(500);
      }

    }

    private static void MostrarMensaje() {
      for (int i = 0; i < 10; ++i) {
        Console.WriteLine("Mensaje {0} del hilo 2.", i);
        System.Threading.Thread.Sleep(500);
      }
    }

    public static void EjecucionParalelaThreadsCuenta() {
      
      CuentaBancaria cuenta1 = new CuentaBancaria(2000);

      // Creamos un array de threads para que cada uno ejecute el metodo RetirarEfectivo().
      System.Threading.Thread[] threadsPersonas = new System.Threading.Thread[15];

      for (int i = 0; i < threadsPersonas.Count(); ++i) {
        // Creamos un Thread.
        System.Threading.Thread t = new System.Threading.Thread(cuenta1.RetirarEfectivoNormal);
        // Le damos nombre al Thread.
        t.Name = "Hilo " + i.ToString();
        // Almacenamos el Thread en el array de threads.
        threadsPersonas[i] = t;
      }
      for (int i = 0; i < threadsPersonas.Count(); ++i) {
        // Ejecutamos cada Thread del array.
        threadsPersonas[i].Start();
      }
    }
    #endregion

    #region SINCRONIZACION
    // En este ejemplo vamos a trabajar con la clase Cuentabancaria en la que tendremos un saldo y vamos a retirar efectivo.
    // La tarea de retirar efectivo se va a realizar en paralelo con hilos.
    // Vamos a sincronizar con .Join() la ejecucion de cada hilo para que lo haga de forma secuencial, es decir, se ejecuten los hilos con un orden.
    public static void EjecucionParalelaThreadsSincronizada() {

      CuentaBancaria cuenta1 = new CuentaBancaria(2000);

      // Creamos un array de threads para que cada uno ejecute el metodo RetirarEfectivo().
      System.Threading.Thread[] threadsPersonas = new System.Threading.Thread[15];

      for (int i = 0; i < threadsPersonas.Count(); ++i) {
        // Creamos un Thread.
        System.Threading.Thread t = new System.Threading.Thread(cuenta1.RetirarEfectivoNormal);
        // Le damos nombre al Thread.
        t.Name = "Hilo " + i.ToString();
        // Almacenamos el Thread en el array de threads.
        threadsPersonas[i] = t;
      }
      for (int i = 0; i < threadsPersonas.Count(); ++i) {
        // Ejecutamos cada Thread del array.
        threadsPersonas[i].Start();
        // Sincronizamos la ejecucion de los hilos para que lo hagan en orden. Hasta que no se ejecute por completo un hilo no se ejecuta el siguiente, lo hace de forma secuencial.
        threadsPersonas[i].Join();
      }

    }

    #endregion

    #region BLOQUEO
    // En este ejemplo vamos a trabajar con la clase Cuentabancaria en la que tendremos un saldo y vamos a retirar efectivo.
    // La tarea de retirar efectivo se va a realizar en paralelo con hilos.
    // Si no bloqueamos la ejecucion de la tarea de retirar efectivo, los hilos lo harán a la vez y no se tendra un saldo real, ya que al sacar dinero a la vez en cada hilo el campo Saldo de la clase no tendrá un valor real.
    // Para corregir esto, vamos a bloquear el metodo RetirarEfectivo para que no se pueda ejecutar a la vez en paralelo. No se podrá ejecutar en paralelo.
    public static void EjecucionParalelaThreadsBloqueada() {

      CuentaBancaria cuenta1 = new CuentaBancaria(2000);

      // Creamos un array de threads para que cada uno ejecute el metodo RetirarEfectivo().
      System.Threading.Thread[] threadsPersonas = new System.Threading.Thread[15];

      for (int i = 0; i < threadsPersonas.Count(); ++i) {
        // Creamos un Thread.
        System.Threading.Thread t = new System.Threading.Thread(cuenta1.RetirarEfectivoBloqueado);
        // Le damos nombre al Thread.
        t.Name = "Hilo " + i.ToString();
        // Almacenamos el Thread en el array de threads.
        threadsPersonas[i] = t;
      }
      for (int i = 0; i < threadsPersonas.Count(); ++i) {
        // Ejecutamos cada Thread del array.
        threadsPersonas[i].Start();
      }

    }
    #endregion

    #region TaskCompletionSource
    // Se realiza con la clase TaskCompletionSource<generico>.
    // Vamos a tener la condicion de que una tarea termine su ejecución para ajecutar otra tarea en un hilo.


    // Variable de tipo TaskCompletionSource para establecer el resultado de la tarea.
    private static TaskCompletionSource<bool> tarea_1_Terminada = new TaskCompletionSource<bool>();
    private static TaskCompletionSource<bool> tarea_2_Terminada = new TaskCompletionSource<bool>();


    public static void EjecucionTaskCompletionSource() {

      // Declaramos e inicializamos el hilo t1.
      System.Threading.Thread t1 = new System.Threading.Thread(
        () => {
          for (int i = 0; i < 5; i++) {
            Console.WriteLine("Hilo 1");
            System.Threading.Thread.Sleep(500);
          }
          // Declaramos cuando la tarea ha terminado. Se actualiza la variable tareaTerminada de tipo TaskCompletionSource.
          tarea_1_Terminada.TrySetResult(true);
        } );

      // Declaramos e inicializamos el hilo t2.
      System.Threading.Thread t2 = new System.Threading.Thread(
        () => {
          for (int i = 0; i < 5; i++) {
            Console.WriteLine("Hilo 2");
            System.Threading.Thread.Sleep(500);
          }
          // Declaramos cuando la tarea ha terminado. Se actualiza la variable tareaTerminada de tipo TaskCompletionSource.
          tarea_2_Terminada.TrySetResult(true);
        } );

      // Declaramos e inicializamos el hilo t3.
      System.Threading.Thread t3 = new System.Threading.Thread(
        () => {
          for (int i = 0; i < 5; i++) {
            Console.WriteLine("Hilo 3");
            System.Threading.Thread.Sleep(500);
          }
        });

      // Declaramos e inicializamos el hilo t3.
      System.Threading.Thread t4 = new System.Threading.Thread(
        () => {
          for (int i = 0; i < 5; i++) {
            Console.WriteLine("Hilo 4");
            System.Threading.Thread.Sleep(500);
          }
        });

      // Ejecutamos el hilo 1.
      t1.Start();

      // Esperar a que finalice la tarea del hilo 1 (t1), para ejecutar el hilo 2 (t2) una vez finalizado el 1.
      var tarea_1_resultado = tarea_1_Terminada.Task.Result;

      // Ejecutamos el hilo 2 una vez haya finalizado la ejecucion del hilo 1.
      t2.Start();

      // Esperar a que finalice la tarea del hilo 2 (t2), para ejecutar el hilo 3 (t3) una vez finalizado el 2.
      var tarea_2_resultado = tarea_2_Terminada.Task.Result;

      // Ejecutamos el hilo 3 y 4 en paralelo una vez haya finalizado la ejecucion del hilo 2.
      t3.Start();
      t4.Start();

    }

    #endregion

    #region POOL de THREADS
    // Se utiliza cuando necesitemos crear muchos hilos a ejecutar de manera concurrente.
    // Un POOL de Threads consiste en crear un conjunto de hilos que van a ejecutar todas las tareas.
    // Por ejemplo, podemos crear 3 hilos que ejecuten 10 tareas, donde cada tarea se asginara a un hilo y cuando finalice se asignara otra tarea a ese hilo.
    // Contras, tarda mas en ejecutar las tareas ya que no tenemos un hilo para cada tarea, por tanto algunas tareas se ejecutaran despues de otras y no se ejecutaran todas en paralelo.

    public static void EjecucionSinPoolThreads() {
      // Creamos un Thread cada vez que ejecutemos una tarea. Por tanto, se crearan 20 Threads y trabajaran todos en paralelo.
      for (int i = 0; i < 20; i++) {
        System.Threading.Thread t1 = new System.Threading.Thread(EjecutarTarea);
        t1.Start();
      }
    }

    public static void EjecucionConPoolThreads() {
      // Creamos un PoolThread para ejecutar las 20 tareas con menos de 20 hilos, se van a reutilizar los hilos una vez finalicen su tarea.
      for (int i = 0; i < 20; i++) {
        // Pasamos la variable i como object para saber que nº de tarea ejecuta ese hilo.
        ThreadPool.QueueUserWorkItem(EjecutarTarea, i);
      }
    }

    static void EjecutarTarea(object o) {
      int numTarea = (int)o;
      Console.WriteLine($"Tarea nº: {numTarea} con Thread nº: {System.Threading.Thread.CurrentThread.ManagedThreadId}, ha empezado.");
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine($"Tarea nº: {numTarea} con Thread nº: {System.Threading.Thread.CurrentThread.ManagedThreadId}, ha terminado.");
    }

    #endregion

    #region AUX
    class CuentaBancaria {

      private double saldo;

      private object lockThread = new object();

      double Saldo { set; get; }

      public CuentaBancaria(double _saldo) {
        this.Saldo = _saldo;
      }

      public double RetirarEfectivo(double _retirada) {
        if ((Saldo - _retirada) < 0) {
          Console.WriteLine("Dispone de {0}$ en la cuenta. No se puede retirar efectivo.", Saldo);
        } else if (Saldo >= _retirada) {
          Saldo -= _retirada;
          Console.WriteLine("Ha retirado {0}$. Le quedan {1}$ en la cuenta.", _retirada, Saldo);
        }

        return Saldo;
      }

      public void RetirarEfectivoNormal() {

        // Mostramos que thread esta ejecutando este metodo RetirarEfectivo().
        Console.WriteLine("Ejecutado por el thread = " + System.Threading.Thread.CurrentThread.Name);

        this.RetirarEfectivo(500);
      }

      public void RetirarEfectivoBloqueado() {

        // Bloqueamos la ejecucion de la siguiente tarea para que solo se pueda ejecutar en un hilo y no se ejecute en varios hilos en paralelo a la vez.
        lock (lockThread) {
          // Mostramos que thread esta ejecutando este metodo RetirarEfectivo().
          Console.WriteLine("Ejecutado por el thread = " + System.Threading.Thread.CurrentThread.Name);

          this.RetirarEfectivo(500);
        }

      }

    }
    #endregion


  }
}
