using ServiceWIlsonInformer.Data;
using ServiceWIlsonInformer.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceWIlsonInformer.Repositories
{
    public class RepositoryPartes : IRepositoryPartes
    {
        private PartesContext context;

        public RepositoryPartes(PartesContext context)
        {

            this.context = context;
        }

        public void ClearDB()
        {
            try
            {
                context.Partes.RemoveRange(GetPartesDB());
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                String mes = ex.Message;
            }
        }

        public Parte GetParte(String nparte)
        {
            try
            {
                List<Parte> partes = new List<Parte>();
               
                var consulta = from res in this.context.Partes
                                where res.N_parte == nparte
                                select res;
                return consulta.FirstOrDefault();
                

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Parte> GetPartesDB()
        {

            try
            {
                var consulta = from res in this.context.Partes
                                select res;

                return consulta.ToList();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                return null;
            }
         
        }

        public int InsertListaPartes(List<Parte> partes)
        {
            try
            {

                //EXTRAE TODOS LOS PARTES DE LA BD Y LOS BORRA
                List<Parte> partesBD = this.GetPartesDB();
                this.ClearDB();
                //LOS PARTES ANTIGUOS SE SUMAN A LOS NUEVOS, Y SI ESTAN REPETIDOS O
                //CON NUEVOS DATOS (CAMBIADOS) SE ACTUALIZAN
                try
                {
                    List<Parte> partesTotal = (List<Parte>)partesBD.Union(partes).ToList();
                    partesTotal = partesTotal.GroupBy(i => i.N_parte).Select(g => g.Last()).ToList();

                    //Converts each FAlbaran string to date
                    foreach (Parte p in partesTotal)
                    {

                        p.F_Albaran = DateTime.ParseExact(
                            p.F_AlbaranString.Replace('-', '/'), "dd/MM/yy", new CultureInfo("en-CA"));
                        p.Fecha_parte = DateTime.ParseExact(
                            p.Fecha_parteString.Replace('-', '/'), "dd/MM/yy", new CultureInfo("en-CA"));
                        try
                        {
                            if (p.Fecha_resolucionString == "" || p.Fecha_resolucionString == null)
                            {
                                p.Fecha_resolucionString = "01/01/0001";
                                p.Fecha_resolucion = default(DateTime);

                            }
                            else
                            {
                                p.Fecha_resolucion = DateTime.ParseExact(
                                p.Fecha_resolucionString.Replace('-', '/'), "dd/MM/yy", new CultureInfo("en-CA"));
                            }
                        }
                        catch (Exception ex)
                        {
                            p.Fecha_resolucionString = "01/01/0001";
                            p.Fecha_resolucion = default(DateTime);
                            
                        }

                    }

                    //SE INSERTA TODA LA LISTA TOTAL
                    context.AddRange(partesTotal);
                    context.SaveChanges();
                    return 1;
                }
                catch (Exception ex)
                {
                    
                    String message = ex.Message;
                    return 0;
                }
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                return 0;
            }
        }

        public List<Parte> GetPartesDBAlbaranParte(String albaran, String parte)
        {
            try
            {
                List<Parte> partes = new List<Parte>();
                partes = GetPartesDB();

                if (parte == null && albaran != null)
                {
                    return partes.Where(x => x.Envios.Contains(albaran)).ToList();

                }
                else if (parte != null && albaran == null)
                {
                    return partes.Where(x => x.N_parte.Contains(parte)).ToList();

                }
                else if (parte != null && albaran != null)
                {
                    return partes.Where(x => x.N_parte.Contains(parte) && x.Envios.Contains(albaran)).ToList();

                }
                else return GetPartesDB();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                return null;
            }
        }

        public List<Parte> GetPartesEntregadosEnGestion()
        {
            try
            {
                List<Parte> partes = new List<Parte>();
                partes = GetPartesDB();
                return partes.Where(res => res.Envios.Contains("Entregado") &&
                !res.Estado.Contains("Cerrada a ")).ToList();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                return null;
            }
            finally
            {
            }
        }

        public List<Parte> GetPartesPendientes15()
        {
            try
            {

                List<Parte> partes = new List<Parte>();
                partes = GetPartesDB();
                return partes.Where(x => x.F_Albaran <= DateTime.Now.AddDays(-15) &&
                !x.Estado.Contains("Cerrada a")).OrderBy(x => x.F_Albaran).ToList();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                return null;
            }
            finally
            {
            }
        }

        public List<Parte> GetPartesCerrados()
        {
            List<Parte> partes = new List<Parte>();
            partes = GetPartesDB();
            return partes.Where(x => x.Estado.Contains("Cerrada a")).ToList();
        }


        public Dictionary<string, int> GetEstados()
        {
            Dictionary<string, int> estadosCount = new Dictionary<string, int>();
            try
            {
                List<Parte> partes = new List<Parte>();
                partes = GetPartesDB();
                List<String> estados = partes.Select(x => x.Estado).Distinct().ToList();
                foreach (String est in estados)
                {
                    estadosCount.Add(est, partes.Where(x => x.Estado.Contains(est)).Count());
                }
                return estadosCount;
            }
            catch (Exception es) { return null; }
        }


        public Dictionary<string, int> GetPropis()
        {
            Dictionary<string, int> propisCount = new Dictionary<string, int>();
            try
            {
                List<Parte> partes = new List<Parte>();
                partes = GetPartesDB();
                List<String> propis = partes.Select(x => x.Propi).Distinct().ToList();
                foreach (String propi in propis)
                {
                    propisCount.Add(propi, partes.Where(x => x.Propi == propi).Count());
                }

                var sortedDict = from entry in propisCount orderby entry.Value descending select entry;
                return sortedDict.ToDictionary(t => t.Key, t => t.Value);
            }
            catch (Exception es) { return null; }

        }

        public Dictionary<string, int> GetFramquiciasOrigen()
        {
            Dictionary<string, int> fsoCount = new Dictionary<string, int>();
            List<Parte> partes = new List<Parte>();
            partes = GetPartesDB();
            try
            {
                List<String> fsorigen = partes.Select(x => x.Orig).Distinct().ToList();
                foreach (String franq in fsorigen)
                {
                    fsoCount.Add(franq, partes.Where(x => x.Orig.Contains(franq)).Count());
                }
                return fsoCount;
            }
            catch (Exception es) { return null; }
        }

        public Dictionary<string, int> GetFramquiciasDestino()
        {
            Dictionary<string, int> fsdCount = new Dictionary<string, int>();
            List<Parte> partes = new List<Parte>();
            partes = GetPartesDB();
            try
            {
                List<String> fsdestino = partes.Select(x => x.Dest).Distinct().ToList();
                foreach (String franq in fsdestino)
                {
                    fsdCount.Add(franq, partes.Where(x => x.Dest.Contains(franq)).Count());
                }
                return fsdCount;
            }
            catch (Exception es) { return null; }
        }

        public List<Parte> GetPartesFecha(DateTime dateTo, DateTime dateFrom, List<Parte> listafilter)
        {

            return listafilter.Where(x => x.F_Albaran >= dateFrom && x.F_Albaran <= dateTo).ToList();
        }
        public Dictionary<String, int> GetPartesFechaGraphicData(List<Parte> partesFecha)
        {
            try
            {
                Dictionary<string, int> diccionario = new Dictionary<string, int>();
                List<DateTime> fechas = partesFecha.Select(x => x.F_Albaran).OrderBy(x => x).Distinct().ToList();
                foreach (DateTime fecha in fechas)
                {
                    int partes = partesFecha.Where(x => x.F_Albaran == fecha).ToList().Count;
                    diccionario.Add(fecha.ToString(), partes);
                }

                return diccionario;
            }
            catch (Exception es)
            {
                return null;
            }
        }

        public Dictionary<string, int> GetAbonados()
        {
            Dictionary<string, int> abonadosCount = new Dictionary<string, int>();
            try
            {
                List<Parte> partes = new List<Parte>();
                partes = GetPartesDB();
                List<String> abonados = partes.Select(x => x.Abonado).Distinct().ToList();
                foreach (String abonado in abonados)
                {
                    if (abonado != "")
                    {
                        abonadosCount.Add(abonado, partes.Where(x => x.Abonado == abonado).Count());
                    }
                }
                var sortedDict = from entry in abonadosCount orderby entry.Value descending select entry;
                return sortedDict.ToDictionary(t => t.Key, t => t.Value); ;
            }
            catch (Exception es) { return null; }
        }

        public int GetNumPartesCerradosSinF()
        {
            List<Parte> partes = new List<Parte>();
            partes = GetPartesDB();
            return partes.Where(x => x.Estado.Contains("Cerrada a") &&
            x.Fecha_resolucion == default(DateTime)).Count();
        }

    }
}
