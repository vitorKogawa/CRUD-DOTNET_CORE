using CRUD_usuario.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_usuario.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //criando minha primeira rota
        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModelinput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }

        [Route("registrar")]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput)
        {
            return Created("", registroViewModelInput);
        }
    }
}
