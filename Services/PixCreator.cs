using SistemaPagamentoHospitalar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentoHospitalar.Services
{
    public class PixCreator:PagamentoCreator
    {
        public override IPagamento Processamento()
        {
            return new PagamentoPix();
        }
    }
}
