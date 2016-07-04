using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial_DDD.Domain.Entities;
using Tutorial_DDD.Infra.Data.Repositories;
using Tutorial_DDD.MVC.ViewModels;

namespace Tutorial_DDD.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteRepository _clienteRepository = new ClienteRepository();

        

        // GET: Cliente
        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRepository.GetAll());
            return View(clienteViewModel);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteRepository.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if(ModelState.IsValid)
            {
                var clienteViewModel = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteRepository.ADD(clienteViewModel);

                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteRepository.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClienteViewModel clienteViewModel)
        {
            try
            {
                var cliente = _clienteRepository.GetById(id);
                var clienteModel = Mapper.Map(clienteViewModel, cliente);

                _clienteRepository.Update(clienteModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteRepository.GetById(id);
            var clienteModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ClienteViewModel clienteViewModel)
        {
            try
            {
                var cli = _clienteRepository.GetById(id);
                _clienteRepository.Remove(cli);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
