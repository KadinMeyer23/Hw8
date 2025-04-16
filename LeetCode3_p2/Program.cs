//Kadin Meyer
//4/15/2025

public class Solution
{
    public int CalPoints(string[] operations)
    {

        Stack<int> scores = new Stack<int>();

        foreach (string operation in operations)
        {
            switch (operation)
            {
                case ("+"):
                    {

                        int lastScore = (int)scores.Pop();
                        int newScore = lastScore + (int)scores.Peek();

                        scores.Push(lastScore);
                        scores.Push(newScore);
                    }; break;
                case ("D"):
                    scores.Push((int)scores.Peek() * 2);
                    break;
                case ("C"):
                    scores.Pop();
                    break;
                default:
                    scores.Push((int.Parse(operation)));
                    break;
            }
        }

        return scores.Sum();
    }
}