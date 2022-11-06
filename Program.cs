// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// try
// {
// Console.WriteLine("Введите первое число ");
// int x=Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int y=Convert.ToInt32( Console.ReadLine());
// if (x>y) Console.WriteLine("Первое число больше второго ");
// else if (x==y) Console.WriteLine("Это одинаковые числа ");
// else Console.WriteLine("Второе число больше первого ");
// }
// catch
// {
//  Console.WriteLine("Я ЖЕ ПОПРОСИЛ ВВЕСТИ ЧИСЛА!!!!!!!! ");  
// }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22
// try
// {
// Console.WriteLine("Введите первое число ");
// int a = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int b = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите третье число ");
// int c = Convert.ToInt32( Console.ReadLine());
// int max = a ;
 
// if (b > max) max = b;
// if (c > max) max = c;

//   Console.Write("максимальное число = ");
//   Console.Write( max );


// }
// catch
// {
//  Console.WriteLine("Я ЖЕ ПОПРОСИЛ ВВЕСТИ ЧИСЛА!!!!!!!! ");  
// }

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// // 4 -> да
// // -3 -> нет
// // 7 -> нет
// try
// {
// Console.WriteLine(" Любое число ");
// int a = Convert.ToInt32( Console.ReadLine());
// if (a%2 == 0) 
// {
//     Console.Write( "да" );
// }    
// else 
// {
//     Console.Write( "нет" );
// }    
// }
// catch
// {
//  Console.WriteLine("Я ЖЕ ПОПРОСИЛ ВВЕСТИ ЧИСЛА!!!!!!!! ");  
// }

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8
try
{
Console.WriteLine(" Введите число ");
int x=Convert.ToInt32( Console.ReadLine());
int count = 1;

while (count <= x)
{
if  (count%2 == 0)   
Console.Write( count+ " " );  
  count = count + 1;
}
if  (count%2 == 0)  Console.Write( count );
    
}
catch
{
 Console.WriteLine("Я ЖЕ ПОПРОСИЛ ВВЕСТИ ЧИСЛО!!!!!!!! ");  
}