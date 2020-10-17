using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Utils;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class ProdutoModel
    {

        public string Id { get; set; }
        [Required(ErrorMessage = "Informe o Nome do Produto!")]

        public string Nome { get; set; }
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o Perço Unitário do Produto!")]

        public decimal? Preco_Unitario { get; set; }

        [Required(ErrorMessage = "Informe a Quantidade de Estoque do Produto!")]

        public decimal? Quantidade_Estoque { get; set; }

        [Required(ErrorMessage = "Informe a Unidade de Medida do Produto!")]

        public string Unidade_Medida { get; set; }

        [Required(ErrorMessage = "Informe o Link da Imagem do Produto!")]

        public string Link_Foto { get; set; }

        public List<ProdutoModel> ListarTodosProdutos()
        {
            List<ProdutoModel> lista = new List<ProdutoModel>();
            ProdutoModel Item;

            DAL objDal = new DAL();

            string sql = "select id, nome,descricao, preco_unitario, quantidade_estoque, unidade_medida, link_foto from produto order by nome asc ";

            DataTable dt = objDal.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Item = new ProdutoModel
                {

                    Id = dt.Rows[i]["id"].ToString(),
                    Nome = dt.Rows[i]["nome"].ToString(),
                    Descricao = dt.Rows[i]["descricao"].ToString(),
                    Preco_Unitario = decimal.Parse(dt.Rows[i]["preco_unitario"].ToString()),
                    Quantidade_Estoque = decimal.Parse(dt.Rows[i]["quantidade_estoque"].ToString()),
                    Unidade_Medida = dt.Rows[i]["unidade_medida"].ToString(),
                    Link_Foto = dt.Rows[i]["link_foto"].ToString(),                   

                };
                lista.Add(Item);
            }
            return lista;
        }

        public ProdutoModel RetornarProduto(int? id)
        {
            ProdutoModel Item;
            DAL objDal = new DAL();

            string sql = $"select id, nome, descricao, preco_unitario, quantidade_estoque, unidade_medida, link_foto from produto where id ='{id}'order by nome asc ";

            DataTable dt = objDal.RetDataTable(sql);

            Item = new ProdutoModel
            {
                Id = dt.Rows[0]["id"].ToString(),
                Nome = dt.Rows[0]["nome"].ToString(),
                Descricao = dt.Rows[0]["descricao"].ToString(),
                Preco_Unitario = decimal.Parse(dt.Rows[0]["preco_unitario"].ToString()),
                Quantidade_Estoque = decimal.Parse(dt.Rows[0]["quantidade_estoque"].ToString()),
                Unidade_Medida = dt.Rows[0]["unidade_medida"].ToString(),
                Link_Foto = dt.Rows[0]["link_foto"].ToString(),
            };


            return Item;
        }

        public void Gravar()
        {
            DAL objDAL = new DAL();

            string sql = string.Empty;

            if (Id != null)
            {
                sql = $"update produto set " +
                      $"nome =' {Nome}'," +
                      $"descricao = '{Descricao}'," +
                      $"preco_unitario = '{Preco_Unitario.ToString().Replace(",",".")}'," +
                      $"quantidade_estoque = '{ Quantidade_Estoque.ToString().Replace(",", ".")}'," +
                      $"unidade_medida = '{Unidade_Medida}'," +
                      $"link_foto = '{Link_Foto}'" +
                      $"where id = ' {Id}'";
            }
            else
            {
                sql = $"insert into produto (nome," +
                    $"descricao," +
                    $"preco_unitario, " +
                    $"quantidade_estoque, " +
                    $"unidade_medida, " +
                    $"link_foto) " +
                    $"values('{Nome}'," +
                    $"'{Descricao}'," +
                    $"'{Preco_Unitario.ToString().Replace(",", ".")}'," +
                    $"'{Quantidade_Estoque}'," +
                    $"'{Unidade_Medida}'," +
                    $"'{Link_Foto}') ";
                
               // sql = $"insert into cliente (nome,cpf_cnpj,email,senha) values('{Nome}','{CpfCnpj}','{Email}','123456') ";

            }


            objDAL.ExecutarComandoSQL(sql);
        }

        public void Excluir(int id)
        {

            DAL objDAL = new DAL();

            string sql = string.Empty;

            sql = $"delete from produto where id = ' {id}'";
            objDAL.ExecutarComandoSQL(sql);

        }

    }
}
