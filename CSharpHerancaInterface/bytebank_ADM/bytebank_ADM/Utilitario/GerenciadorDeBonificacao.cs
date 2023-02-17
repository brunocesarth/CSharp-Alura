using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public double TotalPremioSemestral { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            TotalDeBonificacao += funcionario.GetBonificacao();
        }

        public void RegistraPremio(Funcionario funcionario)
        {
            TotalPremioSemestral += funcionario.PremioSemestral();
        }
    }
}
