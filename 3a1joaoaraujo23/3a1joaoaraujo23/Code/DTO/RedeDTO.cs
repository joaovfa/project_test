using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3a1joaoaraujo23.Code.DTO
{
    class RedeDTO
    {
        private int _id;
        private string _usuario;
        private string _produtocomprado;

        public int Id { get => _id; set => _id = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string ProdutoComprado { get => _produtocomprado; set => _produtocomprado = value; }
    }
}
