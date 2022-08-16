Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= N)
{
    Console.Write($"{Math.Pow(count,3)}    ");
    count++;
}
