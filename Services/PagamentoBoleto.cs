using SistemaPagamentoHospitalar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPagamentoHospitalar.Interface;

namespace SistemaPagamentoHospitalar.Services
{
    public class PagamentoBoleto:IPagamento
    {
        public void Processar()
        {
            Console.WriteLine($"Processamento por boleto");
        }
    }
}
