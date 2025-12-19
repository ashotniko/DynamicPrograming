namespace DpLearning.FibonnaciStyle
{
    //You are given an integer array nums. You want to maximize the number of points you get by performing the following operation
    //any number of times:
    //Pick any nums[i] and delete it to earn nums[i] points.Afterwards, you must delete every element e
    //qual to nums[i] - 1 and every element equal to nums[i] + 1.
    //Return the maximum number of points you can earn by applying the above operation some number of times.
    internal class DeleteAndEarn
    {
        public static int DelAndEarn(int[] nums)
        {
            var max = GetMax(nums);
            var values = CreateDpValues(nums, max);

            var take = 0;
            var skip = 0;

            for (var i = 0; i <= max; i++)
            {
                var takei = skip + values[i];
                var skipi = Math.Max(skip, take);
                take = takei;
                skip = skipi;
            }

            return Math.Max(take, skip);
        }

        private static int GetMax(int[] nums)
        {
            var max = 0;
            foreach (var num in nums)
            {
                max = Math.Max(max, num);
            }
            return max;
        }

        private static int[] CreateDpValues(int[] nums, int length)
        {
            var values = new int[length + 1];

            foreach (var num in nums)
            {
                values[num] += num;
            }

            return values;
        }
    }
}
