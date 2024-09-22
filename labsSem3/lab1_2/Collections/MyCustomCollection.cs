using lab3.Exceptions;
using lab3.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;

namespace lab3.Collections
{
    public class MyCustomCollection<T> : ICustomCollection<T>, IEnumerable<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;
            public Node(T data)
            {
                Data = data;
            }
        }
        private Node current;
        private Node head;
        private int count;

        public T this[int index]
        {
            get
            {
                if (index < count || index >= count)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
                return At(index).Data;
            }
            set
            {
                if (index < count || index >= count)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
                At(index).Data = value;
            }
        }

        public void Reset() => current = head;

        public void Next()
        {
            if (current != null)
            {
                current=current.Next;
            }
        }

        public T Current()
        {
            if (current != null)
            {
                return current.Data;
            }
            return default;
        }

        public int Count => count;

        public void Add(T item) 
        {
            Node newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
                current = head;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp=temp.Next;
                }
                temp.Next= newNode;
            }
            count++;
        }

        public void Remove(T item)
        {
            Node previous = null;
            Node temp = head;
            while(temp.Next!=null && !temp.Data.Equals(item))
            {
                previous = temp;
                temp=temp.Next;
            }
            if (temp == null)
            {
                throw new MyException();
            }
            if (temp != null)
            {
                if (previous == null)
                {
                    head=temp.Next;
                }
                else
                {
                    previous.Next = temp.Next;
                }
                count--;
            }
        }

        public T RemoveCurrent()
        {
            if (current != null)
            {
                T value = current.Data;
                Remove(value);
                return value;
            }
            return default;
        }

        private Node At(int index)
        {
            if(index<count ||index >= Count)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }
            Node temp = head;
            for(int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp;
        }


        //реализация IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            Node temp = head;
            while (temp != null)
            {
                yield return temp.Data;
                temp = temp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
