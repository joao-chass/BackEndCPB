using BackendCpb.Data;
using BackendCpb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCpb.Controllers
{
    [ApiController]
    [Route("v1/noticias")]
    public class NoticiaController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Noticia>>> Get([FromServices] DataContext context)
        {
            var n = await context.Noticia.ToListAsync();
            return n;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Noticia>> Post(
            [FromServices] DataContext context,
            [FromBody]Noticia model)
        {
            if (ModelState.IsValid)
            {
                context.Noticia.Add(model);
                await context.SaveChangesAsync();
                return model;
            } else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Noticia>> GetById([FromServices] DataContext context, int id)
        {
            var product = await context.Noticia.FirstOrDefaultAsync(x => x.noticiaid == id);
            return product;
        }

        //[HttpPut]
        //[Route("{id:int}")]
        //public async Task<ActionResult<Noticia>> GetById(
        //    [FromServices] DataContext context, int id,
        //    [FromBody] Noticia model
        //    )
        //{
        //    var product = await context.Noticia.Where(x => x.noticiaid == id).Update(model);
        //    product = model;    
        //    context.SaveChangesAsync();
        //    return Ok(new { message = "Usuário ou senha inválidos" });
         
        //}
    }
}
