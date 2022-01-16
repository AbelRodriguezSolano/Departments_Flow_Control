using EntitiesLayer;
using LogicBusinessLayer;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {

        UserBusiness userBusiness = new UserBusiness();
        // GET: Usuario
        public ActionResult Index()
        {
            return View(userBusiness.ShowUser());
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            var departamentos = new DepartamentosBusiness();

            var list = departamentos.ShowDepartments();

            List<SelectListItem> items = list.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Nombre,
                    Value = a.ID.ToString(),
                    Selected = true
                };
            });

            ViewBag.items = items;

            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            try
            {
                usuario.Correo = usuario.Correo.ToLower();
                userBusiness.InsertUser(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var departamentos = new DepartamentosBusiness();

            var list = departamentos.ShowDepartments();

            List<SelectListItem> items = list.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Nombre,
                    Value = a.ID.ToString(),
                    Selected = true
                };
            });

            ViewBag.items = items;
            return View(userBusiness.FindUser(id));
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Usuario usuario)
        {
            try
            {
                usuario.Correo = usuario.Correo.ToLower();
                userBusiness.UpDateUser(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View(userBusiness.FindUser(id));
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Usuario usuario)
        {
            try
            {
                userBusiness.DeleteUser(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
