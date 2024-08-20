using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    /*
    Есть метод, к которому обращается много пользователей
    public Task SomeBusyMethod()
    В один момент времени к методу может обратиться не более 3 пользователей. Опишите метод
    */

    // немного не понял задачу 
    public class BusyMethod
    {

        Thread myThread; 
        static Semaphore sem = new(3, 3);
        private int myCount = 3;

        public BusyMethod(int i)
        {
            myThread = new Thread(SomeBusyMethod);
            myThread.Name = $"Читатель {i}";
            myThread.Start();
        }
        public void SomeBusyMethod()
        {
            myCount ++;
            while (myCount > 0)
            {
                Console.WriteLine($"{myThread.Name} входит");
                sem.WaitOne();
                Thread.Sleep(1000);

                Console.WriteLine($"{myThread.Name} читает");
                sem.Release();
                Thread.Sleep(1000);
                Console.WriteLine($"{myThread.Name} Покидает поток");
                myCount --;
            }
        }
    }
}
