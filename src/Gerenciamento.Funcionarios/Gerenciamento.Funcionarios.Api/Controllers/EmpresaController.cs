using Gerenciamento.Funcionarios.Aplicacao.Interfaces;
using Gerenciamento.Funcionarios.Aplicacao.Models.Requests;
using Gerenciamento.Funcionarios.Aplicacao.Models.Responses;
using Gerenciamento.Funcionarios.Aplicacao.Mappers;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciamento.Funcionarios.Api.Controllers;

[Route("Api/v1")]
[ApiController]
public class EmpresaController : Controller
{
    private readonly IEmpresaServico _empresaServico;

    public EmpresaController(IEmpresaServico empresaServico)
    {
        _empresaServico = empresaServico;
    }

    [HttpGet]
    [Route("getEmpresa", Name = nameof(GetEmpresa))]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetEmpresa([FromQuery] Guid Id)
    {
        var empresaResponse = await _empresaServico.FindAsync(Id);

        return Ok(empresaResponse);
    }


    [HttpPost]
    [Route("addEmpresa", Name = nameof(AddEmpresa))]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> AddEmpresa([FromBody] EmpresaRequest request)
    {
        await _empresaServico.AddAsync(request);

        return Created();
    }

    [HttpDelete]
    [Route("deleteEmpresa", Name = nameof(DeleteEmpresa))]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> DeleteEmpresa([FromBody] Guid id)
    {
        await _empresaServico.DeleteAsync(id);

        return NoContent();
    }

    [HttpPatch]
    [Route("updateEmpresa/{Id:guid}", Name = nameof(UpdateEmpresa))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> UpdateEmpresa(Guid Id, JsonPatchDocument<EmpresaResponse> request)
    {
        var empresa = await _empresaServico.FindAsync(Id);

        request
            .ApplyTo(empresa);

        await _empresaServico.UpdateAsync(empresa.ToEmpresaRequest());

        return Accepted();
    }
}
