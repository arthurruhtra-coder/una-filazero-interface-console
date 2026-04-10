// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        DesenharTela();
        ExecutarLogin();
    }

    static void DesenharTela()
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("         Fila Zero - Login           ");
        Console.WriteLine("=====================================");
    }

    static void ExecutarLogin()
    {
        Console.Write("---USUÁRIO---: ");
        string username = Console.ReadLine() ?? "";

        Console.Write("---SENHA---: ");
        string password = Console.ReadLine() ?? "";

        if (username == "Tuzinn420" && password == "hesoyam123")
        {
            Console.WriteLine("\nLogin bem-sucedido! Bem-vindo, Tuzinn420.");
        }
        else
        {
            Console.WriteLine("\nLogin falhou! Nome de usuário ou senha incorretos.");
        }
    }
}