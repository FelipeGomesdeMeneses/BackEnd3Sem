using EventPlus.WebAPI.BdContextEvento;
using EventPlus.WebAPI.Interface;
using EventPlus.WebAPI.Models;

namespace EventPlus.WebAPI.Repository;

public class EventoRepository : IEventoRepository
{
    private readonly EventosContext _context;

    public EventoRepository(EventosContext context)
    {
        _context = context;
    }

    public void Atualizar(Guid id, Evento evento)
    {
        var eventoBuscado = _context.Eventos.Find(id);

        if(eventoBuscado != null)
        {
            eventoBuscado.Nome = evento.Nome;
            eventoBuscado.DataEvento = evento.DataEvento;
            eventoBuscado.Descricao = evento.Descricao;
            eventoBuscado.IdTipoEvento = evento.IdTipoEvento;
            eventoBuscado.IdInstituicao = evento.IdInstituicao;
        }
        _context.SaveChanges();
    }

    public Evento BuscarPorId(Guid id)
    {
        return _context.Eventos.Find(id)!;
    }

    public void Cadastrar(Evento evento)
    {
        _context.Eventos.Add(evento);
        _context.SaveChanges();
    }

    public void Deletar(Guid id)
    {
        var eventoBuscado = _context.Eventos.Find(id);

        if(eventoBuscado != null)
        {
            _context.Eventos.Remove(eventoBuscado);
            _context.SaveChanges();
        }
    }

    public List<Evento> Listar()
    {
        return _context.Eventos.ToList();
    }

    public List<Evento> ListarPorId(Guid IdUsuario)
    {
        return _context.Eventos
            .OrderByDescending(evento => evento.IdEvento)
            .ToList();
    }

    public List<Evento> ListarProximos()
    {
        return _context.Eventos
            .Where(evento => evento.DataEvento > DateTime.Now)
            .OrderBy(evento => evento.DataEvento)
            .ToList();
    }
}
