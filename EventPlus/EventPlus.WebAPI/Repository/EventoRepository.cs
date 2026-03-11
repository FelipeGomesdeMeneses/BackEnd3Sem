using EventPlus.WebAPI.Interface;
using EventPlus.WebAPI.Models;

namespace EventPlus.WebAPI.Repository;

public class EventoRepository : IEventoRepository
{
    public void Atualizar(Guid id, Evento evento)
    {
        throw new NotImplementedException();
    }

    public Evento BuscarPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Evento evento)
    {
        throw new NotImplementedException();
    }

    public void Deletar(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Evento> Listar()
    {
        throw new NotImplementedException();
    }

    public List<Evento> ListarPorId(Guid IdUsuario)
    {
        throw new NotImplementedException();
    }

    public List<Evento> ListarProximos()
    {
        throw new NotImplementedException();
    }
}
