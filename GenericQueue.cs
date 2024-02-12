using System;

namespace Generic_stack
{
    public class GenericQueue<T> where T : class, new()
    {
        private T[] array;
        private int front;
        private int rear;
        private int capacity;

        public GenericQueue(int capacity=5)
        {
            this.capacity = capacity;
            array = new T[capacity];
            front = rear = -1;
        }

        public bool IsFull()
        {
            return (rear + 1) % capacity == front;
        }

        public bool IsEmpty()
        {
            return front == -1;
        }

        public void Enqueue(T data)
        {
            if (IsFull())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Queue is already full.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (IsEmpty())
            {
                front = 0;
            }

            rear = (rear + 1) % capacity;
            array[rear] = data;
        }

        public T? Dequeue()
        {
            if (IsEmpty())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The queue is empty, nothing to dequeue.");
                Console.ForegroundColor = ConsoleColor.White;
                return null;
            }

            T data = array[front];

            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front = (front + 1) % capacity;
            }

            return data;
        }

        public T? FirstElement()
        {
            if (IsEmpty())
            {
                return null;
            }

            return array[front];
        }
    }
}
