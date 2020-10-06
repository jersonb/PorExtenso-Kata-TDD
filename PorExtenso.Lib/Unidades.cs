namespace PorExtenso.Lib
{
    public class Unidades : Base
    {
        protected override string EscreveDescricao(int valor)
            => new string[]
            { 
                "zero"
                , "um"
                , "dois"
                , "três"
                , "quatro"
                , "cinco"
                , "seis"
                , "sete"
                , "oito"
                , "nove"
                , "dez" 
            }[valor];
    }
}