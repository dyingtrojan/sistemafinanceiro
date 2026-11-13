using System;

namespace PrjFinanceiro.Services
{
    public class EmprestimoService : IEmprestimoService
    {
        public decimal CalcularValorFinal(decimal valorEmprestimo, decimal taxaJuros)
        {
            return valorEmprestimo + (valorEmprestimo * taxaJuros);
        }

        public decimal CalcularJurosCompostos(decimal valor, double taxaMensal, int meses)
        {
            // M = P * (1 + i)^n
            double montante = (double)valor * Math.Pow((1 + taxaMensal), meses);

            return (decimal)montante;
        }
    }
}