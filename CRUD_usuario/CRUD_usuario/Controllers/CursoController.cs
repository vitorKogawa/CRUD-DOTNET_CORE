using CRUD_usuario.Model.Curso;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CRUD_usuario.Controllers
{
    [Route("api/v1/cursos")]
    [ApiController]
    //[Authorize]
    public class CursoController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post(CursoViewModelInput cursoViewModelInput)
        {
            var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            return Created("", cursoViewModelInput);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            //var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            var cursos = new List<CursoViewModelOutput>();

            cursos.Add(new CursoViewModelOutput()
            {
                //Login = codigoUsuario.ToString(),
                Login = "",
                Descricao = "teste",
                Nome = "teste"
            });

            return Ok(cursos);
        }
    }
}
