using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class Candidato
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Whatsapp { get; set; }

        public string Linkedin { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Portfolio { get; set; }

        public bool HorasAteQuatro { get; set; }

        public bool HorasQuatroASeis { get; set; }

        public bool HorasSeisAOito { get; set; }

        public bool HorasAcimaDeOito { get; set; }

        public bool HorasFimDeSemana { get; set; }

        public bool PeriodoManha { get; set; }

        public bool PeriodoTarde { get; set; }

        public bool PeriodoNoite { get; set; }

        public bool PeriodoMadrugada { get; set; }

        public bool PeriodoComercial { get; set; }

        public int Pretensao { get; set; }

        public string Banco { get; set; }

        public string BancoBeneficiario { get; set; }

        public string BancoCpf { get; set; }

        public string BancoNome { get; set; }

        public string BancoAgencia { get; set; }

        public bool BancoContaCorrente { get; set; }

        public bool BancoContaPoupanca { get; set; }

        public string BancoConta { get; set; }

        public int ConhecimentoIonic { get; set; }

        public int ConhecimentoAndroid { get; set; }

        public int ConhecimentoIos { get; set; }

        public int? ConhecimentoHtml { get; set; }

        public int? ConhecimentoCss { get; set; }

        public int ConhecimentoBootstrap { get; set; }

        public int ConhecimentoJquery { get; set; }

        public int ConhecimentoAngular { get; set; }

        public int? ConhecimentoJava { get; set; }

        public int ConhecimentoAsp { get; set; }

        public int? ConhecimentoC { get; set; }

        public int? ConhecimentoCplusplus { get; set; }

        public int? ConhecimentoCake { get; set; }

        public int? ConhecimentoDjango { get; set; }

        public int? ConhecimentoMagento { get; set; }

        public int ConhecimentoPhp { get; set; }

        public int ConhecimentoWordpress { get; set; }

        public int? ConhecimentoPython { get; set; }

        public int? ConhecimentoRuby { get; set; }

        public int? ConhecimentoSqlServer { get; set; }

        public int? ConhecimentoMySql { get; set; }

        public int? ConhecimentoSalesforce { get; set; }

        public int? ConhecimentoPhotoshop { get; set; }

        public int? ConhecimentoIllustrator { get; set; }

        public int? ConhecimentoSeo { get; set; }

        public string ConhecimentoOutros { get; set; }

        public string LinkCrud { get; set; }
    }
}
