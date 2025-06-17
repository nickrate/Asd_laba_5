using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asd_laba_5
{
    internal class BookStack
    {
        private Stack<Book> stack = new Stack<Book>();

        public void Push(Book book)
        {
            stack.Push(book);
            Console.WriteLine("Книгу додано до стеку.");
        }

        public void Pop()
        {
            if (stack.Count > 0)
            {
                Book removed = stack.Pop();
                Console.WriteLine($"Видалено книгу: {removed.Title} зі сторінками: {removed.Pages}");
            }
            else
                Console.WriteLine("Стек порожній.");
        }

        public void Print()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Стек порожній.");
                return;
            }
            Console.WriteLine("Книги у стеці:");
            foreach (var book in stack)
                Console.WriteLine($"Назва: {book.Title}, Сторінок: {book.Pages}");
        }

        public int Count()
        {
            return stack.Count;
        }
    }
}
