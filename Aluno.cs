using System;
using System.Collections.Generic;
using System.Text;

class Aluno
{
    private string ra, nome;

    public Aluno(string ra, string nome)
    {
        this.ra = ra;
        this.nome = nome;
    }

    public Aluno(string linha)
    {
        ra = linha.Substring(0, 5);
        nome = linha.Substring(5);
    }

    public string GetRa()
    {
        return ra;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetRa(string ra)
    {
        if (ra == "" || ra == null)
            throw new Exception("RA inválido!");

        this.ra = ra;
    }

    public void SetNome(string nome)
    {
        if (nome == "" || nome == null)
            throw new Exception("Nome inválido!");

        this.nome = nome;
    }

    override public string ToString()
    {
        return ra + " " + nome;
    }
}