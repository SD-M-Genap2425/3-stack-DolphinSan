namespace Solution.BrowserHistory
{
    public class HistoryManager
    {
        private List<string> history;
        private int currentIndex;

        public HistoryManager()
        {
            history = new List<string>();
            currentIndex = -1;
        }

        public void KunjungiHalaman(string url)
        {
            if (currentIndex < history.Count - 1)
            {
                history.RemoveRange(currentIndex + 1, history.Count - currentIndex - 1);
            }

            history.Add(url);
            currentIndex = history.Count - 1;
        }

        public string Kembali()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                return history[currentIndex];
            }
            else
            {
                return "Tidak ada halaman sebelumnya.";
            }
        }

        public string LihatHalamanSaatIni()
        {
            if (currentIndex >= 0 && history.Count > 0)
            {
                return history[currentIndex];
            }
            return string.Empty;
        }

        public void TampilkanHistory()
        {
            foreach (var page in history)
            {
                Console.WriteLine(page);
            }
        }
    }
}