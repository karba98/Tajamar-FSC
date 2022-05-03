using ClienteWCFCore.Models;
using ClienteWCFCore.Services;
using Microsoft.AspNetCore.Mvc;
using ServiceCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceDepartamentos;
namespace ClienteWCFCore.Controllers
{
    public class TestClientController : Controller
    {
        WCFServiceCountries service;
        WCFServiceCatastro serviceCatastro;
        WCFServiceClientes serviceClientes;
        WCF_Azure_ServiceRandomNumber serviceRNazure;
        WCF_Azure_ServiceDepartamentos servicedepts;
        WCF_Azure_ServiceDoctores servicedoctores;
        public TestClientController()
        {
            this.service = new WCFServiceCountries();
            this.serviceCatastro = new WCFServiceCatastro();
            this.serviceClientes = new WCFServiceClientes();
            this.serviceRNazure = new WCF_Azure_ServiceRandomNumber();
            this.servicedepts = new WCF_Azure_ServiceDepartamentos();
            this.servicedoctores = new WCF_Azure_ServiceDoctores();
        }
        public IActionResult CountryInfo()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CountryInfo(String isoname)
        {
            tCountryInfo country = await this.service.GetCountryInfo(isoname);
            return View(country);
        }
        public async Task<IActionResult> Provincias()
        {
            List<Provincia> provincias = await  serviceCatastro.GetProvincias();
            return View(provincias);
        }
        public async Task<IActionResult> Municipios(string nombre)
        {
            ViewBag.Provincia = nombre;
            List<String> municipios = await serviceCatastro.GerMunicipios(nombre);
            return View(municipios);
        }
        public async Task<IActionResult> Clientes()
        {
            return View(await serviceClientes.GetClientes());
        }
        public async Task<IActionResult> DetallesCliente(int id)
        {
            return View(await serviceClientes.BuscarCliente(id));
        }
        [HttpPost]
        public async Task<IActionResult> DetallesCliente(int id, bool busqueda)
        {
            return View(await serviceClientes.BuscarCliente(id));
        }
        public async Task<IActionResult> PruebaNumeroRandomAzure()
        {
            List<int> numeros = await serviceRNazure.GetRandomNumbers();
            return View(numeros);
        }
        public async Task<IActionResult> Departamentos()
        {
            List<Departamento> departamentos = await servicedepts.GetDepartamentos();
            return View(departamentos);
        }
        public async Task<IActionResult> DetailsDept(int id)
        {
            return View(await servicedepts.BuscarDept(id));
        }
        public async Task<IActionResult> Doctores()
        {
            return View(await servicedoctores.GetDoctores());
        }

    }
}
