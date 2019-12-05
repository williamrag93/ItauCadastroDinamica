using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnaliseCreditoItau.Models;

namespace AnaliseCreditoItau.Controllers
{
    public class ClientesController : Controller
    {
        private CadastroContext db = new CadastroContext();

        private List<object> estados = new List<object>
        {
            //lista de estados que será enviado para o formulário para ser visualizado
            new {Sigla = "AC", Nome = "Acre" },
            new {Sigla = "AL", Nome = "Alagoas" },
            new {Sigla = "AP", Nome = "Amapá" },
            new {Sigla = "AM", Nome = "Amazonas" },
            new {Sigla = "BA", Nome = "Bahia" },
            new {Sigla = "CE", Nome = "Ceará" },
            new {Sigla = "DF", Nome = "Distrito Federal" },
            new {Sigla = "ES", Nome = "Espírito Santo" },
            new {Sigla = "GO", Nome = "Goiás" },
            new {Sigla = "MA", Nome = "Maranhão" },
            new {Sigla = "MT", Nome = "Mato Grosso" },
            new {Sigla = "MS", Nome = "Mato Grosso do Sul" },
            new {Sigla = "MG", Nome = "Minas Gerais" },
            new {Sigla = "PA", Nome = "Pará" },
            new {Sigla = "PB", Nome = "Paraíba" },
            new {Sigla = "PR", Nome = "Paraná" },
            new {Sigla = "PE", Nome = "Pernambuco" },
            new {Sigla = "PI", Nome = "Piauí" },
            new {Sigla = "RJ", Nome = "Rio de Janeiro" },
            new {Sigla = "RN", Nome = "Rio Grande do Norte" },
            new {Sigla = "RS", Nome = "Rio Grande do Sul" },
            new {Sigla = "RO", Nome = "Rondônia" },
            new {Sigla = "RR", Nome = "Roraima" },
            new {Sigla = "SC", Nome = "Santa Catarina" },
            new {Sigla = "SP", Nome = "São Paulo" },
            new {Sigla = "SE", Nome = "Sergipe" },
            new {Sigla = "TO", Nome = "Tocantins" },
        };

        //Essa action irá exibir o formulário
        public ActionResult Cadastro()
        {
            ViewBag.Estados = new SelectList(estados, "Sigla", "Nome");
            return View();
        }

        //Recebe os dados do formulário e salva no banco
        [HttpPost]
        public ActionResult CadastrarCliente(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Estados = new SelectList(estados, "Sigla", "Nome");
                return View("Cadastro", cliente);
            }
            db.Clientes.Add(cliente);
            db.SaveChanges();

            return RedirectToAction("Sucesso");
        }


        // GET: Clientes
        public ActionResult Sucesso()
        {
            return View();
        }

        //Está sendo chamada via ajax para verificar se o cpf já existe.
        //aqui em baixo vai retornar dados no formato json..
        //essa action filtro no banco um cliente que possua esse cpf e retorna um valor verdadeiro ou falso caso o cliente exista ou não, se a pessoa existir.. o cpf não poderá ser usado novamente. 
        public JsonResult ValidarCPF(string cpf)
        {
            var cliente = db.Clientes.Find(cpf);
            return Json(cliente == null, JsonRequestBehavior.AllowGet);
        }
    }
}