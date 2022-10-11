/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.WriteLine("Ввeдите число А, которое будем возводить в степень: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("В какую степень натуральную степень В возведем число А?: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{a}^{b} = {MyPow(a, b)}");

int MyPow(int A, int B){
    int result = 1;
    for(int i = 0; i < B; i++){
        result *= A;
    }
    return result;
}

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Ввeдите натуральное число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр числа {num} равна {SumDigits(num)}");

int SumDigits(int number){
    int total = 0;
    while(number > 0){
        total += number % 10;
        number /= 10;
    }
    return total;
}

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


//рандомные элементы в диапазоне от X до Y (количество элементов массива задает пользователь)

Console.WriteLine("Ввeдите размер массива: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввeдите минимальное значение элемента массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввeдите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine()!);
Console.WriteLine($"[{String.Join(", ", ArrRand2(N, min, max))}]");

int[] ArrRand2(int size, int low, int ceil){
    int[] result = new int[size];

    for(int i = 0; i < result.Length; i++){
        result[i] = new Random().Next(low, ceil + 1);
    }
return result;
}


//количество элементов и элементы задает пользователь

Console.WriteLine("Ввeдите размер массива: ");
int len = int.Parse(Console.ReadLine()!);
Console.WriteLine($"[{String.Join(", ", ArrUser(len))}]");

int[] ArrUser(int size){
    int[] result = new int[size];

    for(int i = 0; i < result.Length; i++){
        Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
        result[i] = int.Parse(Console.ReadLine()!);
    }
return result;
}