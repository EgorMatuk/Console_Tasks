using static System.Math;
using static System.Console;
using static Methods;
using static System.Convert;
using System.ComponentModel;


/*Даны три действительных числа. Возвести в квадрат те из них, значения которых не
отрицательны и в четвертую степень – отрицательные. */
void Cmrsn()
{
    int [] arr = ArrayComp(3);
    WriteLine("-------------Array Before---------------");
    ArrayElements(arr);
    for (int i = 0; i <= arr.Length-1; ++i)
    {
        if (arr[i] < 0) { 
            arr[i] = arr[i] * arr[i] ; 
        }else if (arr[i] > 0) { 
            arr[i] = ToInt32(ToDouble(Pow( arr[i], 4) )) ; 
        }
    }
   WriteLine("--------------Array After---------------");
   ArrayElements(arr);
}
//Cmrsn();

/*По введенному натуральному числу n (п<=100), обозначающему количество ворон, выве
сти надпись «На дереве п ворон», где ворона склоняется соответственно п: «ворон», 
«ворона», «вороны». В случае, если п > 100, вывести надпись «Ветка обломилась». */

void CrowCount(int num)
{
    if (num == 1) 
    {
        WriteLine($"На дереве {num} ворона"); 
    }else if(num < 5 && num != 1)
    {
        WriteLine($"На дереве {num} вороны");
    } else
    {
        WriteLine($"На дереве {num} ворон");
    }
    if (num > 100)
    {
        WriteLine("Ветка обломилась");
    }
}

/*Факториал числа A */
int Factorial(int num)
{
    if (num == 1) 
    {
        return 1;
    }
    else
    {
        return num *= Factorial(num - 1);
    }
}
WriteLine(Factorial(5));
//CrowCount(ToInt32(TheNumEnter("Ворон")));