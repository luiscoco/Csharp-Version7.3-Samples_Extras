// C# 7.3: compiler options notes (non-language features)
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Notes:");
        Console.WriteLine("  -publicsign   : OSS signing (works with public key only).");
        Console.WriteLine("  -pathmap      : Remap source paths in PDBs for reproducible builds.");
        Console.WriteLine();
        Console.WriteLine("MSBuild examples:");
        Console.WriteLine("  dotnet build -p:PublicSign=true -p:PathMap=C:=X;D:=Y");
    }
}
