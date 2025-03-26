using static System.Math;
using static System.Console;
using static Methods;
using static System.Convert;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;


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
int Factorial(int number)
{
  if (number < 1)
  {
    return 0;
  }
  else if (number == 1)
  {
    return 1;
  }
  else
  {
    return number * Factorial(number - 1);
  }
}

void RunFactorial()
{
    for (int i = 1; i < 15; i++)
    {
        WriteLine($"{i}! = {Factorial(i):N0}");
    }
}
RunFactorial();
//CrowCount(ToInt32(TheNumEnter("Ворон")));