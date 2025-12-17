namespace DpLearning.FibonnaciStyle
{
    // You are climbing a staircase. It takes n steps to reach the top.
    // Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
    internal class ClimbingStairs
    {
        private readonly Dictionary<int, int> memo = [];
        public int ClimbStairs(int n)
        {
            // Base cases 
            if (n == 0) return 1;
            if (n < 0) return 0;

            if (memo.TryGetValue(n, out var value)) return value;

            // Recurrence relation
            memo.TryAdd(n, ClimbStairs(n - 1) + ClimbStairs(n - 2));
            return memo[n];
        }
    }
}
