// Задача 27. Напишите программу, которая принимает 
//на вход число N и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Sum of digits = {GetSumNums(num)}");
int GetSumNums(int number)// n = 0
{
    int sum = 0;//sum = 6 
    while(number>0) // 0 > 0
    {
        sum+=number%10;// sum += 1
        number/=10;// 1 /=10
    }
    return sum;
}
