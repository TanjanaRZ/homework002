Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n5 = n % 10;
int n4 = (n % 100 - n5) / 10;
int n3 = (n % 1000 - n5 - n4 * 10) / 100;
int n2 = (n % 10000 - n5 - n4 * 10 - n3 * 100) / 1000;
int n1 = n / 10000;
if (n5 == n1 && n4 ==n2)
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}
