using iclips_teste.Enum;
using iclips_teste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iclips_teste.Controllers
{
    public class HomeController : Controller
    {
        List<Pessoas> Pessoas = new List<Pessoas>
        {
            new Pessoas{ Nome = "David Koch ", Email ="david@gmail.com", Situacao = Situacao.EM_ANDAMENTO},
            new Pessoas{ Nome = "Charles Koch", Email ="koch@gmail.com", Situacao = Situacao.ATRASADO},
            new Pessoas{ Nome = "Michael Bloomberg", Email ="bloomberg@gmail.com", Situacao = Situacao.ATRASADO},
            new Pessoas{ Nome = "Larry Ellison", Email ="larry@gmail.com", Situacao = Situacao.ATRASADO},
            new Pessoas{ Nome = "Mark Zuckerberg", Email ="mark@gmail.com", Situacao = Situacao.ATRASADO},
            new Pessoas{ Nome = "Jeff Bezos", Email ="jeff@gmail.com", Situacao = Situacao.EM_ANDAMENTO},
            new Pessoas{ Nome = "Carlos Slim", Email ="carlos@gmail.com", Situacao = Situacao.EM_ANDAMENTO},
            new Pessoas{ Nome = "Warren Buffett", Email ="warren@gmail.com", Situacao = Situacao.ATRASADO},
            new Pessoas{ Nome = "Amâncio Ortega", Email ="ortega@gmail.com", Situacao = Situacao.EM_ANDAMENTO},
            new Pessoas{ Nome = "Bill Gates ", Email ="ogates@gmail.com", Situacao = Situacao.EM_ANDAMENTO},
        };

        public ActionResult Index()
        {
            ViewData["Pessoas"] = Pessoas;
            ViewData["Situacao"] = Situacao.NENHUM;
            return View();
        }

        public ActionResult EmAtendimento()
        {
            ViewData["Pessoas"] = Pessoas;
            ViewData["Situacao"] = Situacao.EM_ANDAMENTO;
            return View("Index");
        }

        public ActionResult Cancelado()
        {
            ViewData["Pessoas"] = Pessoas;
            ViewData["Situacao"] = Situacao.ATRASADO;
            return View("Index");
        }

        public ActionResult OrdenasPessoas(int value)
        {
            ViewData["Pessoas"] = Pessoas.OrderBy(x => x.Nome).ToList();
            ViewData["Situacao"] = (Situacao)System.Enum.ToObject(typeof(Situacao), value);
            return View("Partials/_ListPeople");
        }
    }
}