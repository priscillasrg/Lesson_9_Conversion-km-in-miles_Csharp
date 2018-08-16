using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Km___Milhas.Modelo
{
    public class Conversor : absPropriedades
    {
        public Conversor(Double numeroKm) : base(numeroKm)
        {
            Executar();
        }

        public override void Executar()
        {
            // 1 km = 0,6214 milhas

            this.numeroKm = numeroKm * 0.6214;
            this.Resposta = ("O valor convertido em milhas é de: \n" + numeroKm.ToString("#0.00"));
        }
    }
}