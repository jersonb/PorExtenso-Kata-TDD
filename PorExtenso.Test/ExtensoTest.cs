using PorExtenso.Lib;
using Xunit;

namespace PorExtenso.Test
{
    public class ExtensoTest
    {
        [Theory]
        [InlineData(0, "zero")]
        [InlineData(2, "dois")]
        [InlineData(10, "dez")]
        [InlineData(19, "dezenove")]
        [InlineData(20, "vinte")]
        [InlineData(21, "vinte e um")]
        [InlineData(38, "trinta e oito")]
        [InlineData(50, "cinquenta")]
        [InlineData(55, "cinquenta e cinco")]
        [InlineData(99, "noventa e nove")]
        [InlineData(100, "cem")]
        [InlineData(101, "cento e um")]
        [InlineData(109, "cento e nove")]
        [InlineData(119, "cento e dezenove")]
        [InlineData(120, "cento e vinte")]
        [InlineData(500, "quinhentos")]
        [InlineData(999, "novecentos e noventa e nove")]
        [InlineData(1_000, "mil")]
        [InlineData(999_000, "novecentos e noventa e nove mil")]
        [InlineData(900_001, "novecentos mil e um")]
        [InlineData(900_019, "novecentos mil e dezenove")]
        [InlineData(900_020, "novecentos mil e vinte")]
        [InlineData(900_210, "novecentos mil e duzentos e dez")]
        [InlineData(999_851, "novecentos e noventa e nove mil e oitocentos e cinquenta e um")]
        [InlineData(1_000_001, "ainda não estamos preparados para converter 1000001")]
        public void EscreverNumerosCompostosTest(int numero, string porExtenso)
        {
            try
            {
                Extenso extenso = numero;

                Assert.Equal(porExtenso, extenso.ToString());
            }
            catch (System.Exception ex)
            {
                Assert.Equal(porExtenso, ex.Message);
            };

        }
    }
}
