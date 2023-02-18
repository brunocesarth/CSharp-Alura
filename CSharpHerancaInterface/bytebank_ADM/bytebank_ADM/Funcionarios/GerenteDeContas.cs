using System;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public string Senha { get; set; }
        public GerenteDeContas(string cpf) : base(cpf, 4000) { }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
