using NUnit.Framework;

namespace RussianPeasantMultiplication
{
   [TestFixture]
   public class MultiplicationTests
   {
      [Test]
      public void WhenMultiplyTwoNumbers()
      {
         var multiplication = new Multiplication();
         int result = multiplication.Multiply(18, 23);
         const int expected = 414;
         Assert.That(result,Is.EqualTo(expected));
      }
   }
}