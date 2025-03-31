namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            string cleanedInput = "";
            foreach (char c in input.ToLower())
            {
                if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                {
                    cleanedInput += c;
                }
            }

            int left = 0;
            int right = cleanedInput.Length - 1;

            while (left < right)
            {
                if (cleanedInput[left] != cleanedInput[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
