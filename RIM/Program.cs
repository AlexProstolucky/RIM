using System;
using System.Linq;
using HtmlAgilityPack;

class Program
{
    static void Main()
    {
        string url = "https://rymy.in.ua";
        var web = new HtmlWeb();
        var doc = web.Load(url);

        var cssLinks = doc.DocumentNode.Descendants("link")
            .Where(link => link.Attributes["rel"]?.Value == "stylesheet")
            .Select(link => link.Attributes["href"]?.Value)
            .ToList();

        Console.WriteLine($"Кількість лінків на сторінці зі стилями: {cssLinks.Count}");

        Console.WriteLine("Лінки на сторінці:");
        foreach (var link in cssLinks)
        {
            Console.WriteLine(link);
        }
    }
}
