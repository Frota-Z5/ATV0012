namespace Zuplae.Aulas.Atv0012.Models_;

public class Produto
{
    public string nomeProduto;
    public string codigoProduto;
    public decimal precoProduto;
    List<Fornecedor>  fornecedores=new List<Fornecedor>();

    public Produto()
    {
        
    }

    public Produto(string nomeProduto, string codigoProduto, decimal precoProduto, Fornecedor fornecedor)
    {
        this.nomeProduto = nomeProduto;
        this.codigoProduto = codigoProduto;
        this.precoProduto = precoProduto;
        this.fornecedores.Add(fornecedor);
    }

    public override string ToString()
    {
        string produto = $"Nome do Produto: {nomeProduto}\n codigo do Produto: {codigoProduto}\n preço: {precoProduto}\n Fornecedores:";
        string fornecedoresInfo = "";

        foreach (var fornecedor in this.fornecedores)
        {
            fornecedoresInfo += $"{fornecedor}";
        }
        return produto + fornecedoresInfo;
    }
}