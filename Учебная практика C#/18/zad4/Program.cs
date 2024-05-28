using System;
using System.Collections;

class CD
{
    public string Title { get; set; }
    public ArrayList Songs { get; set; }

    public CD(string title)
    {
        Title = title;
        Songs = new ArrayList();
    }

    public void AddSong(string song)
    {
        Songs.Add(song);
    }

    public void RemoveSong(string song)
    {
        Songs.Remove(song);
    }

    public void DisplaySongs()
    {
        Console.WriteLine("Songs in " + Title + ":");
        foreach (string song in Songs)
        {
            Console.WriteLine(song);
        }
    }
}

class CDCatalog
{
    private Hashtable cds;

    public CDCatalog()
    {
        cds = new Hashtable();
    }

    public void AddCD(string title)
    {
        cds[title] = new CD(title);
    }

    public void RemoveCD(string title)
    {
        cds.Remove(title);
    }

    public void DisplayCatalog()
    {
        foreach (CD cd in cds.Values)
        {
            cd.DisplaySongs();
        }
    }

    public CD GetCD(string title)
    {
        return (CD)cds[title];
    }
}
class Program
{
    static void Main(string[] args)
    {
        CDCatalog catalog = new CDCatalog();

        catalog.AddCD("CD1");
        catalog.AddCD("CD2");

        catalog.GetCD("CD1").AddSong("Song1");
        catalog.GetCD("CD1").AddSong("Song2");
        catalog.GetCD("CD2").AddSong("Song3");

        Console.WriteLine("Диски:");
        catalog.DisplayCatalog();

        catalog.GetCD("CD1").RemoveSong("Song1");

        Console.WriteLine("Первый диск после удаление первой песни: ");
        catalog.GetCD("CD1").DisplaySongs();

        catalog.RemoveCD("CD2");

        Console.WriteLine("Каталог после удаления второго диска:");
        catalog.DisplayCatalog();
    }
}
