using P2R1.list;
using P2R1.list.arraylist;
using P2R1.list.linkedlist;
using System.Collections.Generic;
using LinkedList = P2R1.list.linkedlist;
using ArrayList = P2R1.list.arraylist;
 
namespace P2R1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lists <string> lista1 = new list.linkedlist.LinkedList<string>();
            Lists<string> lista2 = new list.arraylist.ArrayList<string>();
            Console.WriteLine("------------------------------\n LinkedList:\n");
            lista1.addAtTail("hola");
            lista1.addAtTail("Z");
            lista1.addAtTail("V");
            lista1.addAtTail("W");
            lista1.addAtFront("A");
            Console.WriteLine("size: " + lista1.getSize());
            printList(lista1);
            Console.WriteLine("------------------------------\n ArrayList:\n");
            lista2.addAtTail("F");
            lista2.addAtTail("G");
            lista2.addAtTail("H");
            lista2.addAtFront("E");
            Console.WriteLine("size: " + lista2.getSize());
            printList(lista2);
            Console.WriteLine("linkedlist en la posicion 3:" + lista1.getAt(3));
            Console.WriteLine("arraylist en la posicion 2:" + lista2.getAt(2));
            lista1.removeAll();
            lista2.removeAll();
            Console.WriteLine("la linkedlist ha sido borrada por lo que su tamaño es: " + lista1.getSize());
            Console.WriteLine("la arraylist ha sido borrada por lo que su tamaño es: " + lista2.getSize());
        }
        public static void printList(Lists<string> lista)
        {
            Iterator<string> iterator = lista.getIterator();
            while (iterator.hasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
