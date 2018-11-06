public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        int count = 0;
        
        foreach (var letter in input)
        {
            if (letter == '(')
            {
                count++;
            }
            else if (letter == ')')
            {
                count--;
            }
            
            
            if (count < 0)
            {
                return false;
            }
        }
        
        return count == 0;
    }
}