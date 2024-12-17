using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double nota1, nota2, media;

        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        media = (nota1 + nota2) / 2;

        Console.WriteLine("A sua media final é " + media.ToString("f1") + " Parabéns!");

        if (media < 60.00)
        {
            Console.WriteLine("REPROVADO!");
        }
    }
}