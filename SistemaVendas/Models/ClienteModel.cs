using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Utils;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class ClienteModel
    {

        //nome,`cpf_cnpj`,email,senha

        public string Id { get; set; }
        [Required(ErrorMessage = "Informe o Nome do cliente!")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF do Cliente!")]
        public string CpfCnpj { get; set; }
        [Required(ErrorMessage = "Informe o E-Mail do Cliente!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O E-Mail Informado é Inválido")]
        public string Email { get; set; }
        public string Senha { get; set; }

        public List<ClienteModel> ListarTodosClientes()
        {
            List<ClienteModel> lista = new List<ClienteModel>();
            ClienteModel Item;

            DAL objDal = new DAL();

            string sql = "select id, nome,cpf_cnpj,email,senha from cliente order by nome asc ";

            DataTable dt = objDal.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Item = new ClienteModel
                {

                    Id = dt.Rows[i]["id"].ToString(),
                    Nome = dt.Rows[i]["nome"].ToString(),
                    CpfCnpj = dt.Rows[i]["cpf_cnpj"].ToString(),
                    Email = dt.Rows[i]["email"].ToString(),
                    Senha = dt.Rows[i]["senha"].ToString()

                };
                lista.Add(Item);
            }
            return lista;
        }

        public ClienteModel RetornarCliente(int? id)
        {
            ClienteModel Item;
            DAL objDal = new DAL();

            string sql = $"select id, nome,cpf_cnpj,email,senha from cliente where id ='{id}'order by nome asc ";

            DataTable dt = objDal.RetDataTable(sql);

            Item = new ClienteModel
            {
                Id = dt.Rows[0]["id"].ToString(),
                Nome = dt.Rows[0]["nome"].ToString(),
                CpfCnpj = dt.Rows[0]["cpf_cnpj"].ToString(),
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
                sql = $"update cliente set nome =' {Nome}','cpf_cnpj = '{CpfCnpj}','email = '{Email}' where id = ' {Id}'";
            }
            else
            {
                sql = $"insert into cliente (nome,cpf_cnpj,email,senha) values('{Nome}','{CpfCnpj}','{Email}','123456') ";
            }


            objDAL.ExecutarComandoSQL(sql);
        }

        public void Excluir(int id)
        {

            DAL objDAL = new DAL();

            string sql = string.Empty;

            sql = $"delete from cliente where id = ' {id}'";
            objDAL.ExecutarComandoSQL(sql);

        }

    }
}
