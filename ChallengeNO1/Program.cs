namespace ChallengeNO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge #1 */
            Console.WriteLine("Challenge #1"); // -> display title
            int[] nums = {1,2,3};
            Console.WriteLine(summation(nums));
        }

        static int summation(int[] nums)
        {
            int sum = 0;
            for(int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}