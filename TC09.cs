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
	Rotacion de palabras en un string: Al recibir un string, se debe retornar un nuevo string en el que se roten sus palabras.
	Ejemplo:
	"the sky is blue" -> "blue is sky the"
	
	
*/

//Your code starts here
using System;
public class TC09
{
    /// <summary>
    /// Metodo para rotar las palabras de un string
    /// </summary>
    /// <param name="str"></param>
    /// <returns>strnuevo</returns>
    public string RotarString(string str)
    {
        String strnuevo = null;
        string[] parts = str.Split(' ');//Separo el string en palabras
        for (int i = parts.Length - 1; i >= 0; i--)//Recorro el arreglo.
        {
            strnuevo = strnuevo + parts[i] + " ";
        }
        return strnuevo;//Retorno la el string invertido.
    }
}