using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;         // Thread.
using System.Threading.Tasks;   // Task.


namespace ThreadsTasks {
  class Program {
    static void Main(string[] args) {

      #region THREADS
      // SIMPLE
      //ThreadTest.EjecucionParalelaThreads();
      //ThreadTest.EjecucionParalelaThreadsCuenta();

      // SINCRONIZACION
      //ThreadTest.EjecucionParalelaThreadsSincronizada();

      // BLOQUEO
      //ThreadTest.EjecucionParalelaThreadsBloqueada();

      // TAREA FINALIZADA  =  TaskCompletionSource
      //ThreadTest.EjecucionTaskCompletionSource();

      // POOL de THREADS
      //ThreadTest.EjecucionSinPoolThreads();
      //ThreadTest.EjecucionConPoolThreads();
      #endregion

      #region TASKS
      // SIMPLE
      //TaskTest.EjecutarTask();

      // TASK CONSECUTIVA
      TaskTest.EjecutarTaskConsecutiva();


      #endregion


      Console.ReadKey();

    }



  }
}
