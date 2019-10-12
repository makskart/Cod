using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int arrSize = 15;
        static int arrCitySize = 6;
        static void Main(string[] args)
        {
            int[] arr = new int[arrSize];
            Console.WriteLine("1. Добавить элемент\n2. Удалить\n3. Вывести\n4. Задание по варианту\n5. Удалить 1-й чётный элемент\n6. Удаление длинной строки");
            Random rand = new Random();
            int w = 0;
            do
            {
                int action = Convert.ToInt32(Console.ReadLine());
                for (int k = 0; k < arrSize; k++)
                    arr[k] = rand.Next(20);
                switch (action)
                {
                    case 1:
                        {
                            // AddElement()
                            for (int k = 0; k < arrSize; k++) // ShowArr();
                                Console.WriteLine("{0}: {1}", k, arr[k]);
                            Console.WriteLine("");
                            Console.WriteLine("Добавить элемент к массиву: ");
                            int newNumb = Convert.ToInt32(Console.ReadLine());
                            int kk = arr.Length;
                            int[] arr2 = new int[++kk];
                            for (int k = 0; k < arrSize; k++)
                                arr2[k] = arr[k];
                            arr2[--kk] = newNumb;
                            Console.WriteLine("Элемент {0} добавлен к массиву: ", arr2[kk]);
                            for (int k = 0; k < 16; k++)
                                Console.WriteLine("{0}: {1}", k, arr2[k]);
                        }
                        break;
                    case 2:
                        {
                            // DeleteElement();
                            Console.Write("Укажите номер индекса элемента массива, который нужно удалить[0-14]: ");
                            var indArr = Convert.ToInt32(Console.ReadLine());
                            if (indArr > 14 || indArr < 1)
                            {
                                Console.WriteLine("Ошибка, необходимо ввести индекс в диапазоне [0-14]");
                                break;
                            }
                            int[] arr2 = new int[14];
                            int temp = 0;
                            int delInd = 0;
                            for (int k = 0; k < arrSize; k++)
                            {

                                Console.WriteLine("{0}: {1}", k, arr[k]);
                                if (k == indArr)
                                {
                                    delInd = arr[k];
                                    continue;
                                }
                                arr2[temp] = arr[k];
                                temp++;
                            }
                            Console.WriteLine("");
                            for (int k = 0; k < 14; k++)
                                Console.WriteLine("{0}: {1}", k, arr2[k]);
                            Console.WriteLine("Удалён элемент с индексом: " + delInd);
                        }
                        break;
                    case 3:
                        {
                            // ShowArr()
                            Console.WriteLine("  Вывод исходного массива:");
                            for (int k = 0; k < arrSize; k++)
                                Console.Write("  " + arr[k]);
                        }
                        break;

                    case 4:
                        {
                            // Task();
                            for (int k = 0; k < arrSize; k++)
                                Console.WriteLine("{0}: {1}", k, arr[k]);
                            Console.WriteLine("");
                            int arr2size = arr.Length / 2, a2s = 0;
                            int[] arr2 = new int[arr2size];
                            for (int k = 0; k < arrSize; k++)
                            {
                                if (k % 2 == 0 && k != 0)
                                    arr2[a2s++] = arr[k];
                            }
                            Array.Sort(arr2);
                            for (int k = 0; k < arrSize; k++)
                            {
                                if (k % 2 == 0 && k != 0)
                                {
                                    arr2size--;
                                    arr[k] = arr2[arr2size];
                                }
                            }
                            Console.WriteLine("Отсортировано:");
                            for (int k = 0; k < arrSize; k++)
                                Console.WriteLine("{0}: {1}", k, arr[k]);
                        }
                        break;
                    case 5:
                        {
                            string[] arrayCity = new string[6] { "Perm", "Kazan", "Moscow", "Sochi", "Volgograd", "Tagil" };
                            for (int l = 0; l < arrCitySize; l++)
                            {
                                if (l % 2 == 0 && l != 0)
                                {
                                    Console.WriteLine("Удалить \"{0}\"", arrayCity[l]);
                                    do
                                    {
                                        arrayCity[l] = arrayCity[l + 1];
                                        l++;
                                    }
                                    while (l < arrCitySize - 1);
                                    Array.Resize(ref arrayCity, arrCitySize - 1);
                                    break;
                                }
                            }
                            for (int l = 0; l < arrCitySize - 1; l++)
                                Console.WriteLine("  {0}", arrayCity[l]);
                            Console.WriteLine("Массив \"arrayCity\" преобразован из {0} в {1} строчный.", arrCitySize, arrayCity.Length);
                        }
                        break;
                        /* не допилено
                    case 6:
                        {
                            string[] arrayCity = new string[6] { "Perm", "Kazan", "Moscow", "Sochi", "Volgograd", "Tagil" };
                            int max = 0, temp = 0, ll = 0;
                            for (int l = 0; l < arrCitySize; l++)
                            {
                                max = arrayCity[l].Length;
                                if (max > temp)
                                {
                                    temp = max;
                                    ll = l;
                                }
                            }
                            Console.WriteLine("Longest string : " + arrayCity[ll]);
                        }
                        break;
                        */
                    default:
                        Console.WriteLine("Ошибка! Необходимо ввести число в диапазоне [1-4].");
                        break;
                }
                w++;
            }
            while (w < 10);
        }
        // 3 getter setter
    }
}
