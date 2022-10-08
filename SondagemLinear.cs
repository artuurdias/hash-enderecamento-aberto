using System;
using System.Windows.Forms;


class SondagemLinear
{
    private int tamanho;
    ListaLigada<Aluno> dados;
    public int Tamanho { get => tamanho; }

    public SondagemLinear (int _tamanho)
    {
        tamanho = _tamanho;
        dados = new ListaLigada<Aluno>(tamanho);
    }

    public void Adicionar (Aluno aluno)
    {
        if(aluno == null)
        {
            throw new Exception("Falha ao adicionar");
        }

        if (dados.IsCheio())
        {
            MessageBox.Show("Vetor está cheio. Inclusão não efetuada");
            return;
        }
                

        int pos = Hash(aluno.GetRa());

        pos = pos % dados.GetTamanho();

        if(dados.GetValor(pos) == null)
            dados.SetValor(aluno, pos);
        else if(dados.GetValor(pos).GetRa() == aluno.GetRa())
        {
            MessageBox.Show("RA já existente. Inclusão não efetuada");
        }
        else
        {
            Aluno al;

            for(int i = pos + 1; i%dados.GetTamanho() != pos; i++)
            {
                al = dados.GetValor(i % dados.GetTamanho());
                if (al == null)
                {
                    dados.SetValor(aluno, i % dados.GetTamanho());
                    return;
                }
                else if (al.GetRa() == aluno.GetRa())
                {
                    MessageBox.Show("RA já existente. Inclusão não efetuada");
                }                    
            }
            MessageBox.Show("Vetor está cheio. Inclusão não efetuada");
        }
    }

    public void Deletar(Aluno aluno)
    {
        if (aluno == null)
        {
            throw new Exception("Falha ao deletar");
        }

        if (dados.GetLength() == 0)
        {
            MessageBox.Show("Vetor está vazio. Deleção não efetuada");
            return;
        }

        int pos = Hash(aluno.GetRa());

        pos = pos % dados.GetTamanho();

        if(dados.GetValor(pos) == null)
        {
            MessageBox.Show("RA não encontrado. Deleção não efetuada.");
            return;
        }
                

        if (dados.GetValor(pos).GetRa() == aluno.GetRa())
            dados.Deletar(null, pos);
        else
        {
            Aluno al;

            for (int i = pos + 1; i % dados.GetTamanho() != pos; i++)
            {
                al = dados.GetValor(i % dados.GetTamanho());
                if(al == null)
                {
                    continue;
                }
                if (al.GetRa() == aluno.GetRa())
                {
                    dados.Deletar(null, i % dados.GetTamanho());
                    return;
                }
            }
            MessageBox.Show("RA não encontrado. Deleção não efetuada.");

        }
    }

    public int Hash(string chave)
    {
        int hash = 1;
        for (int i = 0; i < chave.Length; i++)
        {
            hash = 17 * hash * (char)chave[i];
        }
        int soma = 0;
        for(int i = 0; i<chave.Length; i++)
        {
            soma += int.Parse(chave[i].ToString());
        }
        hash *= 11 * soma;

        if (hash < 0)
            hash = -hash;

        return hash;
    }

    public int GetLength()
    {
        return dados.GetLength();
    }

    public Aluno GetValor(int pos)
    {
        return dados.GetValor(pos);
    }

    public int GetTamanho()
    {
        return dados.GetTamanho();
    }
}