namespace demoWithCopilot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = calculatedaysbetween(new DateTime(1992, 08, 21, 9, 35, 45), new DateTime(2025, 2, 12, 9, 35, 45));
            Console.WriteLine(day);
            towerOfHanoi(4, 'A', 'C', 'B');
            nextGreaterElement(new int[] { 2, 1, 2, 4, 3 });
        }
        public static int calculatedaysbetween(DateTime start, DateTime end)
        {
            return (end - start).Days;
        }
        //Tower of Hanoi problem
        public static void towerOfHanoi(int n, char from_rod, char to_rod, char aux_rod)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disk 1 from rod " + from_rod + " to rod " + to_rod);
                return;
            }
            towerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine("Move disk " + n + " from rod " + from_rod + " to rod " + to_rod);
            towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
        }
        // monotone stack
        public static int[] nextGreaterElement(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n];
            Stack<int> stack = new Stack<int>();
            for (int i = n - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() <= nums[i])
                {
                    stack.Pop();
                }
                res[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(nums[i]);
            }
            return res;
        }



    }
}