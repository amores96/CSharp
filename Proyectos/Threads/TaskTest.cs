using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;         // Thread.
using System.Threading.Tasks;   // Task.



namespace ThreadsTasks {
  class TaskTest {

    #region TASK SIMPLE
    public static void EjecutarTask() {

      // Definicion de la tarea 1.
      Task tarea1 = new Task(Tarea1);
      // Arrancamos la tarea 1.
      tarea1.Start();

      // Definicion de la tarea 2.
      Task tarea2 = new Task(() => Tarea2(null));
      // Arrancamos la tarea 2.
      tarea2.Start();


      // Definicion de la tarea 3.
      Task tarea3 = new Task(
        () => {
          for (int i = 0; i < 20; i++) {
            var numThread = Thread.CurrentThread.ManagedThreadId;
            Thread.Sleep(500);

            Console.WriteLine($"Tarea 3. Tarea nº {i} ejecutada por el Thread {numThread}");
          }
        });
      // Arrancamos la tarea 3.
      tarea3.Start();

    }

    #endregion

    #region TASK CONSECUTIVA

    public static void EjecutarTaskConsecutiva() {

      // Definicion de la tarea 1.
      Task tarea1 = new Task(Tarea1);
      // Arrancamos la tarea 1.
      tarea1.Start();

      // Definicion de la tarea 2.
      Task tarea2 = tarea1.ContinueWith(Tarea2);


    }


    #endregion

    #region AUX
    public static void Tarea1() {
      for (int i = 0; i < 20; i++) {
        var numThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(500);

        Console.WriteLine($"Tarea 1. Tarea nº {i} ejecutada por el Thread {numThread}");
      }
    }

    // Argumento Task obj es para poder utilizar el metodo ContinueWith y poder ejecutar esta tarea 2 despues de la tarea 1.
    public static void Tarea2(Task obj) {
      for (int i = 0; i < 20; i++) {
        var numThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(500);

        Console.WriteLine($"Tarea 2. Tarea nº {i} ejecutada por el Thread {numThread}");
      }
    }
    #endregion


  }
}
