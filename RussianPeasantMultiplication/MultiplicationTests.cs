using Should;

namespace RussianPeasantMultiplication
{
    public class MultiplicationTests
    {
        public void WhenMultiplyTwoNumbers()
        {
            var multiplication = new Multiplication();
            var result = multiplication.Multiply(18, 23);
            const int expected = 414;
            result.ShouldEqual(expected);
        }
    }
}