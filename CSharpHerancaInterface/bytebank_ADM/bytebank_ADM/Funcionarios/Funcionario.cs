namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }


        public virtual double GetBonificacao()
        {
            return Salario * 0.1;
        }

        public virtual double PremioSemestral()
        {
            return Salario * 0.2;
        }
    }
}
