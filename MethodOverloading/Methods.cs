using System;
namespace MethodOverloading
{
    public class Methods
    {
        public Methods()
        {
        }

        public static int Add(int x, int y)
        {

            return x + y;
        }

        public static double Add(double x, double y)
        {

            return x + y;
        }
        public static string Add(int x, int y, bool f)
        {
            int sum = x + y;

            if (f == true && sum > 1)
            {


                return sum + " dollars";
            }else if(f == true && sum == 0)
            {

                return sum + " dollars";
            }
            else if (f == true && sum == 1)
            {

                return sum + " dollar";
            }

            else
            {
                return "false";
            }

        }




    }
}

