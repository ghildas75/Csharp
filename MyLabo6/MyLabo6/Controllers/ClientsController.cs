using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GGPCSNETLabo6.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GGPCSNETLabo6.Controllers
{
    public class ClientsController : Controller
    {
        private IClientRepository _repository;

        public ClientsController(IClientRepository repository)
        {
            _repository = repository;
        }
        // GET: /<controller>/
        public IActionResult Index(){
            IEnumerable<Client> clientList = _repository.Clients;
            return View(clientList);
        }
        public IActionResult Create()
        {
            return View (new Client());
        }
        [HttpPost]
      public IActionResult Create (Client client)
        {
            try
            {
                _repository.InsertClient(client);
                _repository.SaveClient();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }

            return View();
        }
        public IActionResult Supprimer(int id)
        {
           _repository.deleteClient(id);
            _repository.SaveClient();
            return RedirectToAction("Index");
                }
    }
}
