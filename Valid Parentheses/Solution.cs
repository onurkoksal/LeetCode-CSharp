public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s){
            if(c== '('|| c == '[' || c== '{'){
                stack.Push(c);
            }
            else {
                if (stack.Count == 0) {
                    return false;
                }
                char Top = stack.Pop();

                if (c == ')' && Top != '(') return false;
                if (c == ']' && Top != '[') return false;
                if (c == '}' && Top != '{') return false;
            }
        }
        if (stack.Count == 0){
            return true;}
        else
        {return false;}   
    }
}
