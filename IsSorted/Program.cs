namespace IsSorted
{
    internal class Program
    {
        public static void Main()
        {
            int[] arr = { 12, 63, 8, 6 };

            bool isSorted = arr.IsSorted();
            Console.WriteLine("Sorted " + isSorted);

            int[] arr2 = { 1, 2, 3, 6, 19 };
            Console.WriteLine(arr2.IsSorted());

            string[] names = { "Anders", "Carl", "Dennis" };
            Console.WriteLine("names " + names.IsSorted());

            string[] names2 = { "Anders", "Carl", "Dennis", "Abraham" };
            Console.WriteLine("names " + names2.IsSorted());

            string[] namesReverse = { "Carl", "Benny", "Anders" };
            Console.WriteLine("names reverse " + namesReverse.IsSorted(true));

            List<int> list1 = new() { 4, 65, 6, 2 };
            Console.WriteLine("list1 " + list1.IsSorted());
            Console.WriteLine("list1 " + list1.IsSorted(true));
        }
    }
}