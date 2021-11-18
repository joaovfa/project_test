using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _3a1joaoaraujo23.Code.DTO; 
using _3a1joaoaraujo23.Code.DAL;
using System.Data;

namespace _3a1joaoaraujo23.Code.BLL
{
    class RedeBLL
    {
        AcessoAoBanco conexao = new AcessoAoBanco();
        string tabela = "compra";

        public void Inserir(RedeDTO medDto)
        {
            string inserir = $"insert into {tabela} values(null,'{medDto.Usuario}','{medDto.ProdutoComprado}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()      
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(RedeDTO meddDto)
        {
            string alterar = $"update {tabela} set usuario = '{meddDto.Usuario}', produtocomprado = '{meddDto.ProdutoComprado}' where id = '{meddDto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(RedeDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
