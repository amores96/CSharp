﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados {


  class ExpresionLambda {

    // Declaramos el delegado.
    delegate int delegadoCuadrado(int _num);
    delegate int delegadoSuma(int _num1, int _num2);


    public static void EjecutarExpresionLambda() {

      // <<<<<<<<<<<<<<<<<<<<  EXPRESION LAMBDA 1 PARAMETRO  >>>>>>>>>>>>>>>>>>>>
      // Declaramos el objeto operacionCuadrado de tipo de delegado delegadoCuadrado que apunta al metodo ObtenerCuadrado.
      delegadoCuadrado operacionCuadrado;
      operacionCuadrado = new delegadoCuadrado(Metodos.ObtenerCuadrado);

      // Llamamos al objeto operacionCuadrado para que llame al metodo ObtenerCuadrado.
      int retornoCuadrado = operacionCuadrado(2);
      Console.WriteLine("El cuadrado de 2 = {0}", retornoCuadrado);

      // EXPRESION LAMBDA. Nos permite implementar la funcion de ObtenerCuadrado directamente sobre el objeto delegado operacionCuadrado.
      operacionCuadrado = new delegadoCuadrado(num => num*num);

      // Llamamos al objeto operacionCuadrado para que ejecute la expresion lambda a la que apunta.
      retornoCuadrado = operacionCuadrado(2);
      Console.WriteLine("Con expresion lambda obtenemos el cuadrado de 2 = {0}", retornoCuadrado);


      // <<<<<<<<<<<<<<<<<<<<  EXPRESION LAMBDA 2 PARAMETROS  >>>>>>>>>>>>>>>>>>>>
      // Declaramos el objeto operacionSuma de tipo de delegado delegadoSuma que apunta al metodo SumarNumeros.
      delegadoSuma operacionSuma = new delegadoSuma(Metodos.SumarNumeros);

      // Llamamos al objeto operacionSuma para que llame al metodo SumarNumeros.
      int retornoSuma = operacionSuma(3, 2);
      Console.WriteLine("La suma de 3 + 2 = {0}", retornoSuma);

      // EXPRESION LAMBDA. Para implementar el metodo SumarNumeros con expresion lambda con dos parametros. Estos deben ir entre parentesis.
      operacionSuma = new delegadoSuma((_num1, _num2) => _num1 + _num2);
      
      // Llamamos al objeto operacionSuma para que ejecute la expresion lambda a la que apunta.
      retornoSuma = operacionSuma(3, 2);
      Console.WriteLine("Con expresion lambda obtenemos la suma de 3 + 2 = {0}", retornoSuma);


      // <<<<<<<<<<<<<<<<<<<<  EXPRESION LAMBDA CON LISTAS  >>>>>>>>>>>>>>>>>>>>
      // Declaramos la lista que vamos a utilizar en la expresion lambda.
      List<int> sucesionNumeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      // Utilizamos una expresion lambda como un predicado. Los predicados si la condicion es true (num % 2 == 0) devuelven un valor (num) y lo va guardando en la lista numerosPares.
      // La variable (num) es una variable transitoria local que solo existe en ese pequeño ambito.
      List<int> numerosPares = sucesionNumeros.FindAll( num => (num % 2 == 0) );

      // Imprimimos por consola la lista de numeros pares guardada con expresion lambda como si fuera un foreach.
      // Si en la expresion/bloque sentencia de la expresion lambda queremos varias lineas de codigo, debemos hacer entre llaves y cada linea con (;).
      numerosPares.ForEach(num => { 
        Console.Write("Numero par = "); 
        Console.WriteLine(num); 
      });


      // <<<<<<<<<<<<<<<<<<<<  EXPRESION LAMBDA CON CLASES  >>>>>>>>>>>>>>>>>>>>
      // Vamos a comprobar si la edad de dos personas es igual con expresiones lambda.

      Persona P1 = new Persona("Adrian", 26);
      Persona P2 = new Persona("Jose", 30);

      Persona.delegadoCompararEdad operacionCompararEdad = ((_p1, _p2) => _p1.Edad == _p2.Edad);

      bool edadMayor = operacionCompararEdad(P1, P2);

      if (edadMayor) Console.WriteLine("Tienen la misma edad.");
      else Console.WriteLine("NO tienen la misma edad.");


      edadMayor = operacionCompararEdad(new Persona("Mario", 15), new Persona("Manu", 15));

      if (edadMayor) Console.WriteLine("Tienen la misma edad.");
      else Console.WriteLine("NO tienen la misma edad.");

    }

    class Metodos {

      public static int ObtenerCuadrado(int _num) {
        return _num * _num;
      }

      public static int SumarNumeros(int _num1, int _num2) {
        return _num1 + _num2;
      }

    }

    class Persona {

      public delegate bool delegadoCompararEdad(Persona _p1, Persona _p2);

      private string nombre;
      private int edad;

      public string Nombre { get => nombre; set => nombre = value; }
      public int Edad { get => edad; set => edad = value; }

      public Persona(string _nombre, int _edad) {
        this.nombre = _nombre;
        this.edad = _edad;
      }
    }


  }

}
