using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class Array
    {

        public int[] Create()
        {
            int Min = 1;
            int Max = 20;

            int[] array = new int[5];

            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(Min, Max);
            }
            return array;
        }

        public void Imprimir(int[] array)
        {
            int tamanho = array.Length;
            for (int i = 0; i < tamanho; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
