using System;
using System.Collections.Generic;

public interface IDeveloper
{
    string Tool { get; set; }
    void Create();
    void Destroy();
}


public class Programmer : IDeveloper
{
    public string Tool { get; set; }
    public string Language { get; set; }

    public Programmer(string tool, string language)
    {
        Tool = tool;
        Language = language;
    }

    public void Create()
    {
        Console.WriteLine($"Програміст мовою {Language} з використанням {Tool} створює щось.");
    }

    public void Destroy()
    {
        Console.WriteLine($"Програміст мовою {Language} з використанням {Tool} видляє щось.");
    }
}
public class Builder : IDeveloper
{
    public string Tool { get; set; }
    public string ConstructionType { get; set; }

    public Builder(string tool, string constructionType)
    {
        Tool = tool;
        ConstructionType = constructionType;
    }

    public void Create()
    {
        Console.WriteLine($"Будівельник, що будує {ConstructionType} та використовує {Tool}, будує щось.");
    }

    public void Destroy()
    {
        Console.WriteLine($"Будівельник, що будує {ConstructionType} та використовує {Tool}, демонтує щось.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        List<IDeveloper> developers = new List<IDeveloper>
        {
            new Programmer("Visual Studio", "C#"),
            new Builder("плиткоріз", "Житловий будинок"),
            new Programmer("vs code", "Java"),
            new Builder("шуроповерт", "Школа")
        };

       
        foreach (var developer in developers)
        {
            developer.Create();
            developer.Destroy();
        }


    }
}