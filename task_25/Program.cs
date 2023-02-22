// Задача 25. Напишите функцию, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Enter number: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Enter degree: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{A} to the degree {B} = {Pow(A,B)}");


int Pow(int num, int rank)
{
    if(B==0) return 1;

    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }
    return result;
}
