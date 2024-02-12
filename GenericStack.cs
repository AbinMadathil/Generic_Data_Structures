using System;

namespace Generic_stack
{
    public class GenericStack<T> where T : struct
    {
        private T[] array;
        private int top;

        public GenericStack(int capacity = 5)
        {
            array = new T[capacity];
            top = -1;
        }

        public void Push(T data = default)
        {
            if (typeof(T).IsValueType || data.Equals(default))
            {
                if (top < array.Length - 1)
                {
                    top++;
                    array[top] = data;
                }
                else
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Stack is full. Cannot push more elements.");
                    Console.ForegroundColor=ConsoleColor.White;
                }
            }
            else
            {
                throw new NotValueTypeException("The entered data is not a value type; only value types are accepted.");
            }
        }

        public T? Pop()
        {
            if (top >= 0)
            {
                T data = array[top];
                top--;
                return data;
            }

            Console.WriteLine("The stack contains no elements");
            return null;
        }

        public T? Peek()
        {
            return top >= 0 ? array[top] : null;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }

    [Serializable]
    internal class NotValueTypeException : Exception
    {
        public NotValueTypeException(string? message) : base(message)
        {
        }
    }
}
