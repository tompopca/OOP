using System.Numerics;

TestComplex.Test(new Complex(3.0, 5.0), new Complex(2.0, 1.0) + new Complex(1.0, 4.0), "operator +");


Console.WriteLine("\nModul: {0}", new Complex(2.0, 1.0).Modul());

Console.WriteLine("\nArgument: {0}", new Complex(2.0, 1.0).Argument());


Console.ReadLine();