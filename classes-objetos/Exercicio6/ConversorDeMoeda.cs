namespace Exercicio6
{
    class ConversorDeMoeda
    {
        public static double IOF = 1.06;

        public static double Total (double dolar, double cotacao)
        {
            return dolar * cotacao * IOF;
        }
    }
}
