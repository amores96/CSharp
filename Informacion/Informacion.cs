#region INTRO
/*
Apuntes CSharp
Curso udemy

DEFINICIONES
	- Programación Estructurada  =  Consiste en la subdivision de problemas mas pequeños para ir abordandolos de manera mas simple.

	- Algoritmo  =  Una vez subdividido, creamos el algoritmo que consiste en una lista de pasos finitos que se ejecutan de forma secuencial para resolver un problema.

	- Keyword (Palabra Clave)  =  Son palabras que utiliza el lenguaje y que no se pueden declarar como identificadores de variables.

*/
#endregion

#region CONSOLA
	//Salidas
		System.Console.Write("Texto a mostrar.");	//No tiene (\n) al final, por tanto no salta de linea.
		System.Console.WriteLine("Variable 1 = {0}.  Variable 2 = {1}", nombreVariable1, nombreVariable2); 	//Para mostrar texto con variables.
	
	//Entradas
		System.Console.ReadKey();  //Se espera a leer cualquier tecla.
		<variableString> = Console.ReadLine();  //Leer una cadena de texto.
#endregion

#region DATOS

	#region Tipos
		// Tipos de VALOR  =  Almacenan el dato directamente.
			//- Simples(bool, byte, int, float, double, decimal, etc...)
			//- Numeracion
			//- Estructura
			//- Tupla

		// Tipos de REFERENCIA  =  Almacenan referencias en sus datos, es decir, objetos. Podriamos tener 2 referencisa que apunten al mismo objeto, por tanto modificando uno los modificamos todos.
			//- Clase(String, Colecciones, etc...)
			//- Interfaz
			//- Matriz
			//- Delegados
			//- VAR:
				//- Nos permite definir una variable sin especificar el tipo. El compilador le asignara en funcion de la informacion que almacenara. 
				//- Se conoce como Variables locales con asignacion implicita de tipos.
				//- CONDICIONES:
					//- Se debe inicializar en la misma linea que se declara.
					//- No se puede declarar mas de 1 variable en la misma linea.
					//- Solo se pueden declarar variables con tipo implicito:
						//1.Variables locales con ambito de metodo.
						//2. Inicializacion en bucles for.
						//3. En instrucciones foreach

		//Ejemplo:
		string cadena1 = "Hola";  // Un String es un tipo de dato de referencia, ya que String es una clase.
		string cadena2 = cadena1; // cadena2 es una referencia que apunta al mismo objeto que cadena1, por tanto, si modificamos cadena2 estamos modificando cadena1 de forma implicita.
	#endregion

	#region Paso por Valor VS Referencia
		//-Pasar por Valor = Se realiza una copia del dato. No se trabaja con el original.
		//- Pasar por Referencia:
			//ref = Se envia una referencia de la variable. Por tanto se trabaja con el original. Es necesario inicializar la variable antes de pasarla por referencia como argumento.
				//Sintaxis = ref <tipoVariable> <nombreVariable>

			//out = Se utiliza cuando la variable no se ha inicializado antes de ser enviada a un metodo como argumento. Es como una salida del metodo pero que esta declarado fuera de este.
				//Sintaxis = out <tipoVariable> <nombreVariable>
	#endregion

	#region Decimales
		// Declaracion
			double <nombreVariable> = 8.5;
			float <nombreVariable> = 8.5F;		//Se debe asignar el sufijo F para indicarle que es de tipo float.
			decimal <nombreVariable> = 8.5M;  //Se debe asignar el sufijo M para indicarle que es de tipo decimal.

		//Operaciones  -  Si queremos operar con decimales en un formato concreto tambien deberemos añadir los sufijos:
			float < variableFloat > = (16.43F / 22.15F);
			double < variableDouble > = (16.43M / 22.15M);
	#endregion

	#region Object
		// - Todos los tipos de datos (de valor y de referencia) vienen del espacio de nombres (System.Object).
		// - Todos los tipos de C# son un objeto, porque descienden directa o indirectamente de object.
		// - Si declaramos una variable de tipo object podemos asignarle valores de cualquier tipo. Tambien podemos guardar objetos de cualquier clase como si fuera un valor.
		// - Es peligroso utilizar datos de tipo Object ya que los errores por ejemplo de conversion de datos se detectan en ejecucion y no en compilacion.
		// - Sería parecido a (var), pero con variables de tipo object no se pueden realizar operaciones directamente sobre el.
				
		object numero = 25;
		object nombre = "Adrian";

		Clase nombreObjeto = new Clase();
		object copiaClase = nombreObjeto;     // En un dato de tipo object podemos guardar objetos de cualquier clase.

		#region Conversion Tipos
			// - Hay dos tipos de conversion:
				// 1. Implicita  -  Donde no se necesita ninguna sintaxis para realizar la conversion. Se hace de forma automatica. Por ejemplo cuando guardamos una variable de tipo byte en otra de tipo int.
				// 2. Explicita  -  Requieren una expresion Cast para realizar conversiones en las que se puede perder informacion, como por ejemplo intentar guardar una variable int en una variable byte.
					<variableInt> = Convert.ToInt32(<variableString>);	//Convertimos el string a tipo int. Convert es una clase y ToInt32() un metodo para convertir tipos de datos.
			
			// CAST  -  Pasamos una variable entera a una variable byte.
				byte <variableByte> = (int)<variableInt>

			// BOXING y UNBOXING  -  Una variable de cualquier tipo puede ser tratada como un objeto.
				// Boxing  =  Convertir cualquier tipo de dato a un tipo Object. Conversion implicita o explicita. Asigna una instancia de object en la memoria HEAP y se copia el valor a ese objeto. Ejemplo:
					int a = 50;
					object objeto = a; 		//Hacemos una conversion implicita de a a objeto.

				// Unboxing  =  Convertir un tipo Object en un tipo de valor. Conversion explicita con una expresión Cast. También nos puede permitir realizar operaciones sobre un object.
					object objeto = 50;
					int a = (int)objeto;	//Conversion explicita con expresion Cast.

					int num1 = 10;
					object resultado;
					resultado = (int)num1 + 10;   //La expresion cast nos permite realizar una operacion con el Object directamente.
		#endregion

#endregion

	#region Tupla
		// - Es una variable que tiene campos. Cada campo tiene un identificador y un tipo de dato.
		// - Sintaxis  =  (tipo) <identificador> = (<valor>);

		(double, int) tupla1 = (4.543, 2);
		tupla1 = (4.543, 2)
		tupla1.Item1 = 4.543
		tupla1.Item2 = 2

		(string nombre, int edad, int numero) persona1 = ("Adrian", 26, 607493549);
		persona1 = ("Adrian", 26, 607493549)
		persona1.nombre = "Adrian"
		persona1.edad = 26
		persona1.numero = 607493549

		var persona1 = (nombre: "Adrian", edad: 26, numero: 607493549); 	//Variable de tipo tubla (persona1) que contiene 3 campos (nombre, edad, numero).
		persona1 = ("Adrian", 26, 607493549)
		persona1.nombre = "Adrian"
		persona1.edad = 26
		persona1.numero = 607493549
  #endregion

	#region Array y Matrices

	#region Simples
		// Es una variable que almacena elementos de un mismo tipo.
		// Las Matrices son objetos de la clase Array.
		
		// Sintaxis = tipo[] < nombreVariable > = new tipo[< tamaño >]
			//- tipo[] < nombreVariable >   = Declaracion de la matriz.
			//- new tipo[< tamaño >] = Instancia, creacion del objeto de la clase Array.
		
		// Declaracion  =  No se reserva memoria para esta matriz, ya que aun no se sabe su tamaño.
			int[] matriz1D;
			int[,] matriz2D;
			int[,,]matriz3D;

		// Instanciacion  =  Se reserva memoria para la matriz con el tamaño especificado.
			// 1D
				int[] matriz1D; 				//Declaramos.
				matriz1D = new int[7];	//Instanciamos por separado.

			// 2D
				int[,] matriz2D;
				matriz2D = new int[3,3];

			// 3D
				int[,,] matriz3D;
				matriz2D = new int[3,3,3];

		// Declaracion e Instanciacion  =  Podemos declarar e inicializar la matriz en la misma linea.
			// 1D
				int[] matriz1D = new int[7];					// El tamaño no cuenta desde 0, es decir, si ponemos [7] tendra 7 elementos y no 8 elementos.

			// 2D
				int[,] matriz2D = new int[3,3];					

			// 3D
				int[,,] matriz3D = new int[3,3,3];					

		// Inicializacion.
			// 1D
				int[] matriz1D = new int[4] {45, 25, 77, 93};
				int[] matriz1D = new int[] {45, 25, 77, 93};	//Si declaramos, isntanciamos e inicializamos en la misma linea podemos omitir el tamaño de la matriz. Al colocarle 4 valores el compilador sabrá que es de tamaño 4.
				int[] matriz1D = {45, 25, 77, 93};						//Si declaramos e inicializamos en la misma linea podemos omitir la instancia de la clase. Al colocarle 4 valores el compilador sabrá que es de tamaño 4.

				int[] matriz1D = new int[3];
				matriz1D[0] = 5;
				matriz1D[1] = 6;
				matriz1D[2] = 7; 	//Accedemos al 3 elemento con [2] y le asignamos el valor 7.

			// 2D
				int[,] matriz2D = new int[3,3] {	{1,2,3}, 
																					{4,5,6}, 
																					{7,8,9} };
				int[,] matriz2D = new int[] {	{1,2,3}, 
																			{4,5,6}, 
																			{7,8,9} };	
				int[,] matriz2D = {	{1,2,3}, 
														{4,5,6}, 
														{7,8,9}	};				

				int[,] matriz2D = new int[3,3];
					matriz2D[0,0] = 1;
					matriz2D[0,1] = 2;
					matriz2D[0,2] = 3;
					matriz2D[1,0] = 4;
					matriz2D[1,1] = 5;
					matriz2D[1,2] = 6;
					matriz2D[2,0] = 7;
					matriz2D[2,1] = 8;
					matriz2D[2,2] = 9;

	#endregion

	#region Matriz Escalonada  -  Jagged  
		// Tipo de matriz que no tiene el mismo numero de columnas en cada fila, por eso es escalonada. Cada elemento es una matriz, por tanto el tamaño es mucho mas flexible.

		// Unidimensional - Unidimensional. Es decir, tenemos un array de arrays, por eso cada fila tiene un tamño independiente.

		// Declaracion.
			int[][] matrizJagged;
		// Instanciacion
			matrizJagged = new int[4][];

		// Declaracion e Instanciacion.
			int[][] matrizJagged = new int[4][];
			matrizJagged[0] = new int[2];
			matrizJagged[1] = new int[4];
			matrizJagged[2] = new int[3];
			matrizJagged[3] = new int[6];

		// Declaracion, Instanciacion e Inicializacion
			int[][] matrizJagged = new int[][]{
				matrizJagged[0] = new int[] {1, 2};
				matrizJagged[1] = new int[] {1, 2, 3, 4};
				matrizJagged[2] = new int[] {1, 2, 3};
				matrizJagged[3] = new int[] {1, 2, 3, 4, 5, 6};
			};

		// Si Declaracion, Instanciacion e Inicializacion en la misma fila podemos omitir asignar el tamaño del array.
			int[][] matrizJagged = new int[][]{
				new int[2] {1, 2};
				new int[4] {1, 2, 3, 4};
				new int[3] {1, 2, 3};
				new int[6] {1, 2, 3, 4, 5, 6};
			};

			// Elementos
				matrizJagged[0][0] = 1;
				matrizJagged[0][1] = 2;
				matrizJagged[1][0] = 1;
				matrizJagged[1][1] = 2;
				matrizJagged[1][2] = 3;
				matrizJagged[1][3] = 4;
				matrizJagged[2][0] = 1;
				matrizJagged[2][1] = 2;
				matrizJagged[2][2] = 3;
			
		// Unidimensional - Bidimensional. Es decir, tenemos un array 1D de arrays en 2D. En otras palabras, un array de matrices.
			int[][,] matrizJagged;
			matrizJagged = new int [4][,];
			int[][,] matrizJagged = new int [4][,];
	#endregion

	#region Matriz VAR
		// - Para hacer una declaracion implicita con VAR se debe inicializar la matriz en la misma linea.
		// - No hace falta especificar el tipo, pero todos los elementos deben ser del mismo tipo.
		var matriz1D = new[] {1,2,3};
		var matriz1D = new[,] {{1,2,3},{1,2,3}};

		//Escalonada
			var matrizEscalonada = new[]{
				new[] {1,2},
				new[] {1,2,3,4,5}
			};
#endregion

	#region Matriz OBJECT
		// - Declaracion Implicita 
		// - Una matriz de tipo Object es como un struct, cada elemento puede ser de un tipo de dato diferente.
			object[] matrizObject;
			matrizObject = new object[5];

			object[] matrizObject = new object[5];
	#endregion

	#region TAMAÑOS MATRICES
		// Hay dos formas de obtener las dimensiones de una matriz:
			// 1 - Length  =  Obtiene el numero total de elementos para todas las dimensiones.
				matriz.Length;
				for (int i = 0; i <= matriz.length; ++i){};		//Nos permite iterar por todos los elementos de una matriz.

			// 2 - GetLength  =  Obtiene el numero de elementos de la dimension especificada.
				int[,] matriz2D = new int[1,3];		
				matriz2D.GetLength(0) = 1;	//Devuelve la longitud de la 1 dimension.
				matriz2D.GetLength(0) = 3;  //Devuelve la longitud de la 2 dimension.
	#endregion

#endregion

	#region Cadenas
// En .NET se trabaja con el estandar UTF-16 por tanto cada caracter ocupa 16 bits. 

// INICIALIZACION y DECLARACION
// Inicializacion con el alias "string".
string cadena1 = "";

					// Instanciando con el constructor de String.
					char[] caracteres = { 'H', 'o', 'l', 'a', ' ', 'M', 'u', 'n', 'd', 'o' };
					String cadena2 = new string(caracteres);



					// MODIFICAR un STRING
						// Los tring son inmutables, por tanto, no se pueden cambiar despues de ser creados.
						// Cuando modificamos una variable, realmente se esta creando un nuevo objeto de tipo String y asignandolo a esa variable.
        			// EJ:
		        		string cadena1 = "Hola";
		        		string cadena2 = cadena1; 	// cadena2 es una referencia al mismo objeto que cadena1.

		        		cadena1 += " a todos." 		// Como el string es inmutable, al modificarlo realmente estamos creando un nuevo objeto. Por tanto, cadena2 ya no es el mismo objeto que cadena1.
			
				// METODOS  =  Permiten modificar un string sin crear un nuevo objeto debido a la inmutabilidad de estos.

					// CONCATENAR
						// string.Concat()  =  Metodo para concatenar cadenas. Tiene muchas sobrecargas, por tanto los argumentos seran diferentes para cada sobrecarga.
							string cadena3 = "Hola";
							string cadena4 = "Mundo";
							string cadena5 = string.Concat(cadena3, cadena4);
								// SALIDA: cadena5 = HolaMundo

						// string.Join() = Metodo para concatenar cadenas pero nos permite añadir un separador entre cada cadena, como un espacio " ". Tambien tiene sobrecargas, por tanto los argumentos varian.
							string cadena6 = "Hola";
							string cadena7 = "Mundo";
							string cadena8 = string.Join(" ", cadena6, cadena7);
								// SALIDA: cadena8 = Hola Mundo

					// SEPARAR  -  .Split()
						// - Devuelve un array de Strings.
						// - Los argumentos son todos los caracteres que queremos utilizar como separador o delimitador. Podria ser ' ', '.', etc...
						// - Los delimitadores no se guardan como salida. Es decir, si delimitamos por '.', cada punto se guardara como un empty o cadena vacia.

					// MODIFICAR
						// .Replace()  =  Permite modificar un caracter o una parte de un string por otra especificada. Por ejemplo, podemos modificar la letra 'a' por '@'. 
						string cadena14 = cadena13.Replace("a", "@");
						Console.WriteLine(cadena14);

					// ELIMINAR
					// .Remove()  =  Nos permite eliminar una parte de la cadena. Trabaja con indices con sobrecarga de dos formas:
					// 1. Podemos eliminar desde el indice 3 al 6 de la cadena 
					// 2. Podemos eliminar todo lo que este desde la posicion 3 al final de la cadena.

			// .Trim() = Elimina el primer y ultimo caracter de una cadena.
			// .TrimEnd() = Elimina el ultimo caracter de una cadena.
			// .TrimStart() = Elimina el primer caracter de una cadena.

			// BUSCAR
			// - .Contains() = Devuelve un bool si encuentra el texto que se le pasa como argumento en cualquier parte de la cadena. Distingue entre Mayusculas y minusculas.
			// - .StarsWith() = Devuelve un bool si se encuentra el texto al inicio de la cadena.
			// - .EndsWith() = Devuelve un bool si se encuentra el texto al final de la cadena.
			// - .IndexOf() = Busca la primera aparicion de un caracter/cadena en el string.
			// - .LastIndexOf() = Busca la ultima aparicion de un caracter/cadena en el string.
	#endregion

	#region Estructuras
			// - Son conjuntos de Campos donde cada uno puede tener un tipo diferente. Podemos hacer estructuras de otras estructuras.
			// - Constructor = Va a realizar la inicializacion de los campos y la validacion de que la informacion aportada sea correcta. Se puede sobrecargar (polimorfismo).
			// - Metodo ToString() para mostrar los valores de todos los campos.

			// - Definicion
			< acceso > struct <nombreStruct> {
				//CAMPOS
				<acceso> <tipoCampo> <nombreCampo>;

				//CONSTRUCTOR
				<acceso> <nombreStruct>(<argumentos>){
					<validacionVariables>;
					<inicializacionVariables>;
				}
			}

			public struct Agenda {
				//CAMPOS
				public string Nombre;
				public int Edad;
				public string Telefono;

				//CONSTRUCTOR
				public Agenda(string Nombre, int Edad, string Telefono){
					this.Nombre = Nombre;
					this.Edad = Edad;
					this.Telefono = Telefono;
				}

				//METODO ToString()
				public override string ToString() {
					StringBuilder sb = new StringBuilder();
					sb.AppendFormat("Nombre = {0}, Telefono = {1}, Edad = {2}.", Nombre, Telefono, Edad);

					return (sb.ToString());
				}
			}

		// - Inicializacion
			<nombreStruct> <nombreVariable>;
				Agenda amigo1;
				Agenda[] contactos = new Agenda[20];

		// - Acceso Elementos:
			<nombreVariable>.<elemento>
				amigo1.Nombre = "Adrian";
				contactos[1].Nombre = "Adrian";

	// - Diferencias Estructura vs Clase:
	// - Estructura = Tipo de valor. Al instanciar la estructura se crea directamente en la memoria Stack. Por tanto, cada instancia es una posicion de memoria nueva. Las estructuras no pueden declararse de tipo estaticas.
	// - Clase = Tipo de referencia. Al instanciar la clase se crea una variable en la memria Stack que es una referencia al objeto que esta en la memoria Heap. Si igualamos una clase a otra al instanciar la clase, no estamos creando un objeto nuevo, si no que la referencia de la variable apunta al mismo objeto. Por tanto, al modificar uno modificamos los dos.
	#endregion

	#region Enumeraciones
	// - Son tipos que definimos con un numero finito de valores.
	// - Cuando tenemos informacion que solo va a tener 1 tipo de las posibles opciones.
	// - Caracteristicas:	
	// - Puede guardar muchos valores posibles, por tanto desperdicia memoria.
	// - Debemos agregar logica de control para asegurar los datos.

	// - Declaracion:
	enum <nombreEnumeracion>{ valor1, valor2,...,valorN};
				enum Semana {Luneas, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo};

		// - Definir valor para la enumeracion:
			enum Semana {Luneas=5, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo};

			int valor = (int)Martes;
			valor = 6; 

		// - Inicializacion
			<nombreEnumeracion> <nombreVariable> = <nombreEnumeracion>.<valor>;
				semana Dia = semana.Lunes;

		// - Mostrar dato como String:
			Dia.ToString();

		// - Mostrar dato como valor Numerico con la conversion Cast:
			int valor = (int)Dia;

		// - Comparaciones
			(Dia == semana.Lunes)
			((int)Dia == 1)
	#endregion

	#region Colecciones
	/* (System.Collections.Generic  =  contiene las clases de colecciones genericas)
	- Las colecciones son estructuras de datos dinamicas (clases de .NET) que nos permiten guardar cualquier tipo de informacion.
	- A diferencia de las matrices, las colecciones pueden aumentar o reducir de manera dinamica el tamaño de los elementos que guarda en su interior.
	- Hay 3 tipos de colecciones:
		1. Genericas.
		2. No Genericas.
		3. Concurrent.

	COLECCIONES GENERICAS
		- La idea original es poder utilizar los tipos de valor y tipos de referencia para que funcionen como parametros de metodos, clases, estructuras e interfaces. 
		- Son clases, estructuras, interfaces y metodos que tiene parametros de tipo (marcadores de posicion). Es decir, los parametros no son de un tipo en concreto (int, double, etc..) y son de tipo generico.
		- Son una plantilla de codigo que nos permite definir estructuras de datos con seguirdad de tipos, es decir, solo se tiene acceso a las ubicaciones de memoria autorizadas.
		- Caracteristicas:
			- Maximizamos la reutilizacion de codigo. Podemos definir un algoritmo y luego reaplicarlo cambiando los tipos de datos.
			- Mejor rendimiento. Suelen comportarse mejor en cuanto al almacenamiento y manipulacion de tipos de valor porque no es necesario realizar una conversion de tipos.
			- Podemos crear nuestras propias interfaces, clases, metodos, eventos y delegados genericos.
			- Podemos crear colecciones.
		- Hay 5 tipos:
			1. Dictionary
			2. List
			3. Queu
			4. Stack
			5. StoredList
		- Todas las colecciones (Dictionary, List, etc...) pertenecen a la misma clase por tanto tienen metodos comunes como .Clear(), .Count(), etc...

	FOREACH
		- Recorre la estructura de datos para cada elemento que contenga dentro.
		- Es la forma mas eficiente de realizar iteraciones en colecciones.
		- Mejor realizar las iteraciones asi que con un for.

		- Sintaxis:
			foreach (<tipoElemento> <elemento> in <nombreColeccion>){
				<instrucciones>...
			}
	*/

	//LISTAS  -  List<T>
	// - Es como una matriz unidimensional, pero sin tener que definir el tamaño. Contendra elementos donde cada elemento tiene un numero de indice.
	// - Una Lista es una clase del espacio de nombres System.Collections.Generic. Por tanto debe ser declarada e instanciada.

	// - Declaracion e Instanciacion:
			List<Tipo> <nombreLista> = new List<Tipo>();
					List<string> nombres = new List<string>();

					List<string> nombres = new List<string>() { "Adrian", "Amores", "Albelda" };


			// - Agregar elementos:
			// - Al final:
					< nombreLista>.Add(<elementoNuevo>);
						nombres.Add("Adrian");

				// - Posicion determinada:    El resto de elementos de la lista aumentan en una posicion del indice.
					<nombreLista>.Insert(<indice>, <elementoNuevo>);
						nombres.Insert(1,"Adrian");
		

			// - Acceder elementos:
				<nombreLista>[<indice>]
					nombres[0]

				// Iteracion elementos:
					foreach (string elemento in nombres){	// Para cada elemento de la lista, guarda una copia en la variable elemento en cada iteracion.
						elemento;
					}


			// - Total elementos:
				<nombreLista>.Count()	//Devuelve el numero total de elementos de la lista.
					nombres.Count()


			// - Encontrar Indice de Elemento:
				<nombreLista>.IndexOf(<elemento>);		//Devuelve el primer indice donde se encuentra dicho elemento. Devuelve -1 si no encuentra el elemento.
					nombres.IndexOf("Adrian");


			// - Eliminar elementos:
				// - Al final:
					<nombreLista>.Remove();
						nombres.Remove();

				// - Posicion determinada:    El resto de elementos de la lista disminuyen en una posicion del indice.
					<nombreLista>.RemoveAt(<indice>);
						nombres.RemoveAt(1);


			// - Borra todos los elementos de una lista:
				<nombreLista>.Clear();
					nombres.Clear();

		// STACK  (Pila)
			// - Es una coleccion de tipo LIFO = Last In First Out.
			// - Es una estructura de datos dinamica, podemos añadir y quitar elementos en tiempo de ejecucion.
			// - Es generica, por tanto acepta cualquier tipo.

			// - Declaracion e Instanciacion:
				Stack<tipoDato> <nombreStack> = new Stack<tipoDato>();
					Stack<double> miPila = new Stack<double>();

			// - Agregar elementos:
				// - Al principio  -  Al ser de tipo LIFO se agrega en la primera posicion.
					<nombreStack>.Push();
						miPila.Push(5.9);

			// - Eliminar elementos
				// - Quita y devuelve el primer elemento del Stack. Quita el ultimo elemento que se añadio.	
					<nombreStack>.Pop();
						miPila.Pop();

					var <nombreVariableLeer> = <nombreStack>.Pop();
						var variableLeer = miPila.Pop();				//Nos permite leer el ultimo valor añadido, a parte de eliminarlo.

				// - Elimina todos los elementos del stack:
					<nombreStack>.Clear();
						miPila.Clear();


			// - Leer elementos
				// - Leer el primer elemento del Stack:
					var <variableLectura> = <nombreStack>.Peek();
						var variableLeer = miPila.Peek();

				// - Determina si el elemento se encuentra en el stack:
					bool <variableLectura> = <nombreStack>.Contains(<elemento>);
						bool variableContiene = miPila.Contains(5.9);

				// - Obtener el numero de elementos del Stack:
					int <variableLectura> = <nombreStack>.Count();
						int elementosTotales = miPila.Count();

		// QUEUE  -  Cola
			// - Es una coleccion de tipo FIFO = First in First Out.

			// - Declaracion e Instanciacion:
				Queue<tipoDato> <nombreQueue> = new Queue<tipoDato>();
					Queue<double> miCola = new Queue<double>();

			// - Agregar elemento  -  Al ser de tipo FIFO se agrega al final edl queue:
				<nombreQueue>.Enqueue(<elemento>);
					miCola.Enqueue(5.6);

			// - Quita y devuelve el primer objeto que se añadio:
				<nombreQueue>.Dequeue();
					miCola.Dequeue();

				var <variableLectura> = <nombreQueue>.Dequeue();
					var variableLectura = miCola.Dequeue();

			// - Leer elementos
				// - Leer el primer elemento del Queue:
					var <variableLectura> = <nombreQueue>.Queue();
						var variableLeer = miPila.Queue();

			// - Obtener el numero de elementos del Queue:
				int <variableLectura> = <nombreStack>.Queue();
					int elementosTotales = miPila.Queue();


		// DICCIONARIOS
			// - Representa una coleccion de claves y valores. 
			// - Cada clave va a estar asignada a un conjunto de valores. Solo puede haber una clave igual. Si añadimos una clave que ya existe nos dara error.
			// - Funciona con dos elementos:
				// - TKey = Clave. 
				// - TValue = Valor.

			// - Declaracion e Instanciacion:
				Dictionary<<tipoKey>, <tipoValue>> <nombreDiccionario> = new Dictionary<<tipoKey>, <tipoValue>>();
					Dictionary <string, int> empleados = new Dictionary<string, int>();

			// - Agregar elementos:
				<nombreDiccionario>.Add(<elementoKey>, <elementoValue>);
					empleados.Add("Adrian", 22);

			// - Agregar valor a una clave  -  Podemos modificar el valor para una clave ya definida o crear un par clave-valor nuevo si no había ninguna definida.
				<nombreDiccionario>[<Key>] = <Value>;


			// - LECTURA

				// - Lectura con KEY. Obtenemos el value para un Key definido.
					var <variableLectura> = <nombreDiccionario>[<Key>];
						int años = empleados["Adrian"];

				// - Lectura recorriendo todo el Diccionario
					// - Lo que se lee de un diccionario es una Estructura.
					// - Esta estructura tiene la siguiente forma:
						KeyValuePair<TKey, TValue>     // - KeyValuePair = Par de clave-valor.

					// - Por tanto para recorrer un diccionario con un foreach el tipo de elemento sera una estructura KeyValuePair<TKey, TValue>:
						foreach(KeyValuePair<<tipoKey>, <tipoValue>> elemento in <nombreDiccionario>){
							// Para acceder a cada elemento del estruct:
							elemento.Key;
							elemento.Value;
							<instrucciones...>
						}

						foreach(KeyValuePair<string, int> elemento in empleados){
									string key = elemento.Key;
									int value = elemento.Value;

									Console.WriteLine("Key = {0}, Value = {1}.", key, value);
						}

			// BUSCAR  -  Devuelve un booleano con el estado de la busqueda. Si lo encuentra true y si no false.
				// - Buscar una Key:
					bool <variableEstado> = <nombreDiccionario>.ContainsKey(<key>);
						bool estado = empleados.ContainsKey("Adrian");

				// - Buscar un Value:
					bool <variableEstado> = <nombreDiccionario>.ContainsValue(<value>);
						bool estado = empleados.ContainsValue(25);

			// ELIMINAR
				// - Quitar un value a partir de una Key. Nos devuelve un booleano con el estado de la operacion.
					bool <variableEstado> = <nombreDiccionario>.Remove(<Key>);
						bool estado = empleados.Remove("Adrian");
#endregion

#endregion

#region METODOS

	// Los metodos deben compilarse antes de ser llamados, para cuando se compila la parte donde se les llama que ya esten compilados.

	#region Comun
static int nombreFuncion(int _variable1){
				<instrucciones...>
				return _variable1;
			}
#endregion

	#region Matrices
//Argumentos
static void nombreFuncion(int[,] matriz){
				<instrucciones>
			}

		//Return
			static int[,] nombreFuncion(){
				<instrucciones...>
				return matriz2D;
			}
#endregion

	#region Tupla
		// Devolvemos varios valores en formato de tipo Tupla
			
		// Declaramos una tupla para recibir los parametros de la funcion:
		(int variable1, decimal variable2, string variable3) variableRetorno;

		//Declaramos la funcion que devuelve una tupla:
			static (int, decimal, string) nombreFuncion(int _variable1, decimal _variable2, string _variable3){
				<instrucciones...>
				return (_variable1, _variable2, _variable3);
			}

		//Llamada metodo:
			(int, decimal, string) variableRetorno = nombreFuncion(variable1, variable2, variable3);
		#endregion

	#region Override
		// - Se utiliza para modificar un metodo ya implementado, es decir, un metodo que ya tiene su logica, en vez de modificar su codigo podemos hacer un (override) y reimplementar este metodo.
		<modificadorAcceso> override <tipo> <nombreMetodo> () { };
#endregion

	#region Delegados
		#region Delegados Simples
			// Un delegado es una referencia a un metodo. Es como un puntero a un metodo. Esto nos permite enviar como parametro una funcion a otra funcion.
			// Son funciones que delegan tareas en otras funciones.
			// Se utilizan cuando queremos llamar a metodos que estan en diferentes clases, es decir, permiten llamar a metodos de otras clases o ficheros.
			// Son utilizados en c# para llamar a eventos.

			// Sintaxis
			// Declaracion del objeto delegado. Debe tener la misma estructura que el metodo al que apunta.
			delegate <tipo> <tipoDelegado>(<argumentos>);

			// Declaracion del objeto del tipo de Delegado.
				tipoDelegado <objetoDelegado>;

			// Definicion metodo al que apunta el objeto.
				objetoDelegado = new tipoDelegado(<argumentos>);

			// Llamada objeto delegado.
				objetoDelegado(<argumentos>);
		#endregion

		#region Delegado en linea o Metodo Anonimo
			// Es util para crear delegados sin asignarle ningun metodo, podemos definir el metodo en el delegado.
			// Los metodos con nombres se compilan primero, antes que los metodos anonimos.
			// Es util para pasar un metodo anonimo como parametro de un metodo.
			// Es util para utilizar en eventos.


		#endregion

		#region Delegado Multidifusion
								// Los delegados multidifusion nos permiten asignar varios metodos a un mismo delegado.
								// Debemos pasar los argumentos de todos los metodos a los que apunta el delegado.
								// Los metodos deben ser de tipo de retorno void.
								// Podemos crear eventos que ejecutan muchos metodos cuando el evento es invocado.

		#endregion

		#region Delegados Predicados
								// Son delegados que solo pueden devolver un booleano.
								// Se utilizan principalmente para filtrar, en base a una condicion, elementos que estan en colecciones como listas, diccionarios, etc...

		#endregion

		#region Expresiones Lambda
								// Son funciones anonimas, es decir, que no tienen nombre y se pueden usar para crear delegados o tipos de arbol de expresion.
								// Se utilizan para simplificar la sintaxis de una funcion/metodo.
								// Con expresiones lambda se pueden escribir funciones locales que pueden pasarse como argumentos o como retorno de funciones.
								// Se utilizan cuando creamos delegados sencillos.
								// Son muy utiles en expresiones LINQ query.
								// Sintaxis:
								< parametros > => <expresion/bloque sentencia>;
									// Parametros  =  Son los parametros que lleva el metodo como argumentos.
									// Expresion o Bloque Sentencia  =  Es lo que lleva la funcion/metodo en su interior, es decir, lo que realiza la funcion/metodo.


				#endregion
	#endregion

#endregion

#region CLASES
	/*
	UML = tipos de diagramas para representar clases y hacer una descripcion clara sobre la clase.

	Una clase es un tipo de referencia.

	Instanciar = Quiere decir crear un objeto desde una clase. Por tanto instancia y objeto son lo mismo.
	Namespace = Nos permiten agrupar las clases dentro de un entorno.
	Ambito: Region en la que un tipo o un metodo existe.
		- Ambito Metodo: Si se declara una variable en un metodo solo existe en ese metodo.
		- Ambito Clase: Si se declara una variable en una clase se puede acceder a ella desde toda la clase.

	Miembros = Todo lo que contiene una clase (campos, atributos, metodos, etc...). Las propiedades y los metodos determinan el estado de un objeto.
		- Hay dos tipos de miembros en una clase:
			- Miembros estaticos = Son Miembros de clase, por tanto, pertenecen a la clase.
			- Miembros de instancia = Pertenecen a la instancia/objeto. Por tanto son individuales para cada objeto.
		- Campo / Propiedad = variable de cualquier tipo que se declara en una clase.
			- Atributos = son tipos de campos que se utilizan en los metodos.
		- Metodos = las funciones de una clase.

	Modificadores de Acceso:
		- Publico (public): Se tiene acceso desde el exterior. No tienen ninguna restriccion de acceso.
		- Privado (private): Solo se puede acceder dentro del ambito de la declaracion de la clase, desde fuera de la clase no se puede acceder.
			- (private protected): 
		- Protegido (protected): Solo se puede acceder dentro del ambito de la declaracion de la clase y en clases heredadas de esta.
			- (protected internal): 
		- Interno (internal): 

		- Si no se especifica el modificador de acceso, el contexto en el que se declara va a determinar la accesibilidad.
			- Las clases que se declaran en un namespace, si no se especifica el modificador, por defecto sera de acceso interno al namespace.
			- Los miembros de clase, si no se especifica el modificador, por defecto sera de acceso privado.

	Interfaz = Consiste en toda la informacion que pude comunicarse con el exterior, es decir, todos los metodos que son publicos.
		- No puede contener miembros privados.
		- Especifica que debe hacer una clase y como.
		- La implementacion de la interfaz es dada por la clase y puede ser explicita (Interface) o implicita.
	Encapsulacion (Data Hiding) = Consiste en organizar los atributos y los metodos en un espacio especifico. Con esto ocultamos cierta informacion a ciertar partes del programa.

	Propiedades  -  Son metodos especializadas de la calse que nos proporcionan una facilidad para manipular los campos privados.
		- Accessor = Geters y Seters para obtener informacion del objeto. De esta forma se controla como se recibe y se entrega la informacion.
		- Hay 4 tipos de propiedades:
			- Lectura y Escritura (get y set)
			- Solo Lectura. (get)
			- Solo Escritura. (set)
			- Propiedades autoimplementadas. Cuando no se necesita ninguna logica en la propiedad.

	Sobrecarga de metodos 
		- Es la forma más comun de implementar el polimorfismo. El polimorfismo es la capacidad de redefinir un metodo en mas de una forma.
		- Podemos crear varias versiones de un metodo que tengan el mismo nombre pero que el tipo de return y los argumentos de este sean diferentes.

	Miembros con forma de expresión
		- Podemos utilizar una definicion con cuerpo de expresion siempre que la logica de un miembro se componga de una unica expresión.
		- Sintaxis:  [miembro => expresion]
			Ejemplo:
				public double Num2 {
					set { num2 = value; }
					get { return num2; }
				}

				public double Num2 {
					set => num2 = value;
					get => num2;
				}

	Constructor
		- Es un método al que se llama cuando se crea un objeto.
		- Caracteristicas:
			- C# crea un constructor por defecto.
			- Puede o no tener parametros.
			- Se utiliza para inicializar campos del objeto.
			- Lleva el mismo nombre que la clase.
			- No tiene tipo, no devuelve ningun valor.
			- Se pueden tener infinitos constructores gracias a la sobrecarga de metodos (polimorfismo).

	Destructor
		- Es un metodo que destruye un objeto/instancia de una clase cuando ya no va a ser utilizado.
		- El destructor es llamado de forma implicita por el recolector de basura de .NET Framework. Por tanto no podemos invocar al destructor de forma explicita.
		- Lleva el mismo nombre que la clase.
		- Solo hay un destructor, por tanto no se puede hacer sobrecarga de metodos en el destructor.

	THIS
		- Si tenemos dos variables que se llaman igual y una es de ambito de metodo y otra de ambito de clase, en un metodo siempre se priorizara la de ambito de metodo.
		- this.  =  Es una palabra clave de acceso. Tiene diversos usos:
			1. Para hacer referencia a una instancia de clase.

	STATIC
		- Es un modificador que hace que el miembro sea de clase, por tanto pertenece a la clase y no a la instancia/objeto.
		- No es necesario instanciar la clase (crear un objeto) para poder utilizar los miembros static. 
		- Se llama por el nombre de la clase y no por el nombre del objeto.
		- Los miembros estaticos no pueden ser llamados con el operador this.

		Clase Estatica
			- En una clase que es estatica no se pueden crear objetos o instanciar esta clase. Por tanto no se debe instanciar esta clase para utilizarla. 
			- Todos sus miembros (campos, metodos, etc...) serán estaticos y llevarán el modificador static.
			- Se utilizan a modo de biblioteca con metodos, mas que a modo de clase para generar un objeto.

		Campo Estatico
			- Son campos de clase. Por tanto se comparten para todos los objetos.
			- Solo se crea una copia para toda la clase. Y se accede con la clase o con un objeto, aunque lo modificamos para todas las instancias.
			- No se admiten variables locales como estaticas. Solo sirve para campos de clases.
			- Tiene 2 utilidades principalmente:
				- ID: Identificar el numero de objetos que se han creado.
				- Valor compartido entre todos los objetos de una clase.

		Metodo Estatico
			- Se utiliza para metodos que se necesiten llamar sin tener que instanciar o crear un objeto de esa clase.
			- Un metodo estatico solo puede acceder a miembros estaticos. Por ejemplo, un metodo solo puede acceder a campos estaticos.
			- Cualquier metodo puede llamar a un metodo estatico.

		Constructor Estatico
			- Se llama de forma automatica para inicializar la clase, por tanto no se puede llamar de forma explicita.
			- Lo utilizaremos para inicializar los campos estatico o para realizar cualquier accion que solo se deba realizar una vez.
			- Los constructores estaticos se utilizan normalmente cuando la clase hace uso de un archivo de registro y el constructor necesita escribir en esta clase.
			- Caracteristicas:
				- Un constructor estatico no puede llevar modificadores de acceso (public,private,etc...) ni parametros.
				- Una clase solo puede contener un constructor estatico. Por tanto no se pueden sobrecargar.
				- No se pueden heredar.

	Herencia
		- Nos permite crear nuevas clases que podrán reutilizar miembros (campos, metodos, etc...) de otras clases.
		- Las clases que heredan, se pueden dividir en:
			- Clase base: Cuyos miembros son heredados por otra clase derivada. 
			- Clase derivada: Recibe miembros heredados de otra clase base. Pero no puede tener mas de una clase base

		Sintaxis:
			<ClaseDerivada> : <ClaseBase>

		Miembros que no se pueden heredar:
			- Constructores estaticos y de instancia.
			- Destructores.

		Tipos de herencia:
			- Herencia única: La clase derivada hereda los miembros de la clase base. Solo dos clases.
			- Herencia multinivel: Las clases van derivando de unas a otras. Muchas clases que heredan de unas a otras en escalera.
			- Herencia jerárquica: La clase base le sirve a muchas clases derivadas, pero estas clases derivadas no tienen herencia entre ellas.

			* Una clase derivada no puede tener dos clases bases.

		Caracteristicas:
			- Solo hay una clase base. Una clase base puede tener cualquier numero de clases derivadas pero una clase derivada solo puede tener una clase base.
			- Una clase derivada hereda a todos los miembros de su clase base, a excepcion de los constructores.
			- Una clase derivada no hereda los miembros privados de su clase base, sin embargo, si se puede acceder con propiedades a los campos privados si que podrá acceder a ellos.

		Constructores
			- Los constructores no se heredan de una clase base a una clase derivada.
			- Para llamar a un constructor desde una clase derivada, tenemos que crear un constructor para la clase derivada que llame a un constructor de la clase base, con la siguiente sintaxis:

					<constructorClaseNueva>(<argumentosConstructorDerivado>, <argumentosConstructorBase>): base(<argumentosConstructorBase>) {
						<instrucciones...>
					}

	Clase Object
		- Es la clase base para todas las clases con las que contamos en .NET. Pertenece al namespace System.
		- Cada clase que tenemos en C# se deriva directa o indirectamente de la clase object.
		- Cualquier clase que no tenga una clase base, estará derivada de la clase object.
		- La clase Object actua como la raiz de toda jerarquía de herencia para cualquier programa de C#, esta herencia esta integrada de forma implicita.
		- Todos los metodos de la clase object estan disponibles para todos los objetos del namespace System.

	Clase Generica
		- Una clase generica nos permite crear campos sin definir su tipo. El tipo lo definimos al instanciar la clase.
		- Esto nos permite definir un tipo diferente para los campos en cada instancia de la clase. Es decir, cada objeto instanciado puede tener un tipo diferente para el mismo campo.

		*/

	//Instanciar objeto
	< nombreClase > <nombreObjeto> = new <nombreClase()>;
		// - <nombreClase> <nombreObjeto>  =  Creamos la referencia al objeto. Es decir, creamos una variable del tipo de la clase.
		// - new <nombreClase()>;  =  Creamos el objeto en la memoria HEAP.

	//Declaracion Clase
		//Campos
			<acceso> <tipoDato> <nombreCampo> { 
				<instrucciones...>
			}

		//Metodos  -  Hay dos tipos:
			// 1. Static  =  Metodos de clase. Se accede a traves de la clase. Modificador = static.
			// 2. Instancia = Metodos de instancia. Se accede a traves de instancias de la clase, es decir, de objetos. No tiene modificador.
			<acceso> static <tipoRetorno> <NombreMetodo>(<parametros>) {
				<instrucciones...>
			}
#endregion

#region MEMORIA 
	/*
	STACK vs HEAP

	STACK(pila)
		- Memoria estatica y se debe reservar antes de que se ejecute el programa, en la compilacion.
		- Almacena el entorno del programa. Parametros de metodos, variables de tipo valor, entorno de ejecucion y referencias a objetos.
		- Matriz de memoria ordenada con una estructura de tipo LIFO.
		- Push = insertar un elemento en la memoria.
		- Pop = extraer un elemento de la memoria.
		
	HEAP (monton)
		- Se almacenan fragmentos que contienen ciertos tipos de objetos.
		- No tiene orden de entrada ni de salida.
		- El tamaño es limitado, si cuando se crea un objeto no hay memoria para asignarlo se va a producir un error.
		

		- Los objetos se crean en memoria STACK y HEAP:
			- <nombreClase> <nombreObjeto> = ...    ->  Con el <nombreObjeto> creamos una referencia que se almacena en memoria Stack. Esta posicion de memoria contiene la direccion (puntero) a la memoria HEAP donde se crea el objeto.
			- ... = new nombreClase()  =  Con el new definimos que el objeto se debe ejecutar en memoria HEAP y lo creamos con la palabra clave new.

			- Podemos hacer que dos referencias apunten al mismo objeto. 
	*/
#endregion

#region EXCEPCIONES
	// - Las excepciones se producen en tiempo de ejecucion.
	// - Hay veces que no se sabe cuando pueden ocurrir.
	// - Detienen la ejecucion del programa, por tanto, se deben controlar de laguna forma para que no detengan la ejecucion del programa.

	// ADMINISTRACION de EXCEPCIONES
		try {		// Se jecuta siempre. Aquí va el código que se desea controlar.
					<instrucciones...>
				}
				catch (Excepcion e) {	// Se ejecuta únicamente cuando se produce una excepción.
					<instrucciones...>
				}
				finally{	// Se ejecuta siempre despues de try o try-catch. Se utiliza para limpiar o liberar cualquier cosa que se ha utilizado en el try-catch.
					<unstrucciones...>
				}
#endregion

#region THREADS
	// Se utilizan para la concurrencia o programación asíncrona.
	// Los threads o hilos nos permiten ejecutar tareas en paralelo. Cada tarea se asigna a un hilo de ejecución.
	
	// Creacion del hilo:
		Thread t1 = new Thread();
	// Inicio del hilo:
		t1.Start();
	
	// Sincronizacion = Nos permite definir con que orden se ejecuta cada tarea de hilo. Sincroniza la ejecucion de los hilos.
	// Metodo Join = Define que hasta que no termine la ejecucion de ese hilo, no se ejecutara otra tarea en cualquier otro hilo.
		t1.Join()

	// Bloqueo = Permite bloquear un hilo mientras ejecuta la tarea, para que esa tarea solo se pueda ejecutar en un hilo al mismo tiempo.
		t1.Lock()

	// Completada = Nos permite detectar cuando una tarea de un hilo ha finalizado para ejecutar otra a continuacion.
		// Crear variable de tipo TaskCompletionSource
			var < nombre > = new TaskCompletionSourve<generico>();

#endregion

#region TASK
	// Se utilizan para la concurrencia o programación asíncrona.
	// Se colocan un nivel por encima (un nivel de abstraccion superior) de los Threads y se encargan de gestionar/optimizar el uso del procesador.
	// Utilizan un pool de threads para gestionar el numero de threads optimo para cada equipo en funcion del procesador y del numero de tareas a realizar.
	// Es mejor utilizar Task que Threads, ya que es mucho mas flexible.
	// La biblioteca .NET Framework tiene muchas mas herramientas para manejar TASKS que THREADS.


#endregion