using System;
using System.Windows.Forms;

class SondagemQuadratica
{
    private int tamanho;
    ListaLigada<Aluno> dados;
    public int Tamanho { get => tamanho; }

    public SondagemQuadratica(int _tamanho)
    {
        tamanho = _tamanho;
        dados = new ListaLigada<Aluno>(tamanho);
    }

    public void Adicionar(Aluno aluno)
    {
        if (aluno == null)
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

        if (dados.GetValor(pos) == null)
            dados.SetValor(aluno, pos);
        else if (dados.GetValor(pos).GetRa() == aluno.GetRa())
        {
            MessageBox.Show("RA já existente. Inclusão não efetuada");
        }
        else
        {
            Aluno al;

            for (int i = 1; i < 1111; i++)
            {
                al = dados.GetValor((pos + i*i) % dados.GetTamanho());
                if (al == null)
                {
                    dados.SetValor(aluno, (pos + i * i) % dados.GetTamanho());
                    return;
                }
                else if (al.GetRa() == aluno.GetRa())
                {
                    MessageBox.Show("RA já existente. Inclusão não efetuada");
                    return;
                }
                    
            }MessageBox.Show("Posição livre não encontrada. Inclusão não efetuada");

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

        if (dados.GetValor(pos) == null)
        {
            MessageBox.Show("RA não encontrado. Deleção não efetuada.");
            return;
        }

        if (dados.GetValor(pos).GetRa() == aluno.GetRa())
            dados.Deletar(null, pos);
        else
        {
            Aluno al;

            for (int i = 1; i<1111; i++)
            {
                al = dados.GetValor((pos + i * i) % dados.GetTamanho());
                if (al == null)
                    continue;
                if (dados.GetValor((pos + i * i) % dados.GetTamanho()).GetRa() == aluno.GetRa())
                {
                    dados.Deletar(null, (pos + i * i) % dados.GetTamanho());
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
        for (int i = 0; i < chave.Length; i++)
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