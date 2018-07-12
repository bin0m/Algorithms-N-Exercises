using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algorithms_N_Exercises.DesignPatterns
{
    public interface IDatabase
    {
        int GetPopulation(string city);
    }
    
    public class SafeSingletonDatabase : IDatabase
    {
        private static Lazy<SafeSingletonDatabase> _instance =
            new Lazy<SafeSingletonDatabase>(() => new SafeSingletonDatabase());

        public static SafeSingletonDatabase Instance => _instance.Value;

        private static int _countOfInstances;
        public static int CountOfInstances => _countOfInstances;

        private readonly Dictionary<string, int> _capitals;

        private SafeSingletonDatabase()
        {
            _countOfInstances++;
            Console.WriteLine("Initializing SafeSingletonDatabase");
            _capitals = File.ReadAllLines("capitals.txt")
                .ToDictionary(line => line.Trim().Split(';')[0], line => int.Parse(line.Trim().Split(';')[1]));

        }

        public int GetPopulation(string city)
        {
            return _capitals[city];
        }
    }
}