using static System.Math;
using static System.Console;
using static System.Convert;
using System.Reflection.Metadata.Ecma335;
double FindZFunction(int z)
{
    double result = (1 + 1 / Pow(z,2)) - Sin(z);
    return result;
}
double FindXFunction(int x)
{
    double result = Sin(2 * Pow(x , 2)) + x / Cos(0.1) * x;
    return result;
}
int TwoNumCompare()
{
    double a = 0, b = 0;
    try
    {
        WriteLine("Введите число А:");
        a = ToDouble(ReadLine());
        WriteLine("Введите число B:");
        b = ToDouble(ReadLine());
    }
    catch (Exception)
    {
        WriteLine("NotNum");
    }
    finally
    {
        if (a < b) WriteLine($"Sqr(a) = {Pow(a, 2)}\nSqr(b) = {Pow(b, 2)}");
        if (a == b) WriteLine($"A = {a}\nB = {b}");
        if (a > b) WriteLine($"Cube(a) = {Pow(a, 3)}\nCube(b) = {Pow(b, 3)}");
    }
    return 0;
}

//TwoNumCompare();
//WriteLine($"First funtion result: {Function_z(3)}");
WriteLine($"Var2 function result: {FindXFunction(1)}");

