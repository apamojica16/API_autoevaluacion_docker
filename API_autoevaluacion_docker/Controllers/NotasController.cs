using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_autoevaluacion_docker.Models;

namespace API_autoevaluacion_docker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {

        Autoevaluaciones[] notas = new Autoevaluaciones[]{
 new Autoevaluaciones{name="Lab1", nota=4.5},
 new Autoevaluaciones {name="Lab2", nota=4.0},
 new Autoevaluaciones {name="Lab3", nota=4.0},
 new Autoevaluaciones {name="Blog", nota=4.5}
        };

        [HttpGet]
         public IEnumerable<Autoevaluaciones> GetAllProducts()
         {
             return notas;
         }



        /* public Autoevaluaciones GetProduct(string id)
         {
             var snota = (notas.FirstOrDefault((p) => p.name == id));
             if (snota == null)
             {
                 throw new HttpResponseException(
                     Request.CreateResponse(HttpStatusCode.NotFound));
             }
             return snota;
         }*/

        /* public IHttpActionResult GetProduct(int id)
         {
             var product = notas.FirstOrDefault((p) => p.Id == id);
             if (product == null)
             {
                 return NotFound();
             }
             return Ok(product);
         }*/
        [HttpGet("{id}")]
          public ActionResult<Autoevaluaciones> GetById(string id)
          {
              var item = notas.FirstOrDefault(p => p.name == id);
              if (item == null)
              {
                  return NotFound();
              }
              return item;
          }


    }
}