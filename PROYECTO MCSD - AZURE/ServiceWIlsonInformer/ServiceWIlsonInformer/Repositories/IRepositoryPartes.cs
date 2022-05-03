using ServiceWIlsonInformer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceWIlsonInformer
{
    public interface IRepositoryPartes
    {
        public void ClearDB();

        public Parte GetParte(String nparte);

        public List<Parte> GetPartesDB();


        public int InsertListaPartes(List<Parte> partes);
        

        public List<Parte> GetPartesDBAlbaranParte(String albaran, String parte);
        public List<Parte> GetPartesEntregadosEnGestion();
        public List<Parte> GetPartesPendientes15();
        public List<Parte> GetPartesCerrados();
        public int GetNumPartesCerradosSinF();
        public List<Parte> GetPartesFecha(DateTime dateTo, DateTime dateFrom, List<Parte> listafilter);
        public Dictionary<string, int> GetEstados();
        public Dictionary<string, int> GetPropis();
        public Dictionary<string, int> GetFramquiciasOrigen();
        public Dictionary<string, int> GetFramquiciasDestino();
        public Dictionary<string, int> GetAbonados();

        public Dictionary<String, int> GetPartesFechaGraphicData(List<Parte> partesFecha);
        
    }

}

