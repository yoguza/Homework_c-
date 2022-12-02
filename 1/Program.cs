int a;
int b;
//int c;
int max;

string UA;
string UB;
//string UC;



Console.Write($"Введите первое число: ");
UA = Console.ReadLine()!;
Console.Write($"Введите второе число: ");
UB = Console.ReadLine()!;
//Console.Write($"Введите третье число: ");
//UC = Console.ReadLine()!;

a = int.Parse(UA);
b = int.Parse(UB);
//c = int.Parse(UC);

if(a > b)
{ max = a; }
else
{ max = b; }

//if(max>c)
//{Console.Write($"Максимальное число = {max}\n");}
//else
//{{Console.Write($"Максимальное число = {c}\n");}}

Console.Write($"Максимальное число = {max}\n");
