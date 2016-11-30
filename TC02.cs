/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 2
	Estudiante: Daniel Araya Araya
	
	Enunciado:
	Escriba una funcion que le de vuelta a una lista, debe imprimir primero la lista original, y luego imprimir la lista invertida.
	Preferiblemente, darle vuelta a la lista sin crear una lista nueva.
*/

//Your code starts here
using System;//Uso la libreria para poder utilizar el WriteLine.
using System.Collections.Generic;//Uso la libreria para poder hacer una lista.
public class TC02
{
    /// <summary>
    /// Metodo para invertir una Lista.
    /// </summary>
    /// <param name="numeros"></param>
    public void Invertir(List<int> numeros)
    {
        Console.WriteLine("Lista original");
        for (int i = 0; i < numeros.Count; i++)//Recorro la lista.
        {
            if (i == numeros.Count - 1)//Pregunto si i es igual al tamaño menos 1 para imprimirlo sin coma el ultimo.
            {
                Console.Write(numeros[i]);
            }
            else
            {
                Console.Write(numeros[i] + ", ");
            }

        }
        Console.WriteLine();
        Console.WriteLine("Lista invertida");
        for (int i = numeros.Count - 1; i >= 0; i--)//Recorro la lista.
        {
            if (i == 0)//Pregunto si i es igual a 0 para imprimirlo sin coma el ultimo.
            {
                Console.Write(numeros[i]);
            }
            else
            {
                Console.Write(numeros[i] + ", ");
            }

        }
        Console.WriteLine();
    }
}