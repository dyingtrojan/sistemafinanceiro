namespace PrjFinanceiro.Models
{
    public interface IEmprestimoService
    {
        public decimal CalcularJurosSimples (decimal valor, double taxa)
        {
            return valor + (valor * taxa);
        }
    }
}
