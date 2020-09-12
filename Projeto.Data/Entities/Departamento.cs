﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Entities
{
    public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public List<Funcionario> Funcionarios { get; set; }
    }
}
