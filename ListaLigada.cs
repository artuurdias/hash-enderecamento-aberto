using System;
using System.Collections.Generic;
using System.Text;

class ListaLigada<X>
{
    class No
    {
        private No proximo;
        private X dados;
        private int pos;

        public No(No prox, X dado, int _pos)
        {
            proximo = prox;
            dados = dado;
            pos = _pos;
        }
        public No(int _pos)
        {
            pos = _pos;
        }

        public void SetDados(X dado)
        {
            dados = dado;
        }

        public X GetDados()
        {
            return dados;
        }

        public void SetProximo(No prox)
        {
            proximo = prox;
        }

        public No GetProximo()
        {
            return proximo;
        }

    }

    No[] lista;
    int tamanho;
    int quantos;

    public ListaLigada(int _tamanho)
    {
        tamanho = _tamanho;
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

        lista[pos].SetDados(dado);
        quantos++;
    }

    public void Deletar(X dado, int pos)
    {
        lista[pos].SetDados(dado);
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