/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 1
	Estudiante: Daniel Araya Araya
	
	Enunciado:
	Validez de parentesis:
	Se va a recibir un string S que contienen unicamente los caracteres '(' y ')', ustedes deben escribir una funcion que valida si la secuencia de parentesis es valida,
	esto quiere decir que cada parentesis abierto tenga un parentesis que lo cierre.
	Por ejemplo:
	"()" -> True
	"((" -> False
	"(()(()))" -> True
	"(()(())))" -> False
*/

//Your code starts here
using System;
public class TC08
{
    /// <summary>
    /// Metodo para Validar la secuencia de parentesis.
    /// </summary>
    /// <param name="str"></param>
    public void ValidezParentesis(string str)
    {
        int contParentesisD = 0;
        int contParentesisI = 0;
        bool estado = false;
        char[] parentesis = str.ToCharArray();
        for (int i = 0; i < parentesis.Length; i++)//Recorro la lista
        {
            if (parentesis[i].Equals('('))//Pregunto si en el arreglo hay parentisis abierto y lo cuento cuanta veces hay
            {
                contParentesisI++;
            }
            else
            {
                contParentesisD++;
            }
        }
        if (contParentesisI == contParentesisD)//Pregunto si esos contadores son iguales.
        {
            estado = true;
        }
        Console.WriteLine(estado);//Imprimo estado.
    }
}