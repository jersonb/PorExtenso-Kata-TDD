using System.Collections.Generic;

namespace PorExtenso.Lib
{
    public class Centenas:Base
    {        private string ObterCentena(int valor)
            => new Dictionary<int, string>
            {
                { 100, "cento"},
                { 200, "duzentos"},
                { 300, "trezentos"},
                { 400, "quatrocentos"},
                { 500, "quinhentos"},
                { 600, "seiscentos"},
                { 700, "setecentos"},
                { 800, "oitocentos"},
                { 900, "novecentos"},
                { 1000, "mil"}
            }[valor];

        protected override string EscreveDescricao(int valor)
        {
            var divizao = (valor / 100) * 100;
            var centena = ObterCentena(divizao);
            valor -= divizao;

            if (valor.Equals(0))
            {
                return $"{centena}";
            }
            
            return $"{centena} e {ObterValor(valor)}";
        }
    }
}