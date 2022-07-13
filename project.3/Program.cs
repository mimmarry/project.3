using System;
class Programm
{
    static void Main(string[] args)
    {
        double UsdToRub = 66.65;
        double UsdToUah = 32.15;
        double USD;

        Console.WriteLine("Введите сумму в USD ");

        USD = double.Parse(Console.ReadLine());

        Console.WriteLine( USD +" USD in Rub = " + USD * UsdToRub);
        Console.WriteLine( USD + " USD in Uah = " + USD * UsdToUah);

    }
}