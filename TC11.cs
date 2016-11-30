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
	Tarea Corta 11
	Estudiante: Daniel Araya Araya
	
	Enunciado:
	Sub arreglo de suma minima:
	Si se recibe un arreglo con N enteros positivos, y se recibe un numero K, retornar el subarreglo mas corto de numeros cuya sumatoria es mayor o igual al numero K.
	Ejemplo
	[2,3,1,2,4,3], 7 -> [4,3] tiene el largo minimo de numeros que sumados son iguales o mayores a 7.
*/

//Your code starts here
public class TC11
{
    /// <summary>
    /// Metodo para Obtener el SubArreglo mas corto de la suma sea mayor o igual a num.
    /// </summary>
    /// <param name="numeros"></param>
    /// <param name="num"></param>
    /// <returns>SubArreglo</returns>
    public int[] SubArreglo(int[] numeros, int num)
    {
        int[] SubArreglo;
        for (int i = 0; i < numeros.Length; i++)//Recorro el arreglo
        {
            for (int j = 0; j < numeros.Length; j++)//Recorro el arreglo
            {
                if ((numeros[i] + numeros[j]) >= num)//Pregunto si la suma es mayor o igual a num.
                {
                    SubArreglo[0] = numeros[i];
                    SubArreglo[1] = numeros[j];
                }
            }
        }
        return SubArreglo;//Retorno el SubArreglo. 
    }
}