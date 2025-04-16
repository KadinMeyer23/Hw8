//Kadin Meyer
//4/16/2025

namespace LeetCode3_p5
{
    public class Solution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> studentQueue = new Queue<int>(students);
            Stack<int> sandwichStack = new Stack<int>();

            for (int i = sandwiches.Length - 1; i >= 0; i--)
            {
                sandwichStack.Push(sandwiches[i]);
            }

            int count = 0;

            while (studentQueue.Count > 0 && count < studentQueue.Count)
            {
                if (studentQueue.Peek() == sandwichStack.Peek())
                {
                    studentQueue.Dequeue();
                    sandwichStack.Pop();
                    count = 0;
                }
                else
                {
                    studentQueue.Enqueue(studentQueue.Dequeue());
                    count++;
                }
            }

            return studentQueue.Count;
        }
    }

}
