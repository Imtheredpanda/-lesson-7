// // ЗАДАЧА 1! Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

//  void Nums(int m, int n)
// {   
//     if (n > m+1)
//     {
//         Console.WriteLine(m+1); 
//         Nums(m+1,n);
//     }
//      if (m > n+1)
//     {
//         Console.WriteLine(n+1);
//         Nums(m,n+1); 
//     }
// }

// Console.WriteLine("Введи число M:");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введи число N:");
// int n = Convert.ToInt32(Console.ReadLine());

// Nums(m,n);

// // ЗАДАЧА 2! Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);


// // вызов функции Аккермана
// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// // функция Аккермана
// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }



// ЗАДАЧА 3! Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// заполнение рандом массива рекурсией

void CreateArrRecurs(int[] arr, int i)
{
    if (i-1<0)
    {
      return;
    }
     Random rnd = new Random();
     arr[i-1] = rnd.Next(1, 10);
     CreateArrRecurs(arr,i-1);
    
}
    

//вывод массива циклом ДЛЯ ПРОВЕРКИ
void ShowArr(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
     Console.Write($"{Arr[i]} "); //Интерполяция строк
    }

}


//вывод массива начиная с конца РЕКУРСИЕЙ
void ShowArray(int[] Arr, int i)
{
    if(i > 0)
    {
        Console.Write($"{Arr[i-1]} ");
        ShowArray(Arr, i-1);
        
    }
    else
    {
        Console.Write("");
    }
}

Console.WriteLine("Введи длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int[num];
CreateArrRecurs(array,array.Length);
ShowArr(array);
Console.WriteLine("");
ShowArray(array,array.Length);