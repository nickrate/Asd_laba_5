using System.Text;

namespace Asd_laba_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            BookStack stack = new BookStack();
            NumberQueue queue = new NumberQueue();

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Додати книгу до стеку");
                Console.WriteLine("2. Видалити книгу зі стеку");
                Console.WriteLine("3. Показати книги в стеці");
                Console.WriteLine("4. Кількість книг у стеці");
                Console.WriteLine("5. Додати число до черги");
                Console.WriteLine("6. Видалити число з черги");
                Console.WriteLine("7. Показати елементи черги");
                Console.WriteLine("8. Знайти мінімальний елемент черги");
                Console.WriteLine("0. Вихід");

                Console.Write("\nВаш вибір: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("Введіть назву книги: ");
                        string name = Console.ReadLine();
                        Console.Write("Введіть кількість сторінок: ");
                        int pages = int.Parse(Console.ReadLine());
                        stack.Push(new Book { Title = name, Pages = pages });
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        stack.Print();
                        break;
                    case "4":
                        Console.WriteLine($"Кількість книг у стеці: {stack.Count()}");
                        break;
                    case "5":
                        Console.Write("Введіть число: ");
                        double value = double.Parse(Console.ReadLine());
                        queue.Enqueue(value);
                        break;
                    case "6":
                        queue.Dequeue();
                        break;
                    case "7":
                        queue.Print();
                        break;
                    case "8":
                        Console.WriteLine($"Мінімальний елемент у черзі: {queue.Min()}");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір.");
                        break;
                }
            }
        }
    }
}