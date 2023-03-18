using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2R1.list.arraylist
{
    public class ArrayListIterator<H> : Iterator<H>
    {
        private readonly ArrayList<H> arrayList;
        private int currentIndex;
        public ArrayListIterator(ArrayList<H> arrayList)
        {
            this.arrayList = arrayList;
            currentIndex = 0;
        }
        public bool hasNext()
        {
            return currentIndex < arrayList.getSize();
        }
        public H Next()
        {
            H data = arrayList.getAt(currentIndex);
            currentIndex++;
            return data;
        }
    }
}