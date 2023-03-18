using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2R1.list.linkedlist
{
    public class LinkedList<T>: Lists<T>
    {
        private Node<T> head = null;
        private Node<T> tail= null;
        private int size = 0;
        public void addAtTail(T data)
        {
            Node<T> node = new Node<T>();
            node.data = data;
            node.previous = tail;
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                node.previous = tail;
            }
            tail = node;
            size++;
        }
        public void addAtFront(T data)
        {
            Node<T> node = new Node<T>();
            node.data = data;
            node.next = head;
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                head.previous = node;
                node.next = head;
            }
            head = node;
            size++;
        }
        public void remove(int index)
        {
            Node<T> currentNode = head;
            for (int currentIndex = 0; currentIndex < index; currentIndex++)
            {
                currentNode = currentNode.next;
            }
            size--;
        }
        public void removeAll()
        {
            Iterator<T> iterator = getIterator();
            while (iterator.hasNext())
            {
                iterator.Next();
                size--;
            }
        }
        public void setAt(int index, T data)
        {
            LinkedListIterator<T> iterator = (LinkedListIterator<T>)getIterator();
            Node<T> currentNode = head;
            int current_index = 0;
            while (iterator.hasNext() && current_index != index)
            {
                //currentNode=
                iterator.Next();
                current_index++;
            }
            currentNode.data = data;
        }
        public T getAt(int index)
        {
            if (index < 0 || index >= size)
            {
                return default(T);
            }
            Node<T> currentNode = head;
            for (int currentIndex = 0; currentIndex < index; currentIndex++)
            {
                currentNode = currentNode.next;
            }
            return currentNode.data;
        }
        public void removeAllWithValue(T data)
        {
            LinkedListIterator<T> iterator = (LinkedListIterator<T>)getIterator();
            Node<T> currentNode = head;
            do
            {
                Node<T> temp = iterator.getCurrentNode();
                if (temp.data.Equals(data))
                {
                    currentNode.previous = currentNode.next;
                }
            } while (iterator.hasNext());
            /*for(Node currentNode = head; currentNode!=null; currentNode=currentNode.next){
                if(currentNode.data==data){
                    currentNode.data=null;
                    currentNode.previous=currentNode.next;
                }
            }*/
        }

        public int getSize()
        {
            return size;
        }
        public Iterator<T> getIterator()
        {
            return new LinkedListIterator<T>(head);
        }
    }
}