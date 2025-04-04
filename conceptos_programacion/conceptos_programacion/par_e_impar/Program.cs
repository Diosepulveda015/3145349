using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite un numero:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número " + numero + " es par.");
        }
        else
        {
            Console.WriteLine("El número " + numero + " es impar.");
        }
    }
}