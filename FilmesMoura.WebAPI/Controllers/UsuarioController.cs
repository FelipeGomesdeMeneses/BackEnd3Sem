using FilmesMoura.WebAPI.Interfaces;
using FilmesMoura.WebAPI.Models;
using FilmesMoura.WebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmesMoura.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioController(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        try
        {
            return Ok(_usuarioRepository.Listar());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        try
        {
            return Ok(_usuarioRepository.BuscarPorId(id));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);

        }
    }

    [HttpPost]
    public IActionResult Post(Usuario novoUsuario)
    {
        try
        {
            _usuarioRepository.Cadastrar(novoUsuario);
            return StatusCode(201, novoUsuario);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


}
