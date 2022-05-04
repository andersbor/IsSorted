namespace IsSorted
{
    /// <summary>
    /// May be useful with unit tests.
    /// NUnit has a similar function https://csharp.hotexamples.com/examples/NUnit.Framework/List/IsSorted/php-list-issorted-method-examples.html
    /// Uses generic extension method with default parameter + constraints on the type parameter, and method overloading
    /// </summary>
    // TODO needs unit testing
    static class Order
    {
        // inspiration https://www.dotnetperls.com/issorted
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
        public static bool IsSorted<T>(this T[] arr, bool desc = false) where T : IComparable<T>
        {
            if (desc) return IsSortedDescending(arr); // TODO looking for smarter implementation
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1].CompareTo(arr[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSortedDescending<T>(this T[] arr) where T : IComparable<T>
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1].CompareTo(arr[i]) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSorted<T>(this IEnumerable<T> data, bool desc = false) where T : IComparable<T>
        {
            T[] arr = data.ToArray();
            return IsSorted(arr, desc);
        }
    }
}
