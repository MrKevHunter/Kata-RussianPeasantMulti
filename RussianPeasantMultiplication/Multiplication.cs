using System.Collections.Generic;
using System.Linq;

namespace RussianPeasantMultiplication
{
    public class Multiplication
    {
        public int Multiply(int lhs, int rhs)
        {
            var lhsList = GetListOfNumbersFromLhs(lhs);
            var enumerable = lhsList as IList<int> ?? lhsList.ToList();
            var rhsList = GetListOfNumbersFromRhs(rhs, enumerable.Count());
            var mergedList = MergeLists(enumerable, rhsList);
            var oddRows = GetOddRows(mergedList);
            return GetTotal(oddRows);
        }

        private int GetTotal(IEnumerable<IntegerPair> input)
        {
            return input.Sum(numbers => numbers.rhs);
        }

        private IEnumerable<IntegerPair> GetOddRows(IEnumerable<IntegerPair> input)
        {
            return from item in input
                where IsNotEven(item)
                select item;
        }

        private bool IsNotEven(IntegerPair item)
        {
            return item.lhs%2 != 0;
        }

        private IEnumerable<IntegerPair> MergeLists(IEnumerable<int> lhs, IEnumerable<int> rhs)
        {
            for (var i = 0; i < lhs.Count(); i++)
            {
                yield return new IntegerPair {lhs = lhs.ElementAt(i), rhs = rhs.ElementAt(i)};
            }
        }

        private IEnumerable<int> GetListOfNumbersFromRhs(int input, int numberOfItemsToDouble)
        {
            yield return input;
            for (var i = 0; i < numberOfItemsToDouble; i++)
            {
                input *= 2;
                yield return input;
            }
        }

        private IEnumerable<int> GetListOfNumbersFromLhs(int input)
        {
            yield return input;
            while (input != 1)
            {
                input = (input/2);
                yield return input;
            }
        }
    }
}