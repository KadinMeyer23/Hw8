//Kadin Meyer
//4/15/2025

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> Stack_Of_Chars = new Stack<char>();


        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                Stack_Of_Chars.Push(s[i]);
            }

            if (Stack_Of_Chars.Count == 0) { return false; }

            if (s[i] == ')' || s[i] == '}' || s[i] == ']')
            {
                char x = Stack_Of_Chars.Peek();
                if (x == '(' && s[i] == ')') { Stack_Of_Chars.Pop(); }
                else if (x == '{' && s[i] == '}') { Stack_Of_Chars.Pop(); }
                else if (x == '[' && s[i] == ']') { Stack_Of_Chars.Pop(); }
                else { return false;}
            }


        }
        if (Stack_Of_Chars.Count != 0) { return false; }
        else { return true; }




    }
}