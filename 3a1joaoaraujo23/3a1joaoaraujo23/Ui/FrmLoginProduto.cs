using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using _3a1joaoaraujo23.Code.BLL;
using _3a1joaoaraujo23.Code.DTO; 

namespace _3a1joaoaraujo23.Ui
{
    public partial class FrmLoginProduto : Form
    {
       
        LoginProdutoBLL loginprodutoBBL = new LoginProdutoBLL();
        LoginProdutoDTO loginprodutoDTO = new LoginProdutoDTO();

        public FrmLoginProduto()
        {
            InitializeComponent();
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            //Capturar dados da tela
            loginprodutoDTO.Nome = txtNome.Text;
            loginprodutoDTO.Senha = txtSenha.Text;


            //Chamada do método para verificar o acesso: 
            if (loginprodutoBBL.RealizarLogin(loginprodutoDTO) == true)
            {

                FrmRede frm_rede = new FrmRede();
                frm_rede.ShowDialog();
            }
            else
            {
                //Mensagem de sucesso
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
