using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Sistema.Estoque.Controllers
{
    [ApiController]
    [Route("api/v1/SistemaEstoque/")]
    public class SistemaEstoqueController : Controller
    {
        [Route("index")]
        [HttpGet]
        public string Index()
        {
            return "Funcionou";
        }
    }
}
