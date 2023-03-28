Main();

void Main ()
{
    bool Work = true;
    while (Work)
    {
        System.Console.WriteLine("Решаем задачу? Введите y/n.");
        string a = Console.ReadLine();
        switch (a) 
        {
            case "y":Osn();break;
            case "n": Work = false; break;
        }
    }
}

void Osn()
{
    System.Console.WriteLine("Введите 1 число");
    int num1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите 2 число");
    int num2 = int.Parse(Console.ReadLine());
    int a = Magic(num1, num2);
    if (a == 0) System.Console.WriteLine($"Число {num1} кратно {num2}.");
    else System.Console.WriteLine($"Число {num1} не кратно {num2}, остаток {a}.");
}

int Magic(int number1, int number2)
{
    int a = number1 % number2;
    return a;
}