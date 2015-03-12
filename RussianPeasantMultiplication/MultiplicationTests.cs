using RussianPeasantMultiplication.Fixie;
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

        [Input(2, 3, 6)]
        [Input(3, 5, 15)]
        [Input(-2, 4, 8)]
        [Input(-4, -12, 48)]
        public void WhenMultiplySomeNumbers(int a,int b, int expectedResult)
        {
            var multiplication = new Multiplication();
            var result = multiplication.Multiply(a, b);
            
            result.ShouldEqual(expectedResult);
        }
    }
}