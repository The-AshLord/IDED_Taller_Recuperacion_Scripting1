using System;
using System.Collections.Generic;


namespace TallerRecuperacion1
{
    internal class TestMethod
    {

        internal static int SumOfSubArrs(int[] arr, int size)
        {
            //Como no puedo usar el ToArray me voy a saltar el paso de hacer un backup del array
            //Definimos nuestras variables:
            Stack<int> subArrStack = new Stack<int>();

            int numeroDeSubArrs = 0;
            int sum = 0; //aquí vamos a ir almacenado la suma total de cada sub arreglo
            int contadorSubArr = 0;

            numeroDeSubArrs = arr.Length - size; 


            int[] arrangeSubArr = new int[size];


            while (contadorSubArr <= numeroDeSubArrs)
            {
                
                for (int i = 0; i < size; i++)
                {
                    //Llenamos la pila con el contenido del sub arreglo
                    subArrStack.Push(arr[contadorSubArr+i]);
                    
                }
                
                for (int j = 0; j < size; j++)
                {
                    //llenamos el arreglo que vamos a ordenar manualmente con el contenido de la pila 
                    arrangeSubArr[j] = subArrStack.Pop();

                }

                //Usamos el metódo/técnica de la burbuja para ordenar el sub arreglo:
                int tempVar = 0;
                for (int k = 0; k < size -1; k++)
                {
                    for (int l = 1; l < size; l++)
                    {
                        if (arrangeSubArr[k] > arrangeSubArr[l])
                        {
                            tempVar = arrangeSubArr[k];
                            arrangeSubArr[k] = arrangeSubArr[l];
                            arrangeSubArr[l] = tempVar;
                        }
                    }
                }

                /*
                 * Ahora que ya tenemos el arreglo ordenado de manera ascemdente
                 * podemos sumar el minimo y máximo del sub arreglo y 
                 * añadirlos a la cuenta de la suma total
                 */

                sum = sum + arrangeSubArr[0] + arrangeSubArr[size-1];

                //avisamos que ya terminamos con el sub array para volver a empezar
                contadorSubArr++;
            }

            return sum;
        }
    }
}
