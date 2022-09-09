// See https://aka.ms/new-console-template for more information
using CalidadT1;


class Program
{
    static public void Main(String[] args)
    {
        Console.WriteLine(new RomanoGenerator().GetRomano(-1100));
        Console.WriteLine(new RomanoGenerator().GetRomano(35));
        Console.WriteLine(new RomanoGenerator().GetRomano(3));
        Console.WriteLine(new RomanoGenerator().GetRomano(4));
        Console.WriteLine(new RomanoGenerator().GetRomano(1110));
    }
}
