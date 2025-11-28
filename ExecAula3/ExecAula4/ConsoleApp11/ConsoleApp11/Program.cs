using System;

public class Aluno
{
    public string Nome = "Guga";
    public double Nota;

    public void Exibir()
    {
        Console.WriteLine($"Aluno: {Nome}, Nota: {Nota}");
    }
}

public class Program
{
    public static void Main()
    {
        Aluno a = new Aluno();
        a.Nome = "Carlos"; // //
        a.Nota = 8.5;
        a.Exibir();
    }
}