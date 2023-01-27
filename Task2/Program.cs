// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.Clear();
Console.Write ("Введите число: ");
int Number1 = int.Parse (Console.ReadLine());
Console.Write ("Введите второе число: ");
int Number2 = int.Parse (Console.ReadLine());
if(Number1 > Number2){
    Console.WriteLine ($"{Number1} = max");
}
if (Number1 < Number2) {;
    Console.WriteLine ($"{Number2} = max");
}
