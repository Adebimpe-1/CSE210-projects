public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry()
    {
        _date = "";
        _prompt = "";
        _response = "";
    }

    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt}");
        Console.WriteLine($"  > {_response}\n");
    }

    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        Entry entry = new Entry();
        entry._date = parts[0];
        entry._prompt = parts[1];
        entry._response = parts[2];
        return entry;
    }
}
