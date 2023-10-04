//Используемые функции
int Greeting()
{
    Console.Write("Введите размер массива: ");

    int size = Convert.ToInt32(Console.ReadLine());

    return size;
}
string [] Filling(int size)
{
    Console.Write("Введите ваш массив: ");

    string [] mas = new string [size];
    for(int i = 0; i < size; i++)
    {
        mas[i] = Console.ReadLine();
    }

    return mas;
}
void Check(int size, string[] mas)
{
    Console.WriteLine("Введенный вами массив: ");

    Console.Write("[\"" + mas[0]);
    for(int i = 1; i < size; i++)
    {
        Console.Write("\", \"" + mas[i]);
    }
    Console.WriteLine("\"]");
}
void Result(int size, string[] mas)
{
    Console.WriteLine("Искомый массив: ");
    
    int length;
    Console.Write("[");
    for(int i = 0; i < size; i++)
    {
        length = mas[i].Length;
        if(length <= 3)
        {
            Console.Write("\"" + mas[i] + "\"");
        }
    }
    Console.WriteLine("]");    
}
//Реализация программы
int size = Greeting();
string [] mas = Filling(size);

Check(size, mas);

Result(size, mas);