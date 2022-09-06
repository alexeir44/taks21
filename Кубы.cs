double o;
bool check;
int i, n;
int j = 3;

int CorrectInput()
{
    string? UserNumber;
    int number = 0;
    check = false;
    while (check == false)
    {
        UserNumber = Console.ReadLine();
        if (int.TryParse(UserNumber, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
        }
    }
    return number;
}

Console.Write("Введите крайнее число:");
n = CorrectInput();

for (i = 1; i<=n; i++)
{
o = Math.Pow(i,j);
Console.Write($"{o} ");
}