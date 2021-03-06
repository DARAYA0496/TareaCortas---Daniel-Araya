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
	Tarea Corta 7
	Estudiante: Daniel Araya Araya
	
	Enunciado:
	Dado un arreglo de longitud N, retornar un arreglo que contenga los K caracteres mas frecuentes.
	Ejemplo:
	[1,2,3,4,3,2,5], 2 -> Queremos los dos caracteres mas frecuentes del arrelgo
	Resultado -> [2,3] 
*/

//Your code starts here
using System;//Uso la libreria para poder utilizar el WriteLine.
using System.Collections.Generic;//Uso la libreria para poder crear una lista
public class TC07
{
    /// <summary>
    /// Metodo para retornar el numero que mas se repite.
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int ObtenerNumeroFrecuente(int[] num)
    {
        int resultado = 0;
        List<int> numeros = new List<int>();
        foreach (int i in num)//Recorro la lista
        {
            if (i != 0)//Pregunto si i es diferente a cero.
            {
                numeros.Add(i);
            }
            
        }
        resultado = numeros.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();//Orderno la lista numeros y obtengo el numeros que mas se repite.
        return resultado;//Retorno el numero que mas se repite.
    }
}