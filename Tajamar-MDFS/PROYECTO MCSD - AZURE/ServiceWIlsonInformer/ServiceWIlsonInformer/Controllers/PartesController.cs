using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceWIlsonInformer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceWIlsonInformer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartesController : ControllerBase
    {
        IRepositoryPartes repo;
        public PartesController(IRepositoryPartes repo)
        {
            this.repo = repo;
        }

        [Authorize]
        [HttpPost("clear")]
        public void ClearDB() {
            repo.ClearDB();        
        }
        [Authorize]
        [HttpGet("{nparte}")]
        public ActionResult<Parte> GetParte(String nparte)
        {
            return repo.GetParte(nparte);
        }
        [Authorize]
        [HttpGet]
        public ActionResult<List<Parte>> GetPartesDB()
        {
            return repo.GetPartesDB();
        }
        [Authorize]
        [HttpPost]
        public int InsertListaPartes(List<Parte> partes)
        {
            return repo.InsertListaPartes(partes);
        }
        [Authorize]
        [HttpGet("{albaran}/{parte}")]
        public List<Parte> GetPartesDBAlbaranParte(String albaran, String parte)
        {
            return repo.GetPartesDBAlbaranParte(albaran, parte);
        }
        [Authorize]
        [HttpGet]
        [Route("entregadosengestion")]
        public List<Parte> GetPartesEntregadosEnGestion()
        {
            return repo.GetPartesEntregadosEnGestion();
        }
        [Authorize]
        [HttpGet]
        [Route("pendientes15")]
        public List<Parte> GetPartesPendientes15()
        {
            return repo.GetPartesPendientes15();
        }
        [Authorize]
        [HttpGet]
        [Route("cerrados")]
        public List<Parte> GetPartesCerrados()
        {
            return repo.GetPartesCerrados();
        }
        [Authorize]
        [HttpGet]
        [Route("cerrados/numero")]
        public int GetNumPartesCerradosSinF()
        {
            return repo.GetNumPartesCerradosSinF();
        }
        [Authorize]
        [HttpPost]
        [Route("fechas")]
        public List<Parte> GetPartesFecha(DateFinder dates)
        {
            return repo.GetPartesFecha(dates.dateTo, dates.dateFrom, dates.listafilter);
        }
        [Authorize]
        [HttpGet]
        [Route("estados")]
        public Dictionary<string, int> GetEstados()
        {
            return repo.GetEstados();
        }
        [Authorize]
        [HttpGet]
        [Route("propis")]
        public Dictionary<string, int> GetPropis()
        {
            return repo.GetPropis();
        }
        [Authorize]
        [HttpGet]
        [Route("franquicias/origen")]
        public Dictionary<string, int> GetFramquiciasOrigen()
        {
            return repo.GetFramquiciasOrigen();
        }
        [Authorize]
        [HttpGet]
        [Route("franquicias/destino")]
        public Dictionary<string, int> GetFramquiciasDestino()
        {
            return repo.GetFramquiciasDestino();
        }
        [Authorize]
        [HttpGet]
        [Route("abonados")]
        public Dictionary<string, int> GetAbonados()
        {
            return repo.GetAbonados();
        }
        [Authorize]
        [HttpPost]
        [Route("partesporfecha")]
        public Dictionary<String, int> GetPartesFechaGraphicData(List<Parte> partesFecha)
        {
            return repo.GetPartesFechaGraphicData(partesFecha);
        }
    }
}
