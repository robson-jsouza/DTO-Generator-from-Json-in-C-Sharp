using MyApp.Models; // Person will be generated into this namespace

class Program
{
    static void Main()
    {
        var p = new Person
        {
            Id = 42,
            Name = "Alice",
            // Email defaults to null (string?), Tags defaults to new List<string>()
            Address = new Address
            {
                StreetName = "Fake Street",
                Number = "770",
                District = "Fake District",
                City = "Fake City",
                Country = "Fake Country"
            },
            Title = new Title
            {
                Course = "Computer Science",
                YearOfCompletion = 2012
            },
            Jobs = new List<Job>
            {
                new Job
                { 
                    Title = "Junior Developer",
                    StartDate = new DateTime(2013, 03, 01),
                    EndDate = new DateTime(2013, 05, 03)
                },
                new Job
                {
                    Title = "Mid Developer",
                    StartDate = new DateTime(2013, 05, 06)
                }
            }
        };
        p.Tags.Add("vip");

        Console.WriteLine($"#{p.Id}: {p.Name} | email={p.Email ?? "(none)"} | tags=[{string.Join(", ", p.Tags)}]");
        Console.WriteLine($"Address: street name={p.Address.StreetName ?? "(none)"} | number={p.Address.Number ?? "(none)"} | " +
            $"district={p.Address.District ?? "(none)"} | city={p.Address.StreetName ?? "(none)"} | " +
            $"country={p.Address.Country ?? "(none)"}");
        Console.WriteLine($"Title: course={p.Title.Course ?? "(none)"} | year of completion={p.Title.YearOfCompletion}");
        Console.WriteLine("\nJobs:\n");
        foreach (var job in p.Jobs)
            Console.WriteLine($"Job: title={job.Title ?? "(none)"} | start date={job.StartDate.ToString()} | " +
                $"end date={job.EndDate?.ToString() ?? "-"}");
    }
}
