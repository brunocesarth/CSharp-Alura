namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override double PremioSemestral()
        {
            return Salario + base.PremioSemestral();
        }
    }
}
// base me dá acesso ao atributo ou metodo da superclasse(funcionário)