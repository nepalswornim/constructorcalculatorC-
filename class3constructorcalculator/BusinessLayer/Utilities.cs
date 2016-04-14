using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Utilities
    {


        public int add(int x, int y)
        {
            int c = x + y;
            return c;
        }


        public int sub(int x, int y)
        {
            int c = x - y;
            return c;
        }

        public int multi(int x, int y)
        {
            int c = x * y;
            return c;
        }

        public int div(int x, int y)
        {
            int c = x / y;
            return c;
        }
        public int div(int x, int y, int z)
        {
            int c = x / y /z;
            return c;
        }


    }
}

