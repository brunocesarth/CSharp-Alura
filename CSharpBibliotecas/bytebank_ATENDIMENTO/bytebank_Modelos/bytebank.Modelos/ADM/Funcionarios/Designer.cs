namespace bytebank.Modelos.ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf) { }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double getBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
