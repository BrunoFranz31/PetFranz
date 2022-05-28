using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_3.Models;

namespace Atividade_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Serviços()
        {
            return View();
        }
        public IActionResult Agendamento()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Agendamento(criarAgendamento agendamento)
        {
            Dados.AgendaAtual.Criar(agendamento);
            return View("Feito");
        }
        public IActionResult Lista()
        {
            List<criarAgendamento> agendamentos = Dados.AgendaAtual.MostrarLista();
            return View(agendamentos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}