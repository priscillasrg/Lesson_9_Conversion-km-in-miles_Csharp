using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Km___Milhas.Modelo
{
    public abstract class absPropriedades: intMetodos
    {
        private String mensagem;
        private String resposta;
        public String km;
        public Double numeroKm;

        public string Resposta { get => resposta; set => resposta = value; }
        public string Mensagem { get => mensagem; set => mensagem = value; }

        public absPropriedades(String km)
        {
            this.km = km;
        }

        public absPropriedades(Double numeroKm)
        {
            this.numeroKm = numeroKm;
        }

        public virtual void Executar()
        {
        }

        public override string ToString()
        {
            return this.Resposta;
        }
    }
}
