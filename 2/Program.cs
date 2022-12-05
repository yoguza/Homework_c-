// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


//int N;
Console.Write($"Введите число:");
string number = Console.ReadLine()!;

if(number.Length<2)
{
    Console.Write($"Число меньше трезначного");
}
else
{
   Console.Write($"Вторая цифра = {number[1]}"); 
}





