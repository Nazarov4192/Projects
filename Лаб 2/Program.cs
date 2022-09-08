using System;

namespace Лаб_2
{
    class Program
    {  
        static void Main(string[] args)
        {
            start();
        }
        static int globalcount = 0;
        //Шейкерный алгоритм сортировки
        static void shakesort(int[] a)
        {           
            bool rab = true;
            int vrem;
            while (rab)
            {
                rab = false;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[ i] > a[ i + 1])
                    {
                        vrem = a[ i];
                        a[ i] = a[ i + 1];
                        a[ i + 1] = vrem;
                        rab = true;                        
                    }
                    globalcount++;
                }
                for (int i = a.Length - 1; i > 0 ; i--)
                {
                    if (a[i] < a[i - 1])
                    {
                        vrem = a[i];
                        a[i] = a[i - 1];
                        a[i - 1] = vrem;
                        rab = true;                        
                    }
                    globalcount++;
                } 
            }
        }
        static int[] b1;
        static void start()
        {
            //цикл создания массивов разной размерности
            for (int i = 2000; i <= 10000; i += 2000)
            {
                //объявление длинны массива
                b1 = new int[i];
                Random rnd = new Random();
                //заполнение массива
                for (int z = 0; z < b1.Length; z++)
                {      
                    b1[z] = rnd.Next(-100000, 100001);
                }
                //старт таймер
                var startTime = System.Diagnostics.Stopwatch.StartNew();
                //сортировка массива
                shakesort(b1);
                //стоп таймер
                startTime.Stop();
                //вывод нужной информации
                Console.WriteLine();
                Console.WriteLine("Размер массива = {0}", b1.Length);
                Console.WriteLine("Время выполнения операции {0} мс", startTime.Elapsed.TotalMilliseconds);
                Console.WriteLine("Количество иттераций = {0}", globalcount);
                globalcount = 0;
            }
        }
 
    }
}
