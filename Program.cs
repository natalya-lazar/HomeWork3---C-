//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Решение:
/*void Palindrom (int num)
{
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num4 = (num / 10) % 10;
    int num5 = num % 10;
    if (num1 == num5 && num2 == num4){
        Console.WriteLine($"Число {num} является палиндромом.");
    }
    else Console.WriteLine($"Число {num} не является палиндромом.");
}
Console.WriteLine("Введите пятизначное число: ");
int user_num = Convert.ToInt32(Console.ReadLine());
if (user_num > 9999 && user_num < 100000){
    Palindrom(user_num);
}
else Console.WriteLine("Вы ввели не пятизначное число!");
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//Решение:
/*double Distance(int x1, int y1, int z1, int x2, int y2, int z2){
    int x = (x2 - x1);
    int y = (y2 - y1);
    int z = (z2 - z1);
    double distanceAB = Math.Sqrt(x * x + y * y + z *z);
    return distanceAB;
}
Console.WriteLine("Введите координату х точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки А: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double user_distance = Distance(xA, yA, zA, xB, yB,zB);
Console.WriteLine($"Расстояние между точками А и В: {user_distance:f3}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
//Решение:
void NumberCubed(int num){
    int current = 1;
    while (current <= num){
        int res = current * current * current;
        Console.Write($"{res}, ");
        current++;
    }
    Console.Write("\b\b.");
}
Console.WriteLine("Введите число N: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num >= 1){
    Console.Write($"{user_num} -> ");
    NumberCubed(user_num);
}
else Console.WriteLine("Невозможное значение!");
