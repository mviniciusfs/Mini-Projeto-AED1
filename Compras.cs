using System;

class Compras
{
  public static void Main (string[] args) 
  {
    public string Loja;
    public string Produto;
    public double Preco;
    public int Qtde;    
  }

  public Compras()
  {

  }

  public Compras(string pLoja, string pProduto, double pPreco, int pQtde)
  {
    Loja = pLoja;
    Produto = pProduto;
    Preco = pPreco;
    Qtde = pQtde;
  }
}