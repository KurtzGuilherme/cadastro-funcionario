using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace Gerenciamento.Funcionarios.CrossCutting.Validacoes;
public class ActionValidationAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var erros = context.ModelState.Values.Where(v => v.Errors.Count > 0)
                .SelectMany(v => v.Errors)
                .Select(v => v.ErrorMessage)
                .ToList();

            context.Result = new JsonResult(new
            {
                Code = HttpStatusCode.BadRequest,
                Message = "Um ou mais erros ocorreram.",
                Erros = erros
            })
            {
                StatusCode = (int)HttpStatusCode.BadRequest
            };
        }
    }
}
