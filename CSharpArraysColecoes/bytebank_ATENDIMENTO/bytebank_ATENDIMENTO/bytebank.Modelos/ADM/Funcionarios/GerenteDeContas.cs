namespace bytebank.Modelos.ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(4000, cpf) { }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double getBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
