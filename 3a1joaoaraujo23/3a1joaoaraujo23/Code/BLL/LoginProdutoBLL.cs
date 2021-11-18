using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//Importação da camada de negócio e da camada de acesso a dados
using _3a1joaoaraujo23.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using _3a1joaoaraujo23.Code.DAL; //nomeProjeto.nomeDaPasta.nomeDaPasta

namespace _3a1joaoaraujo23.Code.BLL
{
    class LoginProdutoBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoAoBanco conexao = new AcessoAoBanco();
        string tabela = "loginproduto";

        public bool RealizarLogin(LoginProdutoDTO login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where nome='{login.Nome}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }
}
