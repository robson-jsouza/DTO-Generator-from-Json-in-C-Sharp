using System;
using MyApp.Models; // Person will be generated into this namespace

class Program
{
    static void Main()
    {
        var p = new Person
        {
            Id = 42,
            Name = "Alice"
            // Email defaults to null (string?), Tags defaults to new List<string>()
        };

        p.Tags.Add("vip");
        Console.WriteLine($"#{p.Id}: {p.Name} | email={p.Email ?? "(none)"} | tags=[{string.Join(", ", p.Tags)}]");
    }
}
