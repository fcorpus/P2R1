using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2R1
{
    public interface Iterator<T>
    {
        bool hasNext();
        T Next();
    }
}