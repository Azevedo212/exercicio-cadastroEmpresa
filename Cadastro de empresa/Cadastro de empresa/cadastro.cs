public class Cadastro
{
    public string NomeFantasia { get; set; }
    public string Cnpj { get; set; }

    public string Razao { get; set; }

    public string Regime { get; set; }
    public string Situacao { get; set; }

    public string DataAtividade { get; set; }

    public string Telefone { get; set;}

    public string Capital { get; set; }

    public string Estado { get; set;}

    public string Cidade { get; set; }

    public string Bairro { get; set; }

    public string Rua { get; set; }

    public string Tipo { get; set; }

    public string Porte { get; set; }

    public string Natureza { get; set; }

    public string NomeProprietario { get; set; }

    public string Cpf { get; set; }

    public Cadastro(string NomeFantasia, string Cnpj, string Razao, string Regime, string Situacao, string DataAtividade,
        string Telefone, string Capital, string Estado, string Cidade, string Bairro, string Rua, string Tipo, string Porte,
        string Natureza, string NomeProprietario, string Cpf) 
    { 
        this.NomeFantasia = NomeFantasia;
        this.Cnpj = Cnpj;
        this.Razao = Razao;
        this.Regime = Regime;
        this.Situacao = Situacao;
        this.DataAtividade = DataAtividade;
        this.Telefone = Telefone;
        this.Capital = Capital;
        this.Estado = Estado;
        this.Cidade = Cidade;
        this.Bairro = Bairro;
        this.Rua = Rua;
        this.Tipo = Tipo;
        this.Porte = Porte;
        this.Natureza = Natureza;
        this.NomeProprietario = NomeProprietario;
        this.Cpf = Cpf;


    }
}