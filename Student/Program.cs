using System;
class Program
{
    static void Main(string[] args)
    {
        Aluno a = new Aluno();
        a.nome = "Alex Green";
        Console.WriteLine("Digite as três notas do aluno:");
        a.n1 = float.Parse(Console.ReadLine());
        a.n2 = float.Parse(Console.ReadLine());
        a.n3 = float.Parse(Console.ReadLine());

        var notaFinal = a.NotaFinal();

        Console.WriteLine("NOTA FINAL = " + notaFinal);

        Console.WriteLine(a.Aprovacao(notaFinal));
    }
}
