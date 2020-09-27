using System.Collections.Generic;

namespace PorExtenso.Lib
{
    public class Unidades : Base
    {
        protected override string EscreveDescricao(int valor)
            => new Dictionary<int, string>
            {
                {0, "zero" },
                {  1, "um"},
                {  2, "dois"},
                {  3, "três"},
                {  4, "quatro"},
                {  5, "cinco"},
                {  6, "seis"},
                {  7, "sete"},
                {  8, "oito"},
                {  9, "nove"},
                { 10, "dez"}
            }[valor];
    }
}