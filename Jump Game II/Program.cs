using System;

namespace Jump_Game_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] nums = new int[] { 2, 3, 1, 1, 4, 3, 1, 1, 4 };
            Console.WriteLine("Jump(nums):" + program.Jump(nums));
        }
        public int Jump(int[] nums)
        {
            int max = 0, cur_max = 0, counter = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {
                max = Math.Max(max, nums[i]+i); //2, 3, 1, 1, 4, 3, 1, 1, 4 
                if (cur_max ==i)
                {
                    counter++;
                    cur_max = max;
                }
            }
            return counter;
        }
    }
}
