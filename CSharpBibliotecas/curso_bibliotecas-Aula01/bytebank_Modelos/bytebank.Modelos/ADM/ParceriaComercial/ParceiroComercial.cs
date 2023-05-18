using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoUtil Autenticador = new AutenticacaoUtil();

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Autenticador.ValidarSenha(this.Senha, senha);
        }
    }
}
