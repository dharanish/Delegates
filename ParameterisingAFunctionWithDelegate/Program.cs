using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterisingAFunctionWithDelegate
{
    class Program
    {
        delegate bool Condition(int number);
        static void Main(string[] args)
        {
            Program p = new Program();
            var numbers= new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var resultNumbers = p.GetAllnumbersBasedOnACondtion(numbers, number => number < 5);

            foreach (var number in resultNumbers)
            {
                Console.WriteLine(number);
            }
        }

        //IEnumerable<int> GetAllnumbersLessThanFive(IEnumerable<int> numbers)
        //{
        //    foreach (int number in numbers)
        //    {
        //        if (number < 5)
        //        {
        //            yield return number;
        //        }
        //    }
        //}

        //IEnumerable<int> GetAllnumbersLessThanTen(IEnumerable<int> numbers)
        //{
        //    foreach (int number in numbers)
        //    {
        //        if (number < 10)
        //        {
        //            yield return number;
        //        }
        //    }
        //}

        IEnumerable<int> GetAllnumbersBasedOnACondtion(IEnumerable<int> numbers, Condition condition)
        {
            foreach (int number in numbers)
            {
                if (condition(number))
                {
                    yield return number;
                }
            }
        }
    }
}
