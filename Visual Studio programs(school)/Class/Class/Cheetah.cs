using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Cheetah : Animal
    {
        public override int Speed
        {
            get
            {
                return 100;
            }
        }
        public override string GetName()
        {
            return "cheetah";
        }
    }
}