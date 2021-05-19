using iHelp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHelp.classes
{
    public class categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public categoria() { }

        public categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;

        }
        public categoria(string nome)
        {
            Nome = nome;

        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "insert categoria values (0, '" + Nome + "'));";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        internal static object ObterCategoria()
        {
            throw new NotImplementedException();
        }

        public List<categoria> Listar()
        {
            List<categoria> lista = new List<categoria>();

            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from categoria";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new categoria(
                   dr.GetInt32(0),
                   dr.GetString(1)

                ));
            }
            return lista;
        }

        public void BuscarPorId(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from categoria where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);


            }

        }
        public bool Alterar(int id)
        {
            bool alterado = false;
            var cmd = Banco.Abrir();
            cmd.CommandText = "update categoria " +
                "set nome = '" + Nome + "'," +

                "where id = " + id;
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