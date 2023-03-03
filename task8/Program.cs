// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("список чётных чисел от 1 до вашего числа:");
int counter = -1;
if(number1<=0)
{
    while(counter >= number1)
    {
        if(counter%2 == 0)
        {
            System.Console.WriteLine(counter);
        }
        counter--;
    }
}
else
{
    counter = 1;
    while(counter <= number1)
    {
        if(counter%2 == 0)
        {
            System.Console.WriteLine(counter);
        }
        counter++;
    }
}
