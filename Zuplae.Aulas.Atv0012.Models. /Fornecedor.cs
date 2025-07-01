namespace Zuplae.Aulas.Atv0012.Models_;

public class Fornecedor
{
    public string RazaoSocial;
    public string CNPJ;
    Endereco endereco;

    public Fornecedor()
    {
        
    }

    public Fornecedor(string RazaoSocial, string cnpj, Endereco endereco)
    {
      this.RazaoSocial = RazaoSocial;
      this.CNPJ = cnpj;
      this.endereco = endereco;
    }

    public override string ToString()
    {
        return $"Rua: {RazaoSocial}, {CNPJ}, {endereco}";
    }
}