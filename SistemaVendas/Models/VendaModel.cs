using Newtonsoft.Json;
using SistemaVendas.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    public class VendaModel
    {

        public string Id { get; set; }
        public string Cliente_Id { get; set; }

        public string Data { get; set; }
        public string Vendedor_Id { get; set; }
        public string Produto_Id { get; set; }
        public double Total { get; set; }

        public string ListaProdutos { get; set; }

        public List<VendaModel> ListagemVendas()
        {

            return null;

        }



        public List<ClienteModel> RetornarListaClientes()
        {
            return new ClienteModel().ListarTodosClientes();
        }

        public List<VendedorModel> RetornarListaVendedores()
        {
            return new VendedorModel().ListarTodosVendedores();
        }

        public List<ProdutoModel> RetornarListaProdutos()
        {
            return new ProdutoModel().ListarTodosProdutos();
        }

        public void Inserir()
        {
            DAL objDAL = new DAL();

            string dataVenda = DateTime.Now.ToString("yyyy/MM/dd");


            string sql = $"insert into venda (data, total, vendedor_id, cliente_id) " +
                        $"values ('{dataVenda}',{Total.ToString().Replace(",", ".")},{Vendedor_Id},{Cliente_Id} ) ";

            objDAL.ExecutarComandoSQL(sql);

            sql = $"select id from venda where data='{dataVenda}' and vendedor_id={Vendedor_Id} and cliente_id={Cliente_Id} order by id desc limit 1";

            DataTable dt = objDAL.RetDataTable(sql);

            string idVenda = dt.Rows[0]["id"].ToString();

            //Deserializar  o Json da lista de produtos selecionados e grava-los na tabela itens-venda

            List<ItemVendaModel> lista_produtos = JsonConvert.DeserializeObject<List<ItemVendaModel>>(ListaProdutos);

            for (int i = 0; i < lista_produtos.Count; i++)
            {
                sql = "insert into itens_venda(venda_id, produto_id, qtde_produto, preco_produto) " +
                      $"values({idVenda}, {lista_produtos[i].CodigoProduto.ToString()}," +
                      $"{lista_produtos[i].QtdeProduto.ToString()}," +
                      $"{lista_produtos[i].PrecoUnitario.ToString().Replace(",", ".")} ) ";


                objDAL.ExecutarComandoSQL(sql);
            }
        }
    }
}
