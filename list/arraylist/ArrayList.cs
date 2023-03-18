using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2R1.list.arraylist
{
    public class ArrayList<T> : Lists<T>
    {
        private static readonly int INITIAL_SIZE = 2;
        private T[] array;
        private int size;
        //private ArrayList<T> first;
        public ArrayList()
        {
            array = new T[INITIAL_SIZE];
        }
        public void addAtTail(T data)
        {
            if (size == array.Length)
            {
                increaseSize();
            }
            array[size] = data;
            size++;
        }
        public void addAtFront(T data)
        {
            if (size == array.Length)
            {
                increaseSize();
            }
            for (int i = size - 1; i >= 0; i--)
            {
                array[i + 1] = array[i];
            }
            array[0] = data;
            size++;
        }
        public void remove(int index)
        {
            if (index < size)
            {
                array[index] = array[index + 1];
                array[index + 1] = default(T);
                size--;
            }
            else
            {
                if (index == size)
                {
                    array[index] = default(T);
                    size--;
                }
            }
        }
        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = default(T);
            }
            size = 0;
        }
        public void setAt(int index, T data)
        {
            array[index] = data;
        }
        public T getAt(int index)
        {
            if (index < 0 || index >= size)
            {
                return default(T);
            }
            return (T)array[index];
        }
        public void removeAllWithValue(T data)
        {
            int auxiliarySize = size;
            for (int i = 0; i < auxiliarySize; i++)
            {
                if (array[i].Equals(data))
                {
                    array[i] = array[i + 1];
                    size--;
                }
            }
        }

        public int getSize()
        {
            return size;
        }
        private void increaseSize()
        {
            T[] newArray = new T[array.Length * 2];
            Array.Copy(array, 0, newArray, 0, array.Length);
            /*for(int i =0; i<array.length;i++){
               newArray[i]=array[i];
           }*/
            array = newArray;
        }
        public Iterator<T> getIterator() { return new ArrayListIterator<T>(this); }
    }
}