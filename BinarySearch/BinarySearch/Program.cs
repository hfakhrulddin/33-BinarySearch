using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class BinarySearch<T> where T : class, IComparable<T>
        {
            public static bool Search(T[] input, T target)
            {
                // null's cannot exist
                if (target == null)
                    return false;

                // define the search range
                int low = 0;
                int high = input.Length - 1;

                // divide and conquer the list now
                while (low <= high)
                {
                    // find the mid point
                    int mid = (low + high) / 2;

                    // compare the mid element with target
                    int compareResult = target.CompareTo(input[mid]);

                    if (compareResult < 0)
                    {
                        // discard right and recompare in left
                        high = mid - 1;
                    }
                    else if (compareResult > 0)
                    {
                        // value is more than mid
                        // discard left and recompare in right
                        low = mid + 1;
                    }
                    else
                    {
                        // we found our guy
                        return true;
                    }
                }

                // element not found
                return false;
            }
        }
    }
}
