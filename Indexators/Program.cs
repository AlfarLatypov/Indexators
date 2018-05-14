/*Тема: Индексаторы и свойства.
1.	Создать индексатор для одномерного массива который при установке значения будет возводить в квадрат передаваемое значение переменной 
и устанавливать его для указанного индекса. При получении элемента массива по индексу будет возвращаться его текущее значение.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexators
{
    class Program
    {
        static void Main(string[] args)
        {

            Indexer indexer = new Indexer();

            for (int i = 0; i < indexer.arr.Length; i++)
            {
                Console.WriteLine($"\tIndex {i} Value {indexer.arr[i]}");
            }

            Console.WriteLine("\n");

            indexer[0] = 6;
            indexer[1] = 7;
            indexer[2] = 8;
            indexer[3] = 9;
            indexer[4] = 10;


            for (int i = 0; i < indexer.arr.Length; i++)
            {
                Console.WriteLine($"\tIndex {i} Value {indexer.arr[i]}");
            }


        }
    }
}
