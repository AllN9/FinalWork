//Используемые функции
int Greeting()
{
    Console.Write("Введите размер массива: ");

    int n = Convert.ToInt32(Console.ReadLine());

    return n;
}
string [] Filling(int n)
{
    Console.Write("Введите ваш массив: ");

    string [] mas = new string [n];
    for(int i = 0; i < n; i++)
    {
        mas[i] = Console.ReadLine();
    }

    return mas;
}
void Check(int n, string[] mas)
{
    Console.WriteLine("Введенный вами массив: ");

    Console.Write("[\"" + mas[0]);
    for(int i = 1; i < n; i++)
    {
        Console.Write("\", \"" + mas[i]);
    }
    Console.WriteLine("\"]");
}
void Result(int n, string[] mas)
{
    Console.WriteLine("Искомый массив: ");
    
    int length, j = 0, k = 0;
    Console.Write("[");
    while(k < n)
    {
        length = mas[j].Length;
        if(length <= 3)
        {
            Console.Write("\"" + mas[j] + "\"");
            k = n;
        }
        j++;
        k++;
    }
    for(int i = j + 1; j < n; j++)
    {
        length = mas[i].Length;
        if(length <= 3)
        {
            Console.Write(", \"" + mas[i] + "\"");
        }
    }
    Console.WriteLine("]");    
}
//Реализация программы
int n = Greeting();
string [] mas = Filling(n);

Check(n, mas);

Result(n, mas);