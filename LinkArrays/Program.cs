namespace LinkArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [5, 3, 8, 1, 9, 2];

            int min = arr.Min();
            int max = arr.Max();
            int sum = arr.Sum();
            double avg = arr.Average();
            int count = arr.Count();
            int countGT4 = arr.Count(x => x > 4);

            var filtered = arr.Where(x => x > 4).ToArray();     //filtering
            var doubled = arr.Select(x => x * 2).ToArray();     //Map
            var sorted = arr.OrderBy(x => x).ToArray();         //Sorting
            var sortedDesc = arr.OrderByDescending(x => x).ToArray();   //Sorting in descending
            bool any = arr.Any(x => x > 4);     //Check if any element is greater than 4
            bool all = arr.All(x => x > 0);     //Checj if all elements are greater than 0
            int first = arr.First(x => x > 4);  //Get the first elemnet greater than 4
        }
    }
}
