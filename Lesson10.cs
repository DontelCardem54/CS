bool[] thimbles = new bool[3] { false, false, true };

Console.WriteLine("Игра в наперстки");
Console.WriteLine();
Console.WriteLine("под одним из трех наперстков находится шарик. Попробуйте угадать в каком!");
Console.WriteLine();
Console.Write("Введите ваше число от 1 до 3: ");
int input = Convert.ToInt32(Console.ReadLine());

bool result = thimbles[input-1];

if (result == true)
{
    Console.WriteLine("Да! Вы нашли шарик!");
}
else
{
    Console.WriteLine("Нет! Вы не угадали!");
}