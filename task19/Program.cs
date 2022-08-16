Console.WriteLine("Введите пятизначное число: ");
string n = (Console.ReadLine());
if (n[4] == n[0] && n[3] ==n[1])
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}


