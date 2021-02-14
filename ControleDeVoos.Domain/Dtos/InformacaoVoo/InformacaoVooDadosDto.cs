using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeVoos.Domain.Dtos.InformacaoVoo
{
    public class InformacaoVooDadosDto: BaseDto
    {
        public string Matricula { get; set; }

        public string Aeronave { get; set; }

        public DateTime DataVoo { get; set; }

        public TimeSpan HoraVoo { get; set; }

        public string Origem { get; set; }

        public string Destino { get; set; }
    }
}
