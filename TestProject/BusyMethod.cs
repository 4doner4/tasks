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
    class BusyMethod
    {
        private int connectCount = 0;
        public Task SomeBusyMethod()
        {

            connectCount++;
            if (connectCount > 2)
            {
                return new Task(() => {
                    Console.WriteLine("3 connect");
                    });
            }
            Task task = new (() => {
            });
            task.Start();
            connectCount --;
            return task;
        }
    }
}
