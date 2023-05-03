using System;
using System.Collections.Generic;
using System.IO;
class Entry
{
    private string date;
    private string prompt;
    private string response;

    public Entry(string _date, string _prompt, string _response)
    {
        date = _date;
        prompt = _prompt;
        response = _response;
    }

    public void DisplayEntry()
    {
        Console.WriteLine("{0}\n{1}\n{2}\n", date, prompt, response);
    }

    public string GetEntryAsCSV()
    {
        return string.Format("{0},{1},{2}", date, prompt, response);
    }
}