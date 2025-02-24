using System.Globalization;
class Conversor
{
    public static float iof = 1.06f;
    public static double Converter(double dolar, double quantia)
    {
        return dolar * quantia * iof;
    }
}
