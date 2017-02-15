namespace Api.Entities
{
    public class Candidato
    {
        public int Id { get; set; }

        public virtual Conhecimento Conhecimento { get; set; }

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

        public string LinkCrud { get; set; }
    }
}
