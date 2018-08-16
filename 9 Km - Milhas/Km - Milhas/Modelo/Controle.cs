using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Km___Milhas.Modelo
{
    public class Controle : absPropriedades
    {
        public Controle(String km) : base(km)
        {
            Executar();
        }

        public override void Executar()
        {
            this.Mensagem = "";

            absPropriedades validacao = new Validacao(this.km);

            if (validacao.Mensagem.Equals(""))
            {
                absPropriedades conversor = new Conversor(validacao.numeroKm);
                this.Resposta = conversor.ToString();
            }
            else
            {
                this.Mensagem = validacao.Mensagem;
            }

        }
    }
}
