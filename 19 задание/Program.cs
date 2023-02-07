//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.Write("Введите любое пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

int num1= (num % 10)*10000;

int num2 = ((num%100)/10)*1000;

int num3 = ((num % 1000)/100)*100;

int num4 = ((num % 10000)/1000)*10;

int num5 = num / 10000;

int sum= num1 + num2 + num3 + num4 + num5;

if (sum == num)
{
    Console.WriteLine("Это число является палиндромом");
}
else 
{
    Console.WriteLine("Это число не является палиндромом");
}