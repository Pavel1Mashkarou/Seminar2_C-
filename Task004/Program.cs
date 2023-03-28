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
    bool ans = Magic(num1);
    if (ans) System.Console.WriteLine("Да");
    else System.Console.WriteLine("Нет");
}

bool Magic(int number)
{
    int a = number % 7;
    int b = number % 23;
    return a==0 && b==0;
    
    
}