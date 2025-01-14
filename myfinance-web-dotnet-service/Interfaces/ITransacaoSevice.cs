using myfinance_web_dotnet_domain.Entities;

namespace myfinance_web_dotnet_service.Interfaces
{
    public interface ITransacaoSevice
    {
        void Cadastrar(Transacao Entidade);
        void Excluir(int Id);
        List<Transacao> ListarRegistros();
        Transacao RetornarRegistro(int Id);
    }
}