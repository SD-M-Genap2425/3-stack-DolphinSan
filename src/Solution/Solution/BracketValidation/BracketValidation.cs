namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        public bool ValidasiEkspresi(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return true;

            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> brackets = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char c in expression)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                        return false;
                    char correspondingOpenBracket = brackets[c];

                    if (stack.Pop() != correspondingOpenBracket)
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}