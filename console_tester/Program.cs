class Program
{

    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine("Solution Testing");
        Console.WriteLine("------------------------");

        Console.WriteLine("Test Case 1:");
        int input1 = 5;
        int input2 = 3;
        int result1 = solution.MyQuestion(input1,input2);
        Console.WriteLine($"Result: {result1}");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
        
    }
    class Solution
    {
        public int MyQuestion(int i1, int i2)
        {
            //implement here
            int result = i1 + i2;
            return result;
        }
    }
}
