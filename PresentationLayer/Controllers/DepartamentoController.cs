using EntitiesLayer;
using LogicBusinessLayer;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class DepartamentoController : Controller
    {
        DepartamentosBusiness departamentosBusiness = new DepartamentosBusiness();
        // GET: Departamento
        public ActionResult Index()
        {
            return View(departamentosBusiness.ShowDepartments());
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
        [HttpPost]
        public ActionResult Create(Departamento departamento)
        {
            try
            {
                departamento.Siglas = departamento.Siglas.ToUpper();
                departamentosBusiness.InsertDepartments(departamento);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Edit/5
        public ActionResult Edit(int? id)
        {
            return View(departamentosBusiness.FindDepartamento(id));
        }

        // POST: Departamento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Departamento departamento)
        {
            try
            {
                departamento.Siglas = departamento.Siglas.ToUpper();
                departamentosBusiness.UpDateDepartments(departamento);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Delete/5
        public ActionResult Delete(int? id)
        {
            return View(departamentosBusiness.FindDepartamento(id));
        }

        // POST: Departamento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Departamento departamento)
        {
            try
            {

                departamentosBusiness.DeleteDepartments(departamento);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
