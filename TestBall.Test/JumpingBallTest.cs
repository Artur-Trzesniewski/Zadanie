using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBall.Test
{
   [TestClass]
   public class JumpingBallTest
   {
      [TestMethod]
      public void HowManyTest()
      {
         JumpingBall jumpingBall = new JumpingBall();
         Assert.AreEqual(3, jumpingBall.HowMany(3, 0.66, 1.5));
      }
   }
}
