
    class Journal
    {
        List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }
        public void DisplayJournalEntries()
        {
            foreach (Entry entry in entries)
            {
                entry.DisplayEntry();
            }
        }
        public void CreateJournalEntry()
        {

        }
        public void SaveToCSV()
        {

        }
        public void LoadFromCSV()
        {

        }

    }
