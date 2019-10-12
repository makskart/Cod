using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Console.WriteLine("1. Добавить элемент\n2. Удалить\n3. Вывести\n4. Задание по варианту\n");
            Random rand = new Random();
            int w = 0;
            do
            {
                int action = Convert.ToInt32(Console.ReadLine());
                for (int k = 0; k < 15; k++)
                    arr[k] = rand.Next(20);
                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine("Add the new element of array: ");
                            int kk = arr.Length;
                            int[] arr2 = new int[++kk];
                            for (int k = 0; k < 5; k++)
                                arr2[k] = arr[k];
                            arr2[--kk] = rand.Next(20);
                            Console.WriteLine("Added new number: " + arr2[kk]);
                        }
                        break;
                    case 2:
                        {
                            Console.Write("What element of array need to delete? Write index [0-4]: ");
                            var indArr = Console.ReadLine();
                            int[] arr2 = new int[4];
                            int temp = 0;
                            int delInd = 0;
                            for (int k = 0; k < 5; k++)
                            {

                                Console.WriteLine("{0}: {1}", k, arr[k]);
                                if (k == Convert.ToInt32(indArr))
                                {
                                    delInd = arr[k];
                                    continue;
                                }
                                arr2[temp] = arr[k];
                                temp++;
                            }
                            for (int k = 0; k < 4; k++)
                                Console.WriteLine("{0}: {1}", k, arr2[k]);
                            Console.WriteLine(" Deleted number: " + delInd);
                        }
                        break;
                    case 3:
                        {
                            for (int k = 0; k < 5; k++)
                                Console.WriteLine("{0}: {1}", k, arr[k]);
                        }
                        break;

                    case 4:
                        {
                            for (int k = 0; k < 15; k++)
                                Console.WriteLine("{0}: {1}", k, arr[k]);
                            Console.WriteLine("");
                            int arr2size = arr.Length / 2, a2s = 0;
                            int[] arr2 = new int[arr2size];
                            for (int k = 0; k < 15; k++)
                            {
                                if (k % 2 == 0 && k != 0)
                                arr2[a2s++] = arr[k];                                  
                            }
                            Array.Sort(arr2);
                            for (int k = 0; k < 15; k++)
                            {
                                if (k % 2 == 0 && k != 0)
                                {
                                    arr2size--;
                                    arr[k] = arr2[arr2size];
                                }
                            }
                            for (int k = 0; k < 15; k++)
                                Console.WriteLine("{0}: {1}", k, arr[k]); 


                            /*for (int sk = 0; sk < 15; sk++)
                            {
                                for (int k = 0; k < 15; k++)
                                    if (k % 2 == 0 && k != 0)
                                        if (temp < arr[k] && arr[k] < tempt)
                                        {
                                            temp = arr[k];
                                            arr2[a2s++] = temp;
                                        }
                                //if (sk % 2 == 0 && sk != 0)
                                     
                                tempt = temp;
                                temp = 0;
                            }
                            foreach(int k in arr2)
                            {
                                arr[k+2] = arr2[k];
                            }
                            for (int k = 0; k < 7; k++)
                                Console.WriteLine("{0}: {1}", k, arr2[k]);*/
                        }
                        break;
                    default:
                        Console.WriteLine("Error. Write number [1-4]");
                        break;
                }
                w++;
                //Console.ReadLine();
                // test
            }
            while (w < 10);
        }
        /*
private static void Show()
{
   int[] arr;
   for (int k = 0; k < 10; k++)
   {
       Console.WriteLine("{0}: {1}", k, arr[k]);
   }
}
*/
    }
}
