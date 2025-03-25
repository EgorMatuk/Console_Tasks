using static System.Math;
using static System.Console;
using static System.Convert;
using static Methods;


//ВАРИАНТ 1
void FindZFunction()
{
    double a = TheNumEnter("A");
    double x = TheNumEnter("X");
    double z1 = (Sin(a) / 1 + Cos(4 * a)) * (Cos(2*a) / 1 + Cos(2 * a));
    double z2 = Sqrt((x+3)/(x-3));
    WriteLine($"Z1={z1}\nZ2 = {z2}");
}

FindZFunction();
