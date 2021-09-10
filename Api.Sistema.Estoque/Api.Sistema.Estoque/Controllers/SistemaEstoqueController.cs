using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Sistema.Estoque.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SistemaEstoqueController : Controller
    {
        [Route("[controller]/[action]/")]
        [HttpGet]
        public async Task<int> Index()
        {
            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/en-us/");

            return content.Length;
        }
    }
}
