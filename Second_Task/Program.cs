using static System.Math;
using static System.Console;
using static Methods;


//ВАРИАНТ 1
/* Составьте программу для расчета по двум формулам. Предварительно подготовьте те
стовые примеры с помощью калькулятора. Отсутствующие в языке функции выразите 
через имеющиеся.*/ 
void FindZFunction()
{
    double a = TheNumEnter("A");
    double x = TheNumEnter("X");
    double z1 = (Sin(a) / 1 + Cos(4 * a)) * (Cos(2*a) / 1 + Cos(2 * a));
    double z2 = Sqrt((x+3)/(x-3));
    WriteLine($"Z1={z1}\nZ2 = {z2}");
}


/*Дано действительное число а. Не пользуясь ни какими другими арифметическими 
операциями, кроме умножения получить а4 за 2 операции.*/
void PowFunction(double a)
{
    double sqrA = a * a;
    double result = sqrA * sqrA;
    WriteLine(result);
}
FindZFunction();
PowFunction(2);
