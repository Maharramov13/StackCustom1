using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StackCustom
{
    //internal class Stack<T>
    //{
        //private T[] items;
        //private int top;

        //public Stack(int size)
        //{
        //    items = new T[size];
        //    top = -1;
        //}

        //public void Push(T item)
        //{
        //    if (top == items.Length - 1)
        //    {
        //        Console.WriteLine("Stack overflow");
        //        return;
        //    }
        //    items[++top] = item;
        //}

        //public T Pop()
        //{
        //    if (top == -1)
        //    {
        //        Console.WriteLine("Stack is empty");
        //        return default(T);
        //    }
        //    return items[top--];
        //}

        //public T Peek()
        //{
        //    if (top == -1)
        //    {
        //        Console.WriteLine("Stack is empty");
        //        return default(T);
        //    }
        //    return items[top];
        //}

        //public bool IsEmpty()
        //{
        //    return top == -1;
        //}


      

class Stack<T>
    {
        private T[] items;
        private int top;
        private int count;
        private int capacity;
       
        //public Stack(int capacity)
        //{
        //    this.capacity = capacity;
        //}

        public  Stack(int capacity)
        {
            if (Capacity <= 0)
            {
                throw new ArgumentException("Initial capacity have to great than zero.");
            }

            items = new T[capacity];
            top = -1;
            count = 0;
            
        }

        public int Count { get { return count; } }

        public int Capacity { get { return capacity; } }

        public void Push(T item)
        {
            if (count == capacity)
            {

                capacity *= 2;
                Array.Resize(ref items, capacity);
            }
            items[top++] = item;
            count++;
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            T poppedItem = items[top--];
            count--;
            return poppedItem;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return items[top];
        }

        //private void IncreaseCapacity()
        //{
        //    T[] newArray = new T[Capacity * 2];
        //    Array.Copy(items, newArray, Count);
        //    items = newArray;
        //}
        //private void Resize(int newCapacity)
        //{
        //    capacity = newCapacity;
        //    T[] newArray = new T[newCapacity];
        //    Array.Copy(items, 0, newArray, 0, count);
        //    items = newArray;
        //}
        //public void IncreaseCapacity()
        //{
        //    Array.Resize(ref items, Capacity * 2);
        //}
    }
}

