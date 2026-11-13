namespace PrjFinanceiro.Services
{
    public interface IEmprestimoService
    {
        decimal CalcularValorFinal(decimal valorEmprestimo, decimal taxaJuros);
        decimal CalcularJurosCompostos(decimal valor, double taxaMensal, int meses);
    }
}