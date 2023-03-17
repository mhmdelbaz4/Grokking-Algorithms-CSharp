namespace BinarySearch
{
    public class program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 7, 9 };

            int position_5 = Algorithms.BinarySearch(arr, 5);
            Console.WriteLine($"index of 5 in arr = {position_5}"); //2

            int position_1 = Algorithms.BinarySearch(arr, 1);
            Console.WriteLine($"index of 1 in arr = {position_1}"); //0

            int position_10 = Algorithms.BinarySearch(arr, 10);
            Console.WriteLine($"index of 1 in arr = {position_10}"); //-1

        }
    }

    static class Algorithms
    {
        //-1 represents not found in the array
        public static int BinarySearch(int[] seuence, int item)
        {
            int low = 0;
            int high = seuence.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = seuence[mid];

                if (guess == item)
                    return mid;
                else if (guess > item)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;
        }
    }
}