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

            public T Peek()
            {
                if (head == null)
                {
                    Console.WriteLine("Queue is empty");
                    return default(T);
                }
                return head.value;
            }

            public void Print()
            {
                if (head == null)
                {
                    Console.WriteLine("Queue is empty");
                }
                else
                {
                    Node current = head;
                    while (current != null)
                    {
                        Console.WriteLine(current.value);
                        current = current.next;
                    }
                }
            }

            public T Concatenate()
            {
                if (head == null)
                {
                    Console.WriteLine("Queue is empty");
                    return default(T);
                }
                if (CheckType() == typeof(Char))
                {
                    string result = "";
                    Node current = head;
                    while (current != null)
                    {
                        result += current.value;
                        current = current.next;
                    }
                    Console.Write(result);
                }
                
                if(CheckType() == typeof(String))
                {
                    string result = "";
                    Node current = head;
                    while (current != null)
                    {
                        result += current.value;
                        if (current.next != null)
                        {
                            result += " ";
                        }
                        current = current.next;
                    }
                    Console.Write(result);
                }
                else
                {
                    Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
                }
                return default(T);
            }

    }