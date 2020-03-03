using System;
using System.Collection.Generic;
using Reositorio;

namespace Models {
    public class Funcionario {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string CPF {  get; set; }

        public Funcionario (int id, string nome, string CPF ) {

            ID = id;
            Nome = nome;
            Cpf = cpf;

            RepositoRyCliente.AddFuncionario (this);

        }

    }

}