using TMAVerify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace TMAVerify.Controllers
{
    public class HomeController : Controller
    {
        DbBusiness _dbBusiness = new DbBusiness();
        public ActionResult Index()
        {
            _dbBusiness.SetConnectionString();
            return View();
        }
        [ActionName("CheckOP")]
        public ActionResult CheckOP(string operatorId, string programName, string functionName)
        {
            _dbBusiness.SetConnectionString();
            string result = "NG";
            string description = "";
            try
            {
                if (!_dbBusiness.CheckAuthorization(operatorId, programName, functionName))
                {
                    result = "NG";
                    description = "Ma OP nay khong co quyen";
                }
                else
                {

                    result = "OK";
                }
            }
            catch
            {
                result = "NG";
                description = "Khong the ket noi toi may chu";
            }
            return Content(result + "#" + description);
        }
    }
}