void Beep(int hz)
{
    Console.Beep(hz, 200);
}
int[] Octava(int a)
{
    switch (a)
    {
        case 2:
            return new int[] { 130, 138, 146 };
        case 3:
            return new int[] { 261, 277, 293 };
        case 4:
            return new int[] { 523, 554, 587 };
        case 5:
            return new int[] { 1047, 1109, 1175 };
        case 6:
            return new int[] { 2093, 2217, 2349, };
        default:
            return new int[] { 65, 69, 73 };
    }
}
Console.WriteLine("Переключение октав: A,S,D. Звуки: Z,X,C,V,B,N,M");
while (true)
{
    int a = 0;
    ConsoleKeyInfo b = Console.ReadKey(true);
    switch (b.Key)
    {
        case ConsoleKey.A:
            a = 3;
            break;
        case ConsoleKey.S:
            a = 1;
            break;
        case ConsoleKey.D:
            a = 2;
            break;
        default:
            Console.WriteLine("Такая октава не существует. Выбрана октава 1.");
            break;
    }
    int[] octava = Octava(a);
    ConsoleKeyInfo ki = Console.ReadKey(true);
    switch (ki.Key)
    {
        case ConsoleKey.Z:
            Beep(octava[0]);
            break;
        case ConsoleKey.X:
            Beep(octava[1]);
            break;
        case ConsoleKey.C:
            Beep(octava[2]);
            break;
        case ConsoleKey.V:
            Beep(octava[3]);
            break;
        case ConsoleKey.B:
            Beep(octava[4]);
            break;
        case ConsoleKey.N:
            Beep(octava[5]);
            break;
        case ConsoleKey.M:
            Beep(octava[6]);
            break;

        default:
            Console.WriteLine("Нет такой клавиши");
            break;
    }
}