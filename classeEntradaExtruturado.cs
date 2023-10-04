//essas classes deve ficar dentro da principal passada no metodo de entrada de  um swagger
public class Endereco
{
    public string Bairro { get; set; }
    public int Cep { get; set; }
    public string Cidade { get; set; }
    public string Complemento { get; set; }
    public string Estado { get; set; }
    public string Logradouro { get; set; }
    public string Numero { get; set; }
}

public class InformacoesPessoais
{
    public string DataEmissao { get; set; }
    public string DataNascimento { get; set; }
    public string DocumentoIdentificacao { get; set; }
    public string EnderecoEletronico { get; set; }
    public int EstadoCivil { get; set; }
    public int GrauInstrucao { get; set; }
    public string Nacionalidade { get; set; }
    public string Naturalidade { get; set; }
    public string Nome { get; set; }
    public string NomeConjuge { get; set; }
    public string NomeMae { get; set; }
    public string NomePai { get; set; }
    public string NumeroDocumento { get; set; }
    public string OrgaoEmissor { get; set; }
    public string Sexo { get; set; }
    public string Uf { get; set; }
    public string UfEmissor { get; set; }
}

public class Telefone
{
    public int Ddd { get; set; }
    public int Numero { get; set; }
    public int Tipo { get; set; }
}

public class IncluirDadosFormalizacaoRequest
{
    public string CodigoAdesao { get; set; }
    public Endereco Endereco { get; set; }
    public InformacoesPessoais InformacoesPessoais { get; set; }
    public int SituacaoFuncional { get; set; }
    public List<Telefone> Telefones { get; set; }
    public string ConsultaSerpro { get; set; }
    public int DevolucaoSerproPercentual { get; set; }
    public int ResultadoFaceMatchPercentual { get; set; }
    public string RetornoAnaliseDataTrust { get; set; }
    public string DocumentosPendenciados { get; set; }
    public string IdentificadorExterno { get; set; }
    public string MotivosCancelamento { get; set; }
    public string ObservacaoAnalista { get; set; }
    public string TipoRetorno { get; set; }
    public string RetornoCidadeOfensora { get; set; }
    public string RetornoClienteVulneravel { get; set; }
    public string NumeroProposta { get; set; }
}


