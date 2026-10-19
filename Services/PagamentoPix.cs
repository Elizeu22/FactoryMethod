using SistemaPagamentoHospitalar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentoHospitalar.Services
{
    public class PagamentoPix:IPagamento
    {
        public void Processar()
        {
            Console.WriteLine($"Processamento por pix");
        }
    }
}
