namespace DpLearning.FibonnaciStyle
{
    //You are given an integer array cost where cost[i] is the cost of ith step on a staircase.Once you pay the cost, you can either climb one or two steps.
    //You can either start from the step with index 0, or the step with index 1.
    //Return the minimum cost to reach the top of the floor.
    internal class MinCostClimbingStairs
    {
        public int MinimalCostClimbingStairs(int[] cost)
        {
            var costLenght = cost.Length;
            var dpHelper = new int[costLenght + 1];

            dpHelper[0] = dpHelper[1] = 0;

            for (var i = 2; i < costLenght; i++)
            {
                dpHelper[i] = Math.Min(
                    dpHelper[i - 1] + cost[i - 1],
                    dpHelper[i - 2] + cost[i - 2]
                );
            }
            return dpHelper[costLenght];
        }
    }
}
