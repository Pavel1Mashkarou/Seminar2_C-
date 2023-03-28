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
    System.Console.WriteLine("Введите первый катет:");
    int kat1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите второй катет:");
    int kat2 = int.Parse(Console.ReadLine());
    int sq = Square(kat1, kat2);
    System.Console.WriteLine($"Площадь прямоугольного трегольника равна - {sq}");
}

int Square (int number1, int number2)
{
    int sq = number1*number2/2;
    return sq;
}