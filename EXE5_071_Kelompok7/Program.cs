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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
