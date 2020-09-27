namespace PorExtenso.Lib
{
    public abstract class Base
    {
        protected abstract string EscreveDescricao(int valor);
        
        private static string ObterValor<T>(int valor) where T: Base, new()
            => new T().EscreveDescricao(valor);

         public static string ObterValor(int valor)
            => valor switch
            {
                var n when n <= 10 =>  ObterValor<Unidades>(valor),
                var n when n <= 100 => ObterValor<Dezenas>(valor),
                var n when n <= 1_000 => ObterValor<Centenas>(valor),
                var n when n < 1_000_000 => ObterValor<Milhares>(valor),
                var n when n.Equals( 1_000_000) => "um milhão",
                _ => throw new System.InvalidOperationException($"ainda não estamos preparados para converter {valor}")
            };
    }
}