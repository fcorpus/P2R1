using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2R1.list.linkedlist
{
    public class LinkedListIterator<K> : Iterator<K>
    {
        private Node<K> currentNode;
        public LinkedListIterator(Node<K> head)
        {
            currentNode = head;
        }
        public bool hasNext()
        {
            return currentNode != null;
        }
        public K Next()
        {
            K data = currentNode.data;
            currentNode = currentNode.next;
            return data;
        }
        public Node<K> getCurrentNode()
        {
            return currentNode;
        }
    }
}