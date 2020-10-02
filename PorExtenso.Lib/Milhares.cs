namespace PorExtenso.Lib
{
    public class Milhares : Base
    {
        protected override string EscreveDescricao(int valor)
        {
            var divizao = valor / 1000;
            var milhar = ObterValor(divizao);

            var resto = valor % 1000;
            if (resto.Equals(0))
            {
                return $"{milhar} mil";
            }

            if (resto <= 100)
            {
                return $"{milhar} mil e {ObterValor(resto)}";
            }
            return $"{milhar} mil {ObterValor(resto)}";
        }
    }
}