using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Km___Milhas.Modelo
{
    public class Validacao : absPropriedades
    {
        public Validacao(String km) : base(km)
        {
            Executar();
        }

        public override void Executar()
        {
            this.Mensagem = "";
            try
            {
                this.numeroKm = Convert.ToDouble(this.km);
            }
            catch (FormatException e)
            {
                this.Mensagem = "Erro de conversão";
            }
        }
    }
}
