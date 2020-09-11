using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCalculator
{
    public class Calc
    {
       public int Sum(int a, int b)
       {
            return a + b;
       }

       public int Sub(int a, int b)
       {
           return a - b;
       }

       public int Mul(int a, int b)
       {
           return a * b;
       }

       public int Div(int a, int b)
       {
           if(b < a)
           {
               return b / a;
           }

           return a / b;
       }

       public int Squere(int a)
       {
           return (int)Math.Sqrt(a);
       }

       public int Pow2(int a)
       {
           return (int)Math.Pow(a, 2);
       }
        public int Pow(int a, int b)
       {
           return (int)Math.Pow(a, b);
       }

       public int Mod(int a, int b)
       {
           return a % b;
       }
    }
}
