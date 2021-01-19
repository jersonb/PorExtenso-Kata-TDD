namespace PorExtenso.Lib
{
    public class Milhares : Base
    {
        protected override string EscreveDescricao(int valor)
        {
            var divizao = valor / 1000;
            var milhar = ObterValor(divizao);

            milhar = milhar.Equals("um") ? "" : milhar;

            var resto = valor % 1000;

            var resultado = resto switch
            {
                0 => $"{milhar} mil",
                var v when v <= 100 => $"{milhar} mil e {ObterValor(resto)}",
                _ => $"{milhar} mil {ObterValor(resto)}"
            };

            return resultado.TrimStart();
        }
    }
}