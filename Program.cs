namespace HomeWork8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HomeWork8 hw = new HomeWork8();

            // Test 1: Valid Parentheses
            string test1 = "()[]{}";
            bool result1 = hw.IsValid(test1);
            Console.WriteLine("Valid Parentheses (\"" + test1 + "\"): " + result1);

            // Test 2: Baseball Game
            string[] ops = { "5", "2", "C", "D", "+" };
            int result2 = hw.CalPoints(ops);
            Console.WriteLine("Baseball Game Points: " + result2);

            // Test 3: Find Pivot Index
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            int result3 = hw.PivotIndex(nums);
            Console.WriteLine("Pivot Index: " + result3);

            // Test 4: RecentCounter
            HomeWork8.RecentCounter rc = new HomeWork8.RecentCounter();
            Console.WriteLine("RecentCounter Pings:");
            Console.WriteLine("Ping(1) => " + rc.Ping(1));
            Console.WriteLine("Ping(100) => " + rc.Ping(100));
            Console.WriteLine("Ping(3001) => " + rc.Ping(3001));
            Console.WriteLine("Ping(3002) => " + rc.Ping(3002));

            // Test 5: Count Students Unable to Eat Lunch
            int[] students = { 1, 1, 0, 0 };
            int[] sandwiches = { 0, 1, 0, 1 };
            int result5 = hw.CountStudents(students, sandwiches);
            Console.WriteLine("Students Unable to Eat: " + result5);
        }
    }
}
