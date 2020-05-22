using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBall
{
   public class JumpingBall
   {
      public int HowMany(double h, double b, double w)
      {
         int n = 1;
         //z którego piłka jest zrzucana (h) , wysokości okna (w) i parametru odbicia (b). 
         if ((h < w) || (b>=1))
         {
            return -1;
         }

         h *= b;

         while (h>w)
         {
            n+=2;
            h *= b;
         }

         return n;
      }
   }
}
