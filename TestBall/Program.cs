using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBall
{
   class Program
   {
      static void Main(string[] args)
      {
         JumpingBall jumpingBall = new JumpingBall();
         Console.WriteLine(jumpingBall.HowMany(3, 0.66, 1.5));
         Console.ReadKey();
      }
   }
}
