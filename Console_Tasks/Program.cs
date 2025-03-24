using static System.Math;
using static System.Console;
using static System.Convert;

//entering a number function
double TheNumEnter( string a)
{
    WriteLine($"Введите число {a}");
    return ToDouble(ReadLine());
}


//VAR1
double FindZFunction(int z)
{
    double result = (1 + 1 / Pow(z,2)) - Sin(z);
    return result;
}
int TwoNumCompare()
{
    try
    {
        double a = TheNumEnter("A");
        double b = TheNumEnter("B");

        if (a < b) WriteLine($"Sqr(a) = {Pow(a, 2)}\nSqr(b) = {Pow(b, 2)}");
        if (a == b) WriteLine($"A = {a}\nB = {b}");
        if (a > b) WriteLine($"Cube(a) = {Pow(a, 3)}\nCube(b) = {Pow(b, 3)}");
    }
    catch (Exception)
    {
        WriteLine("NotNum");
        TwoNumCompare();
    }
    return 0;
}

//VAR2
double FindXFunction(int x)
{
    double result = Sin(2 * Pow(x, 2)) + x / Cos(0.1) * x;
    return result;
}

int TwoNumCompareVAR2()
{
    try
    {
        double a = TheNumEnter("A1");
        double b = TheNumEnter("A2");

        if (a == 0 && b == 0)
        {
            WriteLine($"A + B = {a + b}");
        }
        else
        {
            WriteLine($"A * B = {a * b}");
        }
    }
    catch (Exception)
    {
        WriteLine("NotNum((");
        TwoNumCompareVAR2();
    }
    return 0;
}
//Results:
TwoNumCompare();
TwoNumCompareVAR2();
//WriteLine($"First funtion result: {Function_z(3)}");
//WriteLine($"Var2 function result: {FindXFunction(1)}");

