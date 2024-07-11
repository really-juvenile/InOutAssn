using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutAssn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 25, n2 = 15;
            if(Addition(in n1, in n2, out int add))
            // in used to state that parameter passed cannot be modified by the method
            //out is used for parameter passed must be modified by the method
            //also in is for input and out for output;
            {
                Console.WriteLine("Addition is greater than 50 "+add);
            }
            else
            {
                Console.WriteLine("Addition is less than 50 " +add);
            }

        }

        static bool Addition(in int n1, in int n2, out int sum)
        {
            sum = n1+n2;
            if (sum > 50)
                return true;
            return false;
        }
    }
}
