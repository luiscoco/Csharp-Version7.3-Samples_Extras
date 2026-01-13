// C# 7.3: expression variables in more locations
// Demonstrates using pattern/out variables inside initializers and in query clauses.
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var dict = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };

        // In an initializer (focus is 'out var' placement)
        bool found = dict.TryGetValue("a", out var value) && value > 0;
        Console.WriteLine($"found={found}, value={value}");

        // In a LINQ query clause:
        // The 'out var tmp' is scoped to the 'let' initializer,
        // so capture its value into a nullable 'n' that IS in scope for 'where'/'select'.
        var data = new[] { "10", "oops", "20" };
        var parsed =
            from s in data
            let n = int.TryParse(s, out var tmp) ? (int?)tmp : null
            where n != null
            select n.Value;

        Console.WriteLine(string.Join(",", parsed));
    }
}
