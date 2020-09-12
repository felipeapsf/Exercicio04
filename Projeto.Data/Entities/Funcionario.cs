﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Entities
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public int IdCargo { get; set; }
        public int IdDepartamento { get; set; }

        public Cargo Cargo { get; set; }
        public Departamento Departamento { get; set; }
    }
}
