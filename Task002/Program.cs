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

void Osn ()
{
    int a = new Random().Next(100,998+1);
    System.Console.WriteLine($"Ваше число - {a}");
    int number = Magic(a);
    System.Console.WriteLine($"Ваше изменённое число - {number}");
}

int Magic (int a)
{
    int num2 = a % 10;
    int num1 = a / 100;
    int number = num1 *10 +num2;
    return number;
}