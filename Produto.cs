using System;

class Produto
{
  public static void Main (string[] args) 
  {
    public int Estoque;
    public string Nome;
    public double ValorUnit;
    public double CustoProd;
        
  }

  public Produto()
  {

  }

  public Produto(int pEstoque, string pNome, double pValorUnit, double pCustoProd)
  {
    Estoque = pEstoque;
    Nome = pNome;
    ValorUnit = pValorUnit;
    CustoProd = pCustoProd;
  }
}