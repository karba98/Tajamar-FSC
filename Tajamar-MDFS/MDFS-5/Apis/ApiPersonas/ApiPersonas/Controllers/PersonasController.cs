using ApiPersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        List<Persona> personas;
        public PersonasController()
        {
            personas = new List<Persona>
            {
                new Persona{IdPersona=1,Nombre="Julio",Edad=22 }
                ,new Persona{IdPersona=2,Nombre="Barto",Edad=15 }
                ,new Persona{IdPersona=3,Nombre="Javier",Edad=14 }
                ,new Persona{IdPersona=4,Nombre="Laura",Edad=32 }
                ,new Persona{IdPersona=5,Nombre="Rufino",Edad=98 }
                ,new Persona{IdPersona=6,Nombre="Anastasia",Edad=23 }
                ,new Persona{IdPersona=7,Nombre="Figueruelo",Edad=29 }
                ,new Persona{IdPersona=8,Nombre="Randal",Edad=20 }
                ,new Persona{IdPersona=9,Nombre="Frodo",Edad=72 }
                ,new Persona{IdPersona=10,Nombre="Sandra",Edad=23 }
                ,new Persona{IdPersona=11,Nombre="Julia",Edad=32 }
                ,new Persona{IdPersona=12,Nombre="Mayte",Edad=95 }
                ,new Persona{IdPersona=13,Nombre="Ramon",Edad=23 }
                ,new Persona{IdPersona=14,Nombre="Fernando",Edad=29 }
                ,new Persona{IdPersona=15,Nombre="Eustakio",Edad=27 }
                ,new Persona{IdPersona=16,Nombre="Lurdinmberto",Edad=72 }
                ,new Persona{IdPersona=17,Nombre="Soraya",Edad=23 }
            };
        }
        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            return personas;
        }
        [HttpGet("{id}")]
        public ActionResult<Persona> GetPersona(int id)
        {
            return personas.SingleOrDefault(x => x.IdPersona == id);
        }
    }
}
