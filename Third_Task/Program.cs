using static System.Math;
using static System.Console;
using static Methods;
using static System.Convert;


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
Cmrsn();
