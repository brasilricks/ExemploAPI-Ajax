using System.Collections.Generic;
using System.Web.Mvc;
using testeProg.Models;

namespace testeProg.Controllers
{
    public class HomeController : Controller
    {
        private readonly string urlLista = "https://rickandmortyapi.com/api/character";
        private readonly string urlDetales = "https://rickandmortyapi.com/api/character/";
        //private string urlBuscaGeral = "https://rickandmortyapi.com/api/character?name=" + name + "&status=" + status + "&gender=" + gender";
        
        public ActionResult Index()
        {
            var client = new System.Net.WebClient();
            Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings();
            settings.Culture = new System.Globalization.CultureInfo("pt-BR");
            var response = client.DownloadString(new System.Uri(HttpContext.Server.MapPath("~//Arquivos/ListaTiposFerramentas.json")));
            var lista = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ListaTiposFerramentasRestModel>>(response, settings);

            return View(lista);
        }

        public ActionResult ListaJS()
        {
            return View();
        }

        public ActionResult DetalhesJS(int id)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}