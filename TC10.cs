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
	Tarea Corta 10
	Estudiante: Daniel Araya Araya
	
	Enunciado:
	Inversion de un string: Al recibir un string S, retornar un string cuyas palabras estan invertidas, sin invertir el orden de las palabras.
	"The Sky is Blue" -> "ehT ykS si eulB"
*/

//Your code starts here
using System;
public class TC10
{
    /// <summary>
    /// Metodo para invertir la Palabras.
    /// </summary>
    /// <param name="str"></param>
    /// <returns>strnuevo</returns>
    public string InvertirPalabras(string str)
    {
        String strnuevo = null;
        string[] parts = str.Split(' ');//Separo el string en palabras
        str = null;
        for (int i = 0; i < parts.Length; i++)//Recorro el arreglo.
        {
            strnuevo = parts[i];
            for (int j = strnuevo.Length - 1; j >= 0; j--)//Recorro el strnuevo al reves para asi invertir la palabra.
            {
                str = str + strnuevo[j];
                parts[i] = str;
            }
            str = null;
        }
        strnuevo = null;
        for (int i = 0; i < parts.Length; i++)//Recorro el arreglo
        {
            strnuevo = strnuevo + parts[i] + " ";
        }
        return strnuevo;//Retorno el nuevo string
    }
}