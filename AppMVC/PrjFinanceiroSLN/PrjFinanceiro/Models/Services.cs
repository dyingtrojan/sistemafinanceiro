namespace PrjFinanceiro.Models
{
    public interface IEmprestimoService
    {
        public decimal CalcularJurosSimples(decimal valor, decimal taxa)
        {
            return valor + (valor * taxa);
        }
    }
    public class Services
    {
    }
}
