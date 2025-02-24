public class Funcionario
{
    public string nome;
    public double salarioBruto;
    public double imposto;

    public double SalarioLiquido()
    {
        return salarioBruto - imposto;
    }

    public void AumentarSalario(double porcentagem)
    {
        salarioBruto = salarioBruto + (salarioBruto * (porcentagem / 100));
    }
}
