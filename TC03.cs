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
	Tarea Corta 3
	Estudiante: Daniel Araya Araya
	
	Enunciado:
	Cree una funcion que identifique si un elemento existe en una lista, debe retornar la cantidad de veces que el elemento aparece en la lista, retornara 0 si no aparece.
*/

//Your code starts here
using System.Collections.Generic;//Uso la libreria para poder crear una lista.
public class TC03
{
    /// <summary>
    /// Metodo para poder identificar un numero.
    /// </summary>
    /// <param name="numeros"></param>
    /// <param name="num"></param>
    /// <returns>contador</returns>
    public int IdentificarNum(List<int> numeros, int num)
    {
        int contador=0;
        for (int i = 0; i < numeros.Count; i++)//Recorro la lista
        {
            if (numeros[i] == num)//Pregunto que si num existe en la lista. 
            {
                contador++;
            }
        }
        return contador;//Retorno la cantidad de veces que se encontro.
    }
}