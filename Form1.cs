using System;
using System.Windows.Forms;

namespace Hash
{
    public partial class Form1 : Form
    {
        SondagemLinear linear = new SondagemLinear(29);
        SondagemQuadratica quad = new SondagemQuadratica(29);
        HashingDuplo duplo = new HashingDuplo(29);

        byte tipo = 1;

        public Form1()
        {
            InitializeComponent();
            AtualizarDgv();
        }

        private void AtualizarDgv()
        {
            if (tipo == 1)
            {
                dgvAluno.Rows.Clear();
                dgvAluno.RowCount = linear.GetTamanho();
                for (int i = 0; i < linear.GetTamanho(); i++)
                {
                    if (linear.GetValor(i) != null)
                    {
                        dgvAluno[0, i].Value = i.ToString();
                        dgvAluno[1, i].Value = linear.GetValor(i).GetRa();
                        dgvAluno[2, i].Value = linear.GetValor(i).GetNome();
                    }
                    else
                        dgvAluno[0, i].Value = i.ToString();

                }
            }
            else if (tipo == 2)
            {
                dgvAluno.Rows.Clear();
                dgvAluno.RowCount = quad.GetTamanho();
                for (int i = 0; i < quad.GetTamanho(); i++)
                {
                    if (quad.GetValor(i) != null)
                    {
                        dgvAluno[0, i].Value = i.ToString();
                        dgvAluno[1, i].Value = quad.GetValor(i).GetRa();
                        dgvAluno[2, i].Value = quad.GetValor(i).GetNome();
                    }
                    else
                        dgvAluno[0, i].Value = i.ToString();

                }
            }
            else if (tipo == 3)
            {
                dgvAluno.Rows.Clear();
                dgvAluno.RowCount = duplo.GetTamanho();
                for (int i = 0; i < duplo.GetTamanho(); i++)
                {
                    if (duplo.GetValor(i) != null)
                    {
                        dgvAluno[0, i].Value = i.ToString();
                        dgvAluno[1, i].Value = duplo.GetValor(i).GetRa();
                        dgvAluno[2, i].Value = duplo.GetValor(i).GetNome();
                    }
                    else
                        dgvAluno[0, i].Value = i.ToString();

                }
            }
            else
                MessageBox.Show("Selecione um tipo de endereçamento.");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int x;
            if (Int32.TryParse(txtRA.Text, out x) && txtNome.Text != "")
            {
                switch (tipo)
                {
                    case 1: linear.Adicionar(new Aluno(txtRA.Text, txtNome.Text)); break;
                    case 2: quad.Adicionar(new Aluno(txtRA.Text, txtNome.Text)); break;
                    case 3: duplo.Adicionar(new Aluno(txtRA.Text, txtNome.Text)); break;
                }
            }
            else
                MessageBox.Show("Dados inválidos. Inclusão não efetuada.");

            AtualizarDgv();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int x;
            if (Int32.TryParse(txtRA.Text, out x) && txtNome.Text != "")
            {
                switch (tipo)
                {
                    case 1: linear.Deletar(new Aluno(txtRA.Text, txtNome.Text)); break;
                    case 2: quad.Deletar(new Aluno(txtRA.Text, txtNome.Text)); break;
                    case 3: duplo.Deletar(new Aluno(txtRA.Text, txtNome.Text)); break;
                }
            }
            else
                MessageBox.Show("Dados inválidos. Inclusão não efetuada.");

            AtualizarDgv();
        }

        private void rbSondagemLinear_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
            AtualizarDgv();
        }

        private void rbSondagemQuadratica_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            AtualizarDgv();
        }

        private void rbHashingDuplo_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 3;
            AtualizarDgv();
        }
    }
}
