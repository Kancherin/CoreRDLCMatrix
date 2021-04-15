using AspNetCore.Reporting;
using CoreRDLCMatrix.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRDLCMatrix.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly AdultosDAL adultosDAL = new AdultosDAL();

        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Print()
        {
            var dt = new DataTable();
            DateTime inicio = Convert.ToDateTime("2021/03/01");
            DateTime fin = DateTime.Now;
            dt = adultosDAL.AdultosUltimoContacto(inicio, fin);
            string mimetype = "";
            int extension = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\Reports\\AdultosUltimoContacto.rdlc";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("prm", "RDLC Matrix Report");
            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("dsAdultosUltimoContacto", dt);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }


    }
}
