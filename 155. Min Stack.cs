public class MinStack 
{
    private Stack<int> stack;
    private int min;
    public MinStack() 
    {
        stack = new Stack<int>();
    }
    
    public void Push(int val) 
    {
        if (stack.Count == 0 || val < min)
        {
            min = val;
        }

        stack.Push(min);
        stack.Push(val);
    }
    
    public void Pop() 
    {
        
        if (min == stack.Pop())
        {
            stack.Pop();
            if (stack.Count > 0)
            {
                int temp = stack.Pop();
                min = stack.Peek();
                stack.Push(temp);
            }
        }
        else
        {
            stack.Pop();
        }
    }
    
    public int Top() 
    {
        return stack.Peek();
    }
    
    public int GetMin() 
    {
        return min;
    }
}