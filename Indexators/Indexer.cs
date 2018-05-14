using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexators
{
    class Indexer
    {

       public int[] arr = new int[5] { 1, 2, 3, 4, 5 };

        public int this[int ind]
        {

            get
            {
                return arr[ind];
            }
            set
            {
                arr[ind] = (int)Math.Pow(value, 2);
            }
        }

    }
}
