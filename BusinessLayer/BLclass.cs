using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLclass
    {

        public int divide(string num,string deno)
        {
            int r=0, r1=0;
            bool n = int.TryParse(num.ToString(), out r);
            bool n1 = int.TryParse(deno.ToString(), out r1);
            if (n && n1)
            {


                if (r1!= 0)
                    return r / r1;
                else
                {
                    throw new DivideByZeroException("cannot divide by 0");
                }

            }
            else
            {
                throw new FormatException("Only Numbers");
            }


        }

        


    }
}
