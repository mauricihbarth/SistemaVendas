using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SistemaVendas.Utils;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class LoginModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage="Informe o e-mail do usuário!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="O e-mail informado é inválido")]
        public string Email { get; set; }        
        public string Senha { get; set; }


        //Existe um problema grave de segurança com essa abordagem - SQL INJECTION
        public bool ValidarLogin()
        {           
            string sql = $"SELECT ID, NOME FROM VENDEDOR WHERE EMAIL = '{Email}' AND SENHA = '{Senha}'";
            DAL objDal = new DAL();
            DataTable dt = objDal.RetDataTable(sql);

            if (dt.Rows.Count == 1)
            {
                Id = dt.Rows[0]["ID"].ToString();
                Nome = dt.Rows[0]["NOME"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
