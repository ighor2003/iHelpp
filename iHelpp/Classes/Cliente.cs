using iHelp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHelp.Classes
{
    public class cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public double Nivel { get; set; }
        public cliente() { }

        public cliente(int id, string nome, string senha, string email, double nivel)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Email = email;
            Nivel = nivel;
        }
        public cliente(string nome, string senha, string email, double nivel)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
            Nivel = nivel;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"insert cliente values (" + $"0, '{Nome}', '{Senha}', '{Email}', '{Nivel}');";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
        }

        public List<cliente> Listar()
        {
            List<cliente> lista = new List<cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from cliente";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new cliente(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDouble(4)
                ));
            }
        }
        public void BuscarPorId(int id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "select * from cliente where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Senha = dr.GetString(2);
                Email = dr.GetString(3);
                Nivel = dr.GetDouble(4);


            }

        }
        public bool Alterar(int id)
        {
            bool alterado = false;

            var cmd = Banco.Abrir();

            cmd.CommandText = $"update cliente set descricao =  nome = '{Nome}', senha = '{Senha}', email = '{Email}' where id = {id};";
            try
            {
                cmd.ExecuteNonQuery();
                alterado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return alterado;
        }
    }
}