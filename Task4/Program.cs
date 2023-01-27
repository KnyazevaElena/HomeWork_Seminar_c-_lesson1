// Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел
Console.Clear();
Console.Write ("Введите первое число: ");
int Number1 = int.Parse (Console.ReadLine());
Console.Write ("Введите второе число: ");
int Number2 = int.Parse (Console.ReadLine());
Console.Write ("Введите третье число: ");
int Number3 = int.Parse (Console.ReadLine());
int max = 0;
if(Number1 > max)  max = Number1;   
if (Number2 > max) max = Number2; 
if (Number3 > max) max = Number3; 
Console.Write ("max = ");
Console.WriteLine (max);
