using System.Collections.Generic;

namespace PorExtenso.Lib
{
    public class Dezenas : Base
    {
        public string ObterDezDezenove(int valor)
           => new Dictionary<int, string>
               {
                    { 11, "onze"},
                    { 12, "doze"},
                    { 13, "treze"},
                    { 14, "quatorze"},
                    { 15, "quinze"},
                    { 16, "dezeseis"},
                    { 17, "dezesete"},
                    { 18, "dezoito"},
                    { 19, "dezenove"}
               }[valor];

        private string ObterDezenas(int valor)
            => new Dictionary<int, string>
            {
                { 20, "vinte"},
                { 30, "trinta"},
                { 40, "quarenta"},
                { 50, "cinquenta"},
                { 60, "sessenta"},
                { 70, "setenta"},
                { 80, "oitenta"},
                { 90, "noventa"},
                { 100, "cem"}
            }[valor];

        protected override string EscreveDescricao(int valor)
        {
            if (valor < 20)
            {
                return ObterDezDezenove(valor);
            }

            var divisao = (valor / 10) * 10;

            var dezena = ObterDezenas(divisao);

            var resto = valor % 10;

            if (resto.Equals(0))
            {
                return dezena;
            }

            return $"{dezena} e {ObterValor(resto)}";
        }

    }
}