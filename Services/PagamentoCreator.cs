using SistemaPagamentoHospitalar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamentoHospitalar.Services
{
    public abstract class PagamentoCreator
    {
        public abstract IPagamento Processamento();

        public void Pagamento()
        {
            var pagar = Processamento();
            pagar.Processar();
        }

    }
}
