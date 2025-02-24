using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Funcionario f = new Funcionario();
            f.nome = "Joao Silva";
            f.salarioBruto = 6000;
            f.imposto = 1000;

            Console.WriteLine($"Funcionário: {f.nome}, $" + f.SalarioLiquido());
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            var porcentagem = int.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);
            Console.WriteLine($"Dados atualizados: {f.nome}, $" + f.SalarioLiquido());
        }
    }
}
