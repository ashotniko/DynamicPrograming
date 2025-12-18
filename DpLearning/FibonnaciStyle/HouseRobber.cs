namespace DpLearning.FibonnaciStyle
{
    //You are a professional robber planning to rob houses along a street.
    //Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that 
    //adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were
    //broken into on the same night.
    //Given an integer array nums representing the amount of money of each house, return the maximum amount of money you
    //can rob tonight without alerting the police.
    internal class HouseRobber
    {
        public int Rob(int[] nums)
        {
            var numsLength = nums.Length;

            if (numsLength == 1)
            {
                return nums[0];
            }

            var dpHelper = new int[numsLength];

            dpHelper[0] = nums[0];
            dpHelper[1] = Math.Max(nums[0], nums[1]);

            for (var i = 2; i < numsLength; i++)
            {
                dpHelper[i] = Math.Max(
                    dpHelper[i - 1],
                    dpHelper[i - 2] + nums[i]
                );
            }

            return dpHelper[numsLength - 1];
        }
    }
}
