using System;
/// <summary>Queue class</summary>
/// <typeparam name="T">Type of the queue</typeparam>


    class Queue<T>
    {
           public Node head { get; set; }
            public Node tail { get; set; }
            int count;

            public class Node
            {
                public T value { get; set; }
                public Node next { get; set; }

                public Node(T value)
                {
                    this.value = value;
                }
            }

            public void Enqueue(T value)
            {
                Node node = new Node(value);

                if (head == null)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                }
                count++;
            }

            public int Count()
            {
                return count;
            }

            public Type CheckType()
            {
                return typeof(T);
            }

            public T Dequeue()
            {
                if (head == null)
                {
                    Console.WriteLine("Queue is empty");
                    return default(T);
                }
                T value = head.value;
                head = head.next;
                count--;
                return value;
            }
    }
