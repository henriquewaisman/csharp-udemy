using System.Globalization;
using System.Runtime.Intrinsics.Arm;
class Program
{
    static int conta_id = 1;
    static List<ContaBancaria> contas = new List<ContaBancaria>();
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("MENU");
        Console.WriteLine("1 - Cadastrar Conta");
        Console.WriteLine("2 - Depositar na Conta");
        Console.WriteLine("3 - Sacar na Conta");
        Console.WriteLine("4 - Detalhes da Conta");
        Console.WriteLine("0 - Encerrar Aplicativo");
        var op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1: CadastrarConta(); break;
            case 2: Depositar(); break;
            case 3: Sacar(); break;
            case 4: DetalhesDaConta(); break;
            case 0: break;
            default: Menu(); break;
        }
    }
    public static void CadastrarConta()
    {
        Console.Clear();
        Console.WriteLine("Cadastrar Conta\n");
        Console.Write("Insira o nome do titular: ");
        string titular_cadastrado = Console.ReadLine();
        Console.WriteLine("\nDeseja fazer um depósito inicial? ('sim' ou 'nao')");
        var op = Console.ReadLine();
        if (op == "sim")
        {
            Console.Write("Digite o valor do depósito: ");
            var deposito_inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contas.Add(new ContaBancaria(conta_id, titular_cadastrado, deposito_inicial));
            Console.WriteLine($"Número da Conta: {contas[conta_id - 1].Numero_Conta}\n" +
            $"Titular: {contas[conta_id - 1].Titular}\nSaldo: {contas[conta_id - 1].Saldo}\n");
            conta_id++;
            Console.WriteLine("Digite uma tecla para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }
        else if (op == "nao")
        {
            contas.Add(new ContaBancaria(conta_id, titular_cadastrado));
            Console.WriteLine($"Número da Conta: {contas[conta_id - 1].Numero_Conta}" +
            $"\nTitular: {contas[conta_id - 1].Titular}\nSaldo: {contas[conta_id - 1].Saldo}\n");
            conta_id++;
            Console.WriteLine("Digite uma tecla para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }
        else
        {
            Console.WriteLine("Digite uma opção válida! ('sim' ou 'nao')\n" +
            "\nPressione qualquer tecla para voltar ao Menu.");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }

    public static void Depositar()
    {
        Console.Clear();
        Console.WriteLine("Depósito");
        Console.Write("Digite o id da conta: ");
        int id_digitado = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantia a ser depositada: ");
        double quantia_deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        contas[id_digitado - 1].Deposito(quantia_deposito);
        Console.WriteLine($"Número da Conta: {contas[id_digitado - 1].Numero_Conta}\n" +
            $"Titular: {contas[id_digitado - 1].Titular}\nSaldo: {contas[id_digitado - 1].Saldo}\n");
        Console.WriteLine("\nDigite uma tecla para voltar ao Menu.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    public static void Sacar()
    {
        Console.Clear();
        Console.WriteLine("Saque");
        Console.Write("Digite o id da Conta: ");
        int id_digitado = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantia a ser sacada: ");
        double quantia_saque = double.Parse(Console.ReadLine());
        contas[id_digitado - 1].Saque(quantia_saque);
        Console.WriteLine($"Número da Conta: {contas[id_digitado - 1].Numero_Conta}\n" +
            $"Titular: {contas[id_digitado - 1].Titular}\nSaldo: {contas[id_digitado - 1].Saldo}\n");
        Console.WriteLine("\nDigite uma tecla para voltar ao Menu.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    public static void DetalhesDaConta()
    {
        Console.Clear();
        Console.WriteLine("DETALHES DA CONTA");
        Console.Write("Digite o id da conta: ");
        int id_digitado = int.Parse(Console.ReadLine());
        Console.WriteLine($"Id: {contas[id_digitado - 1].Numero_Conta}\nTitular: {contas[id_digitado - 1].Titular}" +
        $"\nSaldo: {contas[id_digitado - 1].Saldo}\n");
        Console.WriteLine("Digite qualquer tecla para voltar ao Menu.");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}
