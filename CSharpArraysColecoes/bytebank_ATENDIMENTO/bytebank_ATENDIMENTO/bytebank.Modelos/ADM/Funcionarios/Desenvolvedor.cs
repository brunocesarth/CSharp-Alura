﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Modelos.ADM.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000, cpf) { }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double getBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
