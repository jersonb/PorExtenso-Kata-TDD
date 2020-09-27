namespace PorExtenso.Lib
{
    public struct Extenso
    {
        private int Valor { get; }

        private Extenso(int valor)
            => this.Valor = valor;

        /// <summary>
        /// Declare uma variável do tipo Extenso e atribua um valor inteiro
        /// </summary>
        /// <param name="valor"></param>
        public static implicit operator Extenso(int valor)
            => new Extenso(valor);

        public override string ToString()
            => Base.ObterValor(Valor);

    }
}
