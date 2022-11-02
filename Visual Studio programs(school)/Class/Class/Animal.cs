using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public abstract class Animal
    {
        public abstract string GetName();
        abstract public int Speed { get; }
    }
}