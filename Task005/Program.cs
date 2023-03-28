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
    System.Console.WriteLine("Введите первое число:");
    int num1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите второе число:");
    int num2 = int.Parse(Console.ReadLine());
    bool ans = Magic(num1, num2)||Magic(num2,num1);
    if (ans) System.Console.WriteLine("Да");
    else System.Console.WriteLine("Нет");
}

bool Magic(int num1, int num2)
{
    return num1*num1==num2;
}