namespace ConsoleDemo
{
    class DealingWithArrays
    {
        public static int FindSum(int[] arr)
        {
            int total = 0;
            foreach (int item in arr)
            {
                total += item;
            }
            return total;
        }

        public static string ReturnArray(string[] arr) // could use object[] here at the cost of losing type safety
        {
            return string.Join("\n", arr);
        }

        public static string ReturnArray(int[] arr)
        {
            return string.Join("\n", arr);
        }
    }
}