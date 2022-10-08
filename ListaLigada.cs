using System;
using System.Collections.Generic;
using System.Text;

class ListaLigada<X>
{
    class No
    {
        private No proximo;
        private X dado;
        private int pos;

        public No(No proximo, X dado, int pos)
        {
            this.proximo = proximo;
            this.dado = dado;
            this.pos = pos;
        }
        public No(int pos)
        {
            this.pos = pos;
        }

        public void SetDado(X dado)
        {
            this.dado = dado;
        }

        public X GetDados()
        {
            return dado;
        }

        public void SetProximo(No proximo)
        {
            this.proximo = proximo;
        }

        public No GetProximo()
        {
            return proximo;
        }

    }

    No[] lista;
    int tamanho;
    int quantos;

    public ListaLigada(int tamanho)
    {
        this.tamanho = tamanho;
        lista = new No[tamanho];

        for(int i = 0; i < tamanho; i++)
        {
            lista[i] = new No(i);
        }

        for (int i = 0; i < tamanho-1; i++)
        {
            lista[i].SetProximo(lista[i+1]);
        }

        lista[tamanho - 1].SetProximo(lista[0]);
    }

    public void SetValor(X dado, int pos)
    {
        if(dado == null)
        {
            throw new Exception("Dado inválido!");
        }

        lista[pos].SetDado(dado);
        quantos++;
    }

    public void Deletar(X dado, int pos)
    {
        lista[pos].SetDado(dado);
        quantos--;
    }

    public X GetValor(int pos)
    {
        return lista[pos].GetDados();
    }

    public X GetProxValor(int pos)
    {
        return lista[pos].GetProximo().GetDados();
    }

    public int GetTamanho()
    {
        return tamanho;
    }

    public int GetLength()
    {
        return quantos;
    }

    public bool IsCheio()
    {
        return quantos >= tamanho;
    }

}