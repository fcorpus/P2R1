using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2R1
{
    public interface Lists<G>
    {
        void addAtTail(G data);
        void addAtFront(G data);
        void remove(int index);
        void removeAll();
        void setAt(int index, G data);
        G getAt(int index);
        void removeAllWithValue(G data);
        int getSize();
        Iterator<G> getIterator();
    }
}