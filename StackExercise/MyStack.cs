using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    public class MyStack<T>
    {
        private List<T> Data;
        private int Counter;
        public MyStack()
        {
            Data = new List<T>();
            Counter = 0;
        }
        public void Push(T item)
        {
            Data.Add(item);
            Counter++;
        }
        public T Pop()
        {
            if (Counter != 0)
            {
                T item = Data[Counter - 1];
                Data.RemoveAt(Counter - 1);
                Counter--;
                return item;
            }
            else
            {
                throw new Exception("No Objects left in the stack");
            }
        }
        public void Clear()
        {
            Counter = 0;
            Data.Clear();
        }

        public T Peak()
        {
            if (Counter != 0)
            {
                T item = Data[Counter - 1];
                return item;
            }
            else
            {
                throw new Exception("No Objects in the Stack");
            }
        }

        public void Print()
        {
            if (Data.Count == 0) 
            {
                Console.WriteLine("No Objects in the Stack!");
                return;
            }
            foreach (T item in Data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
