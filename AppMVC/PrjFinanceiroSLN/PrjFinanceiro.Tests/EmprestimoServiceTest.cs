using PrjFinanceiro.Services;
using Xunit;

namespace PrjFinanceiro.Tests
{
    public class EmprestimoServiceTest
    {
        [Fact]
        public void CalcularValorFinal_EmprestimoMilComTaxaDezPorCento_DeveRetornarMilECem()
        {
            // Arrange
            IEmprestimoService service = new EmprestimoService();
            decimal valorEmprestimo = 1000.00m;
            decimal taxaJuros = 0.10m;
            decimal valorEsperado = 1100.00m;

            // Act
            decimal resultado = service.CalcularValorFinal(valorEmprestimo, taxaJuros);

            // Assert
            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void CalcularJurosCompostos_EmprestimoMilTaxaDoisPorCentoDozeMeses_DeveRetornarMilDuzentosESessentaEOitoEVinteQuatro()
        {
            // Arrange
            IEmprestimoService service = new EmprestimoService();
            decimal valor = 1000.00m;
            double taxaMensal = 0.02;
            int meses = 12;
            decimal valorEsperado = 1268.24m;

            // Act
            decimal resultado = service.CalcularJurosCompostos(valor, taxaMensal, meses);

            // Assert (com precisão de 2 casas decimais)
            Assert.Equal(valorEsperado, resultado, 2);
        }
    }
}