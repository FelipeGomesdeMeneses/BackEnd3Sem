using EventPlus.WebAPI.Interface;
using EventPlus.WebAPI.Models;

namespace EventPlus.WebAPI.Repository;

public class ComentarioEventoRepository : IComentarioEventoRepository
{
    public ComentarioEvento BuscarPorIdUsuario(Guid IdUsuario, Guid IdEvento)
    {
        throw new NotImplementedException();
    }

    public void CadastrarComentarioEvento(ComentarioEvento comentarioEvento)
    {
        throw new NotImplementedException();
    }

    public void Deletar(Guid IdComentarioEvento)
    {
        throw new NotImplementedException();
    }

    public List<ComentarioEvento> Listar(Guid IdEvento)
    {
        throw new NotImplementedException();
    }

    public List<ComentarioEvento> ListarSomenteExibe(Guid IdEvento)
    {
        throw new NotImplementedException();
    }
}
