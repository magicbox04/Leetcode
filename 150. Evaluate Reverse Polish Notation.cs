public class Solution 
{
    public int EvalRPN(string[] tokens) 
    {
        Stack<int> values= new Stack<int>();

        foreach (string c in tokens) 
        {
            if (c == "+") 
            {
                values.Push(values.Pop() + values.Pop());
            }
            else if (c == "-")
            {
                int a = values.Pop();
                int b = values.Pop();
                values.Push(b - a);
            }
            else if (c == "*")
            {
                values.Push(values.Pop() * values.Pop());
            }
            else if (c == "/")
            {
                int a = values.Pop();
                int b = values.Pop();
                values.Push(b / a);
            }
            else
            {
                values.Push(int.Parse(c));
            }
        }
        return values.Peek();
    }