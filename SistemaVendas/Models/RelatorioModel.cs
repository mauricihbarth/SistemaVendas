﻿using SistemaVendas.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    public class RelatorioModel
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataDe { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAte { get; set; }
    }

    public class GraficoProdutos
    {
        public double QtdeVendido { get; set; }
        public int CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }

        public List<GraficoProdutos> RetornarGrafico()
        {
            DAL objDAL = new DAL();
            string sql = "select sum(qtde_produto) as qtde, p.nome as produto from itens_venda i inner join produto p on i.produto_id = p.id group by p.nome";
            DataTable dt = objDAL.RetDataTable(sql);

            List<GraficoProdutos> lista = new List<GraficoProdutos>();
            GraficoProdutos item;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new GraficoProdutos();
                item.QtdeVendido = double.Parse(dt.Rows[i]["qtde"].ToString());
                item.DescricaoProduto = dt.Rows[i]["produto"].ToString();
                lista.Add(item);
            }
            return lista;
        }
    }
}
