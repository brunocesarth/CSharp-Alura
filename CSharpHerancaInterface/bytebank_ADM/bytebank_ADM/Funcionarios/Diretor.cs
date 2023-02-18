using System;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public string Senha { get; set; }
        public Diretor(string cpf) : base(cpf, 5000) { }
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
// base me dá acesso ao atributo ou metodo da superclasse(funcionário)