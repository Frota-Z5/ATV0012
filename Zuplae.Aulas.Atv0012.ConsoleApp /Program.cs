// See https://aka.ms/new-console-template for more information

using Zuplae.Aulas.Atv0012.Models_;

Endereco endereco = new Endereco("Rua da flores", "621", "Buritis", "Jaru", "Rondonia", "76333000");
Fornecedor fornecedor = new Fornecedor("Casa da Venda", "43222333000103", endereco);
Produto produto = new Produto("Pneu", "22333", 999, fornecedor);
Console.WriteLine(produto);

// Exemplo de uso com usuario
Console.WriteLine("Digite o nome do produto:");
string nomeProduto = Console.ReadLine();
Console.WriteLine("Digite o código do produto:");
string codigoProduto = Console.ReadLine();
Console.WriteLine("Digite o preço do produto:");
decimal precoProduto = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite a razão social do fornecedor:");
string razaoSocial = Console.ReadLine();
Console.WriteLine("Digite o CNPJ do fornecedor:");
string cnpjFornecedor = Console.ReadLine();
Console.WriteLine("Digite o logradouro do endereço:");
string logradouro = Console.ReadLine();
Console.WriteLine("Digite o número do endereço:");
string numero = Console.ReadLine();
Console.WriteLine("Digite o bairro do endereço:");
string bairro = Console.ReadLine();
Console.WriteLine("Digite a cidade do endereço:");
string cidade = Console.ReadLine();
Console.WriteLine("Digite o estado do endereço:");
string estado = Console.ReadLine();
Console.WriteLine("Digite o CEP do endereço:");
string cep = Console.ReadLine();

Endereco enderecoUsuario = new Endereco(logradouro, numero, bairro, cidade, estado, cep);
Fornecedor fornecedorUsuario = new Fornecedor(razaoSocial, cnpjFornecedor, enderecoUsuario);
Produto produtoUsuario = new Produto(nomeProduto, codigoProduto, precoProduto, fornecedorUsuario);
Console.WriteLine(produtoUsuario);