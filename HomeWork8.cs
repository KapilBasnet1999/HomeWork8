// Written By Kapil Basnet
// April 13, 2025

using System;
using System.Collections.Generic;

namespace HomeWork8
{
    public class HomeWork8
    {
        // 1. Valid Parentheses
        public bool IsValid(string s)
        {
            char[] stack = new char[s.Length];
            int top = -1;

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];

                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack[++top] = ch;
                }
                else
                {
                    if (top == -1) return false;

                    char last = stack[top--];
                    if ((ch == ')' && last != '(') ||
                        (ch == ']' && last != '[') ||
                        (ch == '}' && last != '{'))
                    {
                        return false;
                    }
                }
            }
            return top == -1;
        }

        // 2. Baseball Game
        public int CalPoints(string[] ops)
        {
            int[] record = new int[ops.Length];
            int index = 0;

            for (int i = 0; i < ops.Length; i++)
            {
                string op = ops[i];

                if (op == "+")
                {
                    record[index] = record[index - 1] + record[index - 2];
                    index++;
                }
                else if (op == "D")
                {
                    record[index] = 2 * record[index - 1];
                    index++;
                }
                else if (op == "C")
                {
                    index--;
                }
                else
                {
                    int num = 0, sign = 1, j = 0;
                    if (op[0] == '-')
                    {
                        sign = -1;
                        j = 1;
                    }
                    for (; j < op.Length; j++)
                    {
                        num = num * 10 + (op[j] - '0');
                    }
                    record[index] = num * sign;
                    index++;
                }
            }

            int sum = 0;
            for (int i = 0; i < index; i++)
            {
                sum += record[i];
            }

            return sum;
        }

        // 3. Find Pivot Index
        public int PivotIndex(int[] nums)
        {
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }

            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int rightSum = total - leftSum - nums[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }

            return -1;
        }

        // 4. RecentCounter
        public class RecentCounter
        {
            private int[] queue = new int[10000];
            private int start = 0;
            private int end = 0;

            public RecentCounter() { }

            public int Ping(int t)
            {
                queue[end++] = t;
                while (queue[start] < t - 3000)
                {
                    start++;
                }
                return end - start;
            }
        }

        // 5. Count Students Unable to Eat Lunch
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int studentCount = students.Length;
            int front = 0, sandwichIndex = 0;
            int rounds = 0;

            while (sandwichIndex < sandwiches.Length && rounds < studentCount)
            {
                if (students[front] == sandwiches[sandwichIndex])
                {
                    sandwichIndex++;
                    front = (front + 1) % students.Length;
                    rounds = 0;
                    studentCount--;
                }
                else
                {
                    int temp = students[front];
                    for (int i = front; i < front + studentCount - 1; i++)
                    {
                        students[i % students.Length] = students[(i + 1) % students.Length];
                    }
                    students[(front + studentCount - 1) % students.Length] = temp;
                    rounds++;
                }
            }

            return studentCount;
        }
    }

}
