using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class CustomException:Exception
    {
        public CustomException(string s):base(s)
        {

        }
    }


   public  class BLage
    {
       public string age(DateTime dob)
        {

            DateTime d = DateTime.Now;
            TimeSpan t = d.Subtract(dob);
            int age = (int)t.TotalDays / 365;

            if(age<18)
            {
                throw new CustomException("Age should be greater than 18");
            }
            else if(age>60)
            {
                throw new CustomException("Age should be less than 60");
            }
            else
            {
                return age.ToString();
            }


        }




    }
}
