using iHelp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHelp.Classes
{
    public class servicos
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Status { get; set; }
        public string Comentarios { get; set; }
        public servicos() { }

        public servicos(int id, string nome, string descricao, double valor, string status, string comentarios)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Status = status;
            Comentarios = comentarios;
        }

        public servicos(string nome, string descricao, double valor, string status, string comentarios)
        {


            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Status = status;
            Comentarios = comentarios;
        }

        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandText = "insert servicos values (0, '" + Nome + "','" + Descricao + "', '" + Valor + "','" + Status + "','" + Comentarios + "'  )";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public List<servicos> Listar()
        {
            List<servicos> lista = new List<servicos>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from usuarios";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new servicos(
                 dr.GetInt32(0),
                 dr.GetString(1),
                 dr.GetString(2),
                 dr.GetDouble(3),
                 dr.GetString(4),
                 dr.GetString(5)

                ));
            }
            return lista;
        }

        public void BuscarPorId(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from servicos where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Descricao = dr.GetString(2);
                Valor = dr.GetDouble(3);
                Status = dr.GetString(4);
                Comentarios = dr.GetString(5);
            }
        }

        public bool Alterar(int id)
        {
            bool alterado = false;
            var cmd = Banco.Abrir();

            cmd.CommandText = $"update servicos set " +
                $"nome = '{Nome}', " +
                $"descricao = '{Descricao}', " +
                $"valor = '{Valor}', " +
                $"status = '{Status}' " +
                $"status = '{Comentarios}' " +
                $"where id = {id}";
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
