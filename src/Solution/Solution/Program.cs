using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager historyManager = new HistoryManager();
        historyManager.KunjungiHalaman("google.com");
        historyManager.KunjungiHalaman("example.com");
        historyManager.LihatHalamanSaatIni();
        historyManager.Kembali();
        historyManager.TampilkanHistory();

        // Bracket validator
        BracketValidator validator = new BracketValidator();
        string expression = "{[()]}";
        validator.ValidasiEkspresi(expression);

        //Palindrome Checker
        string input = "Kasur ini rusak";
        bool isPalindrome = PalindromeChecker.CekPalindrom(input);
        string input2 = "A man, a plan, a canal: Panama";
        bool isPalindrome2 = PalindromeChecker.CekPalindrom(input2);



    }
}
