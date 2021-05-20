using System;
using System.Collections.Generic;

namespace iHelpp
{
    internal class Trabalhador
    {
        public string Nome { get; internal set; }
        public string Email { get; internal set; }
        public string Senha { get; internal set; }
        public string Cep { get; internal set; }
        public string Cpf { get; internal set; }
        public string Celular { get; internal set; }
        public string Telefone { get; internal set; }

        //internal void Inserir()
        //{
         //   throw new NotImplementedException();
        //}

        internal bool Alterar(int v)
        {
            throw new NotImplementedException();
        }

        internal List<Trabalhador> Listar()
        {
            throw new NotImplementedException();
        }
    }
}