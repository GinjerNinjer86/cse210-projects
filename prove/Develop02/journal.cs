using System;
using System.Collections.Generic;
using System.IO;
class Journal
{
    List<Entry> entries;
    List<string> prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public void CreateJournalEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void SaveToCSV(string filename)
    {
        StreamWriter sw = new StreamWriter(filename);
        foreach (Entry entry in entries)
        {
            sw.WriteLine(entry.GetEntryAsCSV());
        }
        sw.Close();
    }

    public void LoadFromCSV(string filename)
    {
        entries.Clear();
        StreamReader sr = new StreamReader(filename);
        while (!sr.EndOfStream)
        {
            string[] fields = sr.ReadLine().Split('|');
            Entry entry = new Entry(fields[0], fields[1], fields[2]);
            entries.Add(entry);
        }
        sr.Close();
    }
}
