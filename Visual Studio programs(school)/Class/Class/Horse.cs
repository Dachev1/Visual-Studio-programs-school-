using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Horse : Animal
    {
        public override int Speed
        {
            get
            {
                return 60;
            }
        }
        public override string GetName()
        {
            return "horse";
        }
    }
}