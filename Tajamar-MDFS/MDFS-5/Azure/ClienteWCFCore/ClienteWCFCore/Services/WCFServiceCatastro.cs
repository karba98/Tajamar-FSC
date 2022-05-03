using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ClienteWCFCore.Models;
using ServiceCatastro;

namespace ClienteWCFCore.Services
{
    public class WCFServiceCatastro
    {
        CallejerodelasedeelectrónicadelcatastroSoapClient client;
        public WCFServiceCatastro()
        {
            client = new CallejerodelasedeelectrónicadelcatastroSoapClient();
        }
        public async Task<List<Provincia>> GetProvincias()
        {
            ConsultaProvincia1 response = await client.ObtenerProvinciasAsync();
            XmlNode node = response.Provincias;
            String data = node.OuterXml;
            XDocument doc = XDocument.Parse(data);
            XNamespace nsp = "http://www.catastro.meh.es/";
            var consulta = from datos in doc.Descendants(nsp+"prov")
                           select new Provincia
                           {
                               IdProvincia = int.Parse(datos.Element(nsp+"cpine").Value),
                               Nombre = datos.Element(nsp+"np").Value
                           };
            return consulta.ToList();
        }
        public async Task<List<String>> GerMunicipios(string provincia)
        {
            ConsultaMunicipio1 response = await client.ObtenerMunicipiosAsync(provincia, null);
            XmlNode node = response.Municipios;
            String data = node.OuterXml;
            XDocument doc = XDocument.Parse(data);
            XNamespace nsp = "http://www.catastro.meh.es/";
            var consulta = from datos in doc.Descendants(nsp + "muni")
                           select datos.Element(nsp + "nm").Value;
            return consulta.ToList();
        }
    }
}
