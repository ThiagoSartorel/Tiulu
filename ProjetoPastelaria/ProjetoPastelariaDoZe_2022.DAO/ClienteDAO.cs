using System.Data.Common;
namespace ProjetoPastelariaDoZe_2022.DAO;
using System.Data;
public class Cliente
{
    public int IdCliente { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public bool Compra_fiado { get; set; }
    public string Dia_fiado { get; set; }
    public string Senha { get; set; }
    public Cliente(int id = 0, string nome = "", string cpf = "", string telefone = "", bool compra_fiado = false, string dia_fiado = "", string senha = "")
    {
        IdCliente = id;
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Compra_fiado = compra_fiado;
        Dia_fiado = dia_fiado;
        Senha = senha;
    }
}
public class ClienteDAO
{
    /// <summary>
    /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
    /// </summary>
    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }
    public ClienteDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }
    public void InserirDbProvider(Cliente cliente)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetro (@campo e valor)
        var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
        nome.Value = cliente.Nome; comando.Parameters.Add(nome);
        var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf";
        cpf.Value = cliente.Cpf; comando.Parameters.Add(cpf);
        var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone";
        telefone.Value = cliente.Telefone; comando.Parameters.Add(telefone);
        var compra_fiado = comando.CreateParameter(); compra_fiado.ParameterName = "@compra_fiado";
        compra_fiado.Value = cliente.Compra_fiado; comando.Parameters.Add(compra_fiado);
        var dia_fiado = comando.CreateParameter(); dia_fiado.ParameterName = "@dia_fiado";
        dia_fiado.Value = cliente.Dia_fiado; comando.Parameters.Add(dia_fiado);
        var senha = comando.CreateParameter(); senha.ParameterName = "@senha";
        senha.Value = cliente.Senha; comando.Parameters.Add(senha);
        conexao.Open();
        comando.CommandText = @"INSERT INTO tb_cliente(nome, cpf, telefone, compra_fiado, dia_fiado, senha) VALUES
(@nome,@cpf,@telefone,@compra_fiado,@dia_fiado,@senha)";
        //Executa o script na conexão e retorna o número de linhas afetadas.
        var linhas = comando.ExecuteNonQuery();
        //using faz o Close() automático quando fecha o seu escopo
    }
    public DataTable SelectDbProvider(Cliente cliente)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //verifica se tem filtro
                                       //Adiciona parâmetro (@campo e valor)
        string auxSqlFiltro = " ";
        if (cliente.IdCliente > 0)
        {
            auxSqlFiltro = " WHERE id_cliente = " + cliente.IdCliente + " ";
        }

        conexao.Open();
        comando.CommandText = @"SELECT id_cliente AS ID, nome AS Nome, cpf AS CPF,
telefone AS Telefone, compra_fiado AS CompraFiado, dia_fiado AS DiaFiado, senha AS Senha FROM tb_cliente" +
         auxSqlFiltro + "ORDER BY nome;";

        //Executa o script na conexão e retorna as linhas afetadas.
        var sdr = comando.ExecuteReader();
        DataTable linhas = new();
        linhas.Load(sdr);
        return linhas;
    }

    public void ExcluirDbProvider(Cliente cliente)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetros (@campo e valor)
        var idCliente = comando.CreateParameter();
        idCliente.ParameterName = "@idCliente";
        idCliente.Value = cliente.IdCliente;
        comando.Parameters.Add(idCliente);
        conexao.Open();
        comando.CommandText = @"" +
        "DELETE FROM tb_cliente " +
        "WHERE id_cliente = @idCliente;";
        //Executa o script na conexão e retorna as linhas afetadas.
        var linhas = comando.ExecuteNonQuery();
    }

    public void EditarDbProvider(Cliente cliente)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetros (@campo e valor)
        var idCliente = comando.CreateParameter(); idCliente.ParameterName = "@idCliente";
        idCliente.Value = cliente.IdCliente; comando.Parameters.Add(idCliente);
        var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
        nome.Value = cliente.Nome; comando.Parameters.Add(nome);
        var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf";
        cpf.Value = cliente.Cpf; comando.Parameters.Add(cpf);
        var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone";
        telefone.Value = cliente.Telefone; comando.Parameters.Add(telefone);
        var compra_fiado = comando.CreateParameter(); compra_fiado.ParameterName = "@compra_fiado";
        compra_fiado.Value = cliente.Compra_fiado; comando.Parameters.Add(compra_fiado);
        var dia_fiado = comando.CreateParameter(); dia_fiado.ParameterName = "@dia_fiado";
        dia_fiado.Value = cliente.Dia_fiado; comando.Parameters.Add(dia_fiado);
        var senha = comando.CreateParameter(); senha.ParameterName = "@senha";
        senha.Value = cliente.Senha; comando.Parameters.Add(senha);
        conexao.Open();
        comando.CommandText = @"UPDATE tb_cliente " +
            "SET nome = @nome, cpf = @cpf, telefone = @telefone, senha = @senha, compra_fiado = @compra_fiado, dia_fiado = @dia_fiado " +
            "WHERE id_cliente = @idCliente;";
        //Executa o script na conexão e retorna o número de linhas afetadas.
        var linhas = comando.ExecuteNonQuery();
        //using faz o Close() automático quando fecha o seu escopo

    }
}
