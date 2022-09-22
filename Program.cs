using System;
using Newtonsoft.Json;
namespace myproject
{
    class Program
    {
        class Mascot
        {
            public string? name {get; set;}
            public string? team {get; set;}
            public string? phrase {get; set;}
        }
        static void Main(string[] args)
        {
            Mascot nugetmascot =new Mascot()
            {
                name = "Nuget Warrior",
                team = "Nuget",
                phrase = "where packages come to life",
            };
            string json = JsonConvert.SerializeObject(nugetmascot, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}