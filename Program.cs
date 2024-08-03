using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("123456", "Nokia 3310", "111111111111111", 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Smartphone iphone = new Iphone("654321", "iPhone 12", "222222222222222", 64);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}