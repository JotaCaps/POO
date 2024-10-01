// See https://aka.ms/new-console-template for more information
Dictionary<string, int> dictionary = new Dictionary<string, int>();

Console.WriteLine("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] lines = sr.ReadLine().Split(',');
            string candidate = lines[0];
            int votes = int.Parse(lines[1]);
;
            if (dictionary.ContainsKey(candidate))
            {
                dictionary[candidate] += votes;
            }
            else 
            {
                dictionary[candidate] = votes;    
            }
        }
        foreach (var item in dictionary)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
