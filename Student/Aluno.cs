using System.Globalization;

class Aluno
{
    public string nome;
    public float n1, n2, n3;

    public float NotaFinal()
    {
        return (n1 + n2 + n3) / 3;
    }

    public string Aprovacao(float notaFinal)
    {
        float notaFaltante = 60 - notaFinal;

        if (notaFinal >= 60)
        {
            return "APROVADO";
        }
        else
        {
            return "REPROVADO\nFALTARAM " + notaFaltante.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
        }
    }
}
