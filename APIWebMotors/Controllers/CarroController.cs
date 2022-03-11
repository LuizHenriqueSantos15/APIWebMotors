using APIWebMotors.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebMotors.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        [HttpGet]
        
        public ActionResult Get()
        {
            using (var contexto = new WebMotorsContext())
            {
                var list = contexto.Carros.ToList();
                return Ok(list);
            }
        }

        [HttpGet("api/{marca}")]

        public ActionResult GetByMarca(string marca)
        {
            using (var context = new WebMotorsContext())
            {
                var List = context.Carros.Where(x => x.Marca.Equals(marca)).ToList();
                return Ok(List);
            }
        }
    }
}
