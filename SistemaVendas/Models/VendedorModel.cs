using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Utils;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class VendedorModel
    {

        public string Id { get; set; }
        [Required(ErrorMessage = "Informe o Nome do Vendedor!")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o E-Mail do Vendedor!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O E-Mail Informado é Inválido")]
        public string Email { get; set; }
        public string Senha { get; set; }

        public List<VendedorModel> ListarTodosVendedores()
        {
            List<VendedorModel> lista = new List<VendedorModel>();
            VendedorModel Item;

            DAL objDal = new DAL();

            string sql = "select id, nome,email,senha from vendedor order by nome asc ";

            DataTable dt = objDal.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Item = new VendedorModel
                {

                    Id = dt.Rows[i]["id"].ToString(),
                    Nome = dt.Rows[i]["nome"].ToString(),
                    Email = dt.Rows[i]["email"].ToString(),
                    Senha = dt.Rows[i]["senha"].ToString()

                };
                lista.Add(Item);
            }
            return lista;
        }

        public VendedorModel RetornarVendedor(int? id)
        {
            VendedorModel Item;
            DAL objDal = new DAL();

            string sql = $"select id, nome, email,senha from vendedor where id ='{id}'order by nome asc ";

            DataTable dt = objDal.RetDataTable(sql);

            Item = new VendedorModel
            {
                Id = dt.Rows[0]["id"].ToString(),
                Nome = dt.Rows[0]["nome"].ToString(),
                Email = dt.Rows[0]["email"].ToString(),
                Senha = dt.Rows[0]["senha"].ToString()

            };


            return Item;
        }

        public void Gravar()
        {
            DAL objDAL = new DAL();

            string sql = string.Empty;

            if (Id != null)
            {
                sql = $"update vendedor set nome =' {Nome}',email = '{Email}' where id = ' {Id}'";
            }
            else
            {
                sql = $"insert into vendedor (nome,email,senha) values('{Nome}','{Email}','123456') ";

            }


            objDAL.ExecutarComandoSQL(sql);
        }

        public void Excluir(int id)
        {

            DAL objDAL = new DAL();

            string sql = string.Empty;

            sql = $"delete from vendedor where id = ' {id}'";
            objDAL.ExecutarComandoSQL(sql);

        }

    }
}
