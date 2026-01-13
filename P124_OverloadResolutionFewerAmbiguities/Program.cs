// C# 7.3: overload resolution improvements reduce ambiguous cases
using System;

class Demo
{
    // Historically ambiguous with certain combinations; C# 7.3 tightens rules.
    static void M(in int x)  { Console.WriteLine("M(in int)"); }
    static void M(object x)  { Console.WriteLine("M(object)"); }

    static void Main()
    {
        int v = 5;
        // Prefers 'in' overload instead of reporting ambiguity with boxing to object.
        M(v);
    }
}
