using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_071_Kelompok7
{
    class Node
    {
        public string data;
        public Node next;
    }

    class QueueLinkedList
    {
        Node Affan;
        Node Ramadhan;

        public QueueLinkedList()
        {
            Affan = null;
            Ramadhan = null;
        }

        public void Insert()
        {
            string value;
            Console.Write("\nEnter the value you want to insert");
            value = Console.ReadLine();
            Node newnode = new Node();
            newnode.data = value;
            if (Affan == null)
            {
                Affan = newnode;
                Ramadhan = newnode;
                return;
            }
            else
            {
                Affan.next = newnode;
                Ramadhan.next = newnode;
            }
        }
        public void Delete()
        {
            if (Affan == null)
            {
                Console.WriteLine("Queue Is Empty");
                return;
            }
            Affan = Affan.next;
            if (Affan == null)
                Ramadhan = null;

        }
        public void Display()
        {
            if (Affan == null)
            {
                Console.WriteLine("Queue is Empty or Filled !!");
                return;
            }
            Node Display;
            for (Display = Affan; Display != null; Display = Display.next) ;
                Console.WriteLine(Display.data);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            {
                QueueLinkedList q = new QueueLinkedList();
                char ch;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. Implement Insert Operation");
                        Console.WriteLine("2. Implement Delete Operation");
                        Console.WriteLine("3. Display Values");
                        Console.WriteLine("4. Exit");
                        Console.WriteLine("\nEnter Your Choice (1-4): ");
                        ch = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        switch (ch)
                        {
                            case '1':
                                {
                                    q.Insert();
                                }
                                break;
                            case '2':
                                {
                                    q.Delete();
                                }
                                break;
                            case '3':
                                {
                                    q.Display();
                                }
                                break;
                            case '4':
                                return;
                            default:
                                {
                                    Console.WriteLine("Invalid Option!!");
                                }
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Check for the values Entered. ");
                    }
                }
            }
        }
    }
}