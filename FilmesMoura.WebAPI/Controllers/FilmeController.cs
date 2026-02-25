using FilmesMoura.WebAPI.Interfaces;
using FilmesMoura.WebAPI.Models;
using FilmesMoura.WebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmesMoura.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FilmeController : ControllerBase
{
    private readonly IFilmeRepository _filmeRepository;

    public FilmeController(IFilmeRepository filmeRepository) 
    { 
        _filmeRepository = filmeRepository; 
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        try
        {
            return Ok(_filmeRepository.BuscarPorId(id));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);

        }
    }

    [HttpGet]
    public IActionResult Get()
    {
        try
        {
            return Ok(_filmeRepository.Listar());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public IActionResult Post(Filme novoFilme) 
    {
        try
        {
            _filmeRepository.Cadastrar(novoFilme);
            return StatusCode(201);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, Filme filmeAtualizado)
    {
        try
        {
            _filmeRepository.AtualizarIdUrl(id, filmeAtualizado);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut]
    public IActionResult PutBody(Filme filmeAtualizado)
    {
        try
        {
            _filmeRepository.AtualizarIdCorpo(filmeAtualizado);
            return NoContent();
        }
        catch (Exception e)
        {

            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        try
        {
            _filmeRepository.Deletar(id);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
