using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Context;
using Api.Entities;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class CandidatoController : Controller
    {
        // GET: api/candidato
        [HttpGet]
        //public IEnumerable<Candidato> Get()
        public Candidato[] Get()
        {
            using (var context = (EasyContext)this.HttpContext.RequestServices.GetService(typeof(EasyContext)))
            {
                return context.Candidatos.ToArray();
            }
        }

        // GET api/candidato/5
        [HttpGet("{id}")]
        public Candidato Get(int id)
        {
            using (var context = (EasyContext)this.HttpContext.RequestServices.GetService(typeof(EasyContext)))
            {
                return context.Candidatos.Include(c => c.Conhecimento).FirstOrDefault(c => c.Id == id);
            }
        }

        // POST api/candidato
        [HttpPost]
        public void Post([FromBody]Candidato candidato)
        {
            using (var context = (EasyContext)this.HttpContext.RequestServices.GetService(typeof(EasyContext)))
            {
                context.Candidatos.Add(candidato);

                context.SaveChanges();
            }
        }

        // PUT api/candidato/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Candidato candidato)
        {
            using (var context = (EasyContext)this.HttpContext.RequestServices.GetService(typeof(EasyContext)))
            {
                if (candidato != null)
                {
                    candidato.Id = id;

                    context.Update(candidato);

                    context.SaveChanges();
                }
            }
        }

        // DELETE api/candidato/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var context = (EasyContext)this.HttpContext.RequestServices.GetService(typeof(EasyContext)))
            {
                var candidato = context.Candidatos.FirstOrDefault(c => c.Id == id);

                if (candidato != null)
                {
                    context.Candidatos.Remove(candidato);

                    context.SaveChanges();
                }
            }
        }
    }
}
