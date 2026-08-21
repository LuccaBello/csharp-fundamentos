
namespace Exercicio5
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaTotal()
        {
            return Nota1 + Nota2 + Nota3;
        }
    }
}
