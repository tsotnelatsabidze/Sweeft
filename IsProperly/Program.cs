﻿
bool IsProperly(string sequence)
{
    Stack<char> stack = new Stack<char>();
    foreach (char c in sequence)
    {
        if (c == '(')
            stack.Push(')');
        else if (stack.Count == 0 || stack.Pop() != c)
            return false;
    }
    return stack.Count == 0;
}



