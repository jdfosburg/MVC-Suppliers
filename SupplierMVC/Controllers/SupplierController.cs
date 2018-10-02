using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NORTHWNDSupplier_DAL;
using NORTHWNDSupplier_DAL.Models;
using System.Configuration;
using System.Data.SqlClient;
using SupplierMVC.Models;
using SupplierMVC.Mapping;

namespace SupplierMVC.Controllers
{
    public class SupplierController : Controller
    {
        private readonly string ConnectionString;
        private DAO Dao;


        public SupplierController()
        {
            this.ConnectionString = ConfigurationManager.ConnectionStrings["dataSource"].ConnectionString;
            Dao = new DAO(ConnectionString);
        }
    
        [HttpGet]
        public ActionResult Index()
        {
            List<Supplier> supplierInfo = new List<Supplier>();
            try
            {
                List<SupplierDO> allSuppliers = Dao.ObtainAllSuppliers();
                supplierInfo = MVCMapper.FromDoToPo(allSuppliers);
            }
            catch (Exception)
            {
                
            }

            return View(supplierInfo);
        }

        [HttpGet]
        public ActionResult CreateSupplier()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSupplier(Supplier form)
        {
            ActionResult response;

            if(ModelState.IsValid)
            {
                try
                {
                    SupplierDO newSupplier = MVCMapper.PoToDo(form);
                    Dao.CreateSupplier(newSupplier);
                    response = RedirectToAction("Index", "Supplier");
                }
                catch(SqlException sqlex)
                {
                    response = View(form);
                }
            }
            else
            {
                response = View();
            }
            return response;
        }
    }
}
