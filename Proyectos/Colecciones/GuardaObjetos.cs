using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  * CLASE GENERICA
  * Una clase generica permite definir campos sin tipo, y al instanciar la clase definimos el tipo de dato.
  * 
  * Con esta clase vamos a crear una matriz para almacenar datos de cualquier tipo.
  * Podremos definir el tamaño de esta matriz.
  * Podremos agregar datos de cualquier tipo.
  * Podremos devolver un elemento de la matriz a partir del indice.

 */

namespace Colecciones {
  class GuardaObjetos<T>  //Con <T> le indicamos que la clase generica "GuardaObjetos" va a recibir parametros de cualquier tipo, tanto de valor como de referencia. Al instanciar la clase le debemos indicar el tipo, por tanto, la misma clase puede trabajar con distintos tipos en diferentes instancias.
  {

    //CAMPOS
    private int i = 0;
    private T[] matrizElementos;

    //CONSTRUCTOR
    public GuardaObjetos(int _numeroDeElementos) {
      matrizElementos = new T[_numeroDeElementos];
    }

    //METODOS
    public void AgregarElemento(T _elemento) {
      matrizElementos[i] = _elemento;
      i++;
    }

    public T ObtenerElemento(int _indiceElemento) {
      return matrizElementos[_indiceElemento];
    }

  }
}
