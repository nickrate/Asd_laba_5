using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asd_laba_5
{
    internal class NumberQueue
    {
        private Queue<double> queue = new Queue<double>();

        public void Enqueue(double number)
        {
            queue.Enqueue(number);
            Console.WriteLine("Число додано до черги.");
        }

        public void Dequeue()
        {
            if (queue.Count > 0)
            {
                double removed = queue.Dequeue();
                Console.WriteLine($"Видалено число: {removed}");
            }
            else
                Console.WriteLine("Черга порожня.");
        }

        public void Print()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Черга порожня.");
                return;
            }
            Console.WriteLine("Елементи черги:");
            foreach (var item in queue)
                Console.WriteLine(item);
        }

        public double Min()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Черга порожня.");
                return double.NaN;
            }
            return queue.Min();
        }
    }
}
