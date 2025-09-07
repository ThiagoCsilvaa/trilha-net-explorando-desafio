namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a suíte está cadastrada e se a capacidade é suficiente
            if (Suite == null)
            {
                throw new InvalidOperationException("Suite não cadastrada para a reserva.");
            }

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes cadastrados
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Verifica se Suite está definida
            if (Suite == null)
            {
                throw new InvalidOperationException("Suite não cadastrada para a reserva.");
            }

            // Cálculo: DiasReservados * ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: se dias reservados >= 10, aplicar 10% de desconto
            if (DiasReservados >= 10)
            {
                valor *= 0.9M; // 10% de desconto
            }

            return valor;
        }
    }
}
