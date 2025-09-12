public class Program
{
    // https://leetcode.com/problems/valid-parentheses/submissions/1768129981/?sorting=W3sic29ydE9yZGVyIjoiQVNDRU5ESU5HIiwib3JkZXJCeSI6IkRJRkZJQ1VMVFkifV0%3D&page=11
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        int len = input.Length;
        var stack = new Stack<char>();
        bool isValid = true;

        for (int i = 0; i < len; i++)
        {
            char ch = input[i];
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else
            {
                if (!stack.Any())
                {
                    isValid = false;
                    break;
                }
                else
                {
                    var top = stack.Peek();
                    if (ch == ')' && top == '(')
                        stack.Pop();
                    else if (ch == '}' && top == '{')
                        stack.Pop();
                    else if (ch == ']' && top == '[')
                        stack.Pop();
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
            }
        }

        if (stack.Any())
            isValid = false;

        Console.WriteLine("isValid: ", isValid);
    }
}