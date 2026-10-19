using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPagamentoHospitalar.Interface;

namespace SistemaPagamentoHospitalar.Services
{
    public class BoletoCreator:PagamentoCreator
    {
        public override IPagamento Processamento()
        {
            return new PagamentoBoleto();
        }

    }
}
