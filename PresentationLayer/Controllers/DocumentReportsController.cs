using LogicBusinessLayer;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class DocumentReportsController : Controller
    {
        Reports  reports = new Reports();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DateReport()
        {
            return View();
        }
        public ActionResult DateReportResult(DateTime datestart, DateTime dateend)
        {
            return View(reports.ReportByDateRange(datestart,dateend));
        }
        public ActionResult DepDestReport()
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
        public ActionResult DepDestReportResult(int? DepDest)
        {
            return View(reports.ReportByDepDest(DepDest));
        }
        public ActionResult DepOrigReport()
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
        public ActionResult DepOrigReportResult(int? DepOrig)
        {
            return View(reports.ReportByDepOrig(DepOrig));
        }
        public ActionResult UserReport()
        {
            return View();
        }
        public ActionResult UserReportResult(string user)
        {
            return View(reports.ReportByUser(user));
        }
    }
}
