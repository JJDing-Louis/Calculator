using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class inputObj
    {


        public string keyinNum(string x,string y)
        {
            if (x.Equals("0"))
            {
                return y;               
            }
            else 
            { x += y;
                return x;
            }
                       
        }

        public string keyinOp(string x, string y)
        {
            if (x.Equals("0") | x.EndsWith(y))
            {
                return x;
            }
            else
            {
                x += y;
                return x;
            }
        }

        public int counting(string Lblprocess,int total)
        {
            String[] nums = Lblprocess.Split();
            foreach(string num in nums)
            {
                if (num.Equals("+"))
                {
                    Console.WriteLine(num);
                }
                else if(num.Equals("-")){

                    Console.WriteLine(num);
                }
                else if (num.Equals("*"))
                {
                    Console.WriteLine(num);
                }
                else if (num.Equals("/"))
                {
                    Console.WriteLine(num);
                }
                else
                {
                    int i = int.Parse(num);
                    Console.WriteLine(i);
                }

            }

            return total;
        }
    }
}
