using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {

            int rok = year;
            string s;
            int cent = year / 100;
            year %= 100;
           


            if (year > 0)
                cent = cent + 1;

            s = cent.ToString();

            if (cent == 11 || cent == 12 || cent == 13)
            {
                s = string.Format(cent + "th century");
                return s;
            }
            else if (cent == 1 || cent % 10 == 1)
            {
                s = string.Format(cent + "st century");
                return s;
            }
            else if (cent == 2 || cent % 10 == 2)
            {
                s = string.Format(cent + "nd century");
                return s;
            }
            else if (cent == 3 || cent % 10 == 3)
            {
                s = string.Format(cent + "rd century");
                return s;
            }
            else
            {
                s = string.Format(cent + "th century");
                return s;
            }
            

           
            

        }
    }
}
