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
    public partial class FrmRede : Form
    {

        RedeBLL medbll = new RedeBLL();
        RedeDTO meddto = new RedeDTO();
        public FrmRede()
        {
            InitializeComponent();
        }

        private void FrmRede_Load(object sender, EventArgs e)
        {
            dgvRede.DataSource = medbll.Listar();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            meddto.Usuario = txtUsuario.Text;
            meddto.ProdutoComprado = txtProdutoComprado.Text;


            if (txtUsuario.Text != "" || txtProdutoComprado.Text != "")
            {
                medbll.Inserir(meddto);

                MessageBox.Show("Cadastrado com sucesso!", "Lojas Rede  Perfumaria e beleza", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtId.Clear();
                txtUsuario.Clear();
                txtProdutoComprado.Clear();

            }
            else
            {
                MessageBox.Show("Erro, preencha todos os campos!", "Lojas Rede  Perfumaria e beleza", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvRede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvRede.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsuario.Text = dgvRede.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtProdutoComprado.Text = dgvRede.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txtId.Text);
            meddto.Usuario = (txtUsuario.Text);
            meddto.ProdutoComprado = (txtProdutoComprado.Text);

            medbll.Editar(meddto);

            MessageBox.Show("Alterado com sucesso!", "Lojas Rede  Perfumaria e beleza", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtId.Clear();
            txtUsuario.Clear();
            txtProdutoComprado.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txtId.Text);

            medbll.Excluir(meddto);

            MessageBox.Show("Excluido com sucesso!", "Lojas Rede  Perfumaria e beleza", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtId.Clear();
            txtUsuario.Clear();
            txtProdutoComprado.Clear();
        }

    }
}
