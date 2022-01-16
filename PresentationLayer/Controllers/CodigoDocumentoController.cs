using EntitiesLayer;
using LogicBusinessLayer;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class CodigoDocumentoController : Controller
    {
        CodigoDocumentoBusiness documentoBusiness = new CodigoDocumentoBusiness();
        // GET: CodigoDocumento
        public ActionResult Index()
        {
            return View(documentoBusiness.ShowDocumentsCode());
        }

        // GET: CodigoDocumento/Create
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

            ViewBag.Origen = items;
            ViewBag.Destino = items;

            return View();
        }

        // POST: CodigoDocumento/Create
        [HttpPost]
        public ActionResult Create(Codigo_Documento codigo_Documento)
        {
            try
            {
                documentoBusiness.InsertDocumentCode(codigo_Documento);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CodigoDocumento/Edit/5
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

            ViewBag.Origen = items;
            ViewBag.Destino = items;

            return View(documentoBusiness.FindCodigo(id));
        }

        // POST: CodigoDocumento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "ID,FechaDoc,UserCorreo,Departamento_Origen,Departamento_Destino,Secuencia")] Codigo_Documento codigo_Documento)
        {
            try
            {
                documentoBusiness.UpDateDocumentCode(codigo_Documento);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CodigoDocumento/Delete/5
        public ActionResult Delete(int id)
        {
            return View(documentoBusiness.FindCodigo(id));
        }

        // POST: CodigoDocumento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Codigo_Documento codigo_Documento)
        {
            try
            {
                documentoBusiness.DeleteDocumentCode(codigo_Documento);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
