using EventPlus.WebAPI.Interface;
using EventPlus.WebAPI.Models;

namespace EventPlus.WebAPI.Repository;

public class UsuarioRepository : IUsuarioRepository
{
    public Usuario BuscarEmailESenha(string Email, string Senha)
    {
        throw new NotImplementedException();
    }

    public Usuario BuscarPorId(Guid IdUsuario)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}
