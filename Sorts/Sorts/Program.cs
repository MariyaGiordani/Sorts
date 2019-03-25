using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            TiposArray tiposArray = new TiposArray();
            Array array = new Array();
            int[] newArray = array.Create();
            bool pertence = true;
            while (pertence)
            {
                try
                {
                    int opcao;
                    Console.WriteLine(" ===== Programa para ordenação de array ======== ");
                    Console.WriteLine("| 1 - Quick Sort                                |");
                    Console.WriteLine("| 2 - Merge Sort                                |");
                    Console.WriteLine("| 3 - Heap Sort                                 |");
                    Console.WriteLine("| 4 - Shell Sort                                |");
                    Console.WriteLine("| 5 - Selection Sort                            |");
                    Console.WriteLine("| 0 - Sair                                      |");
                    Console.WriteLine(" ===============================================\n");
                    Console.WriteLine("Digite a opção:");
                    opcao = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    switch (opcao)
                    {
                        case 1:
                            array.Imprimir(newArray);
                            tiposArray.QuickSort(newArray);
                            break;
                        case 2:
                            tiposArray.MergeSort(newArray);
                            break;
                        case 3:
                            tiposArray.HeapSort(newArray);
                            break;
                        case 4:
                            tiposArray.ShellSort(newArray);
                            break;
                        case 5:
                            tiposArray.SelectionSort(newArray);
                            break;
                        default:
                            Console.WriteLine("Você está saindo do programa. Muito obrigada :-)");
                            pertence = false;
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nErro na digitação!");
                    Console.WriteLine("\nMensagem: " + ex.Message);
                }
            }
        }
    }
}
