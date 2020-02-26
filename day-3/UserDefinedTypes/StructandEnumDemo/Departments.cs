using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructandEnumDemo
{
    //byte,sbyte,short,ushort,int,uint,long,ulong <-- only supported
    enum Departments : long
    {
        HR = 100,
        TRNG,
        NotAllocated
    }
    enum Operations
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}
