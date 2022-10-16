using offerDataAccess;
using offerHandlingServer.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace offerHandlingServer.Controllers
{
    public class HomeController : Controller

    {
        [HttpGet]
        public JsonResult Index()
        {
            myofferEntities entities = new myofferEntities();
            entities.Configuration.ProxyCreationEnabled = false;
            LinkedList<getCompanies> companiesSet = new LinkedList<getCompanies>();
            //location ln = entities.locations.SingleOrDefault(e => e.locationId == 1);
            var companies = entities.companies.Where(e => e.isActive == 1).ToList();
            //return model;
            getCompanies CompanyDetails = new getCompanies();
            foreach (var company in companies)
            {
                ;
                CompanyDetails.companyId = company.companyId;
                CompanyDetails.companyName = company.cname;
                CompanyDetails.condition = company.condition;
                CompanyDetails.appliedDate = company.AppliedDate != null? company.AppliedDate?.ToString("dd/MM/yyyy") :"01/01/2000";
                CompanyDetails.isInerviewScheduled = company.Scheduled;
                CompanyDetails.maxPackage = (int)company.packageMax;
                CompanyDetails.minPackage = (int)company.packageMax;
                CompanyDetails.myloaction = entities.locations.Where(p => p.locationId == company.locationId).Select(p => p.locationName).SingleOrDefault();
                CompanyDetails.subLocation = entities.locations.Where(p => p.locationId == company.locationId).Select(p => p.subLocationName).SingleOrDefault();
                CompanyDetails.tagOfIt = entities.tags.Where(p => p.tagId == company.tagId).Select(p => p.tagName).SingleOrDefault();
                companiesSet.AddFirst(CompanyDetails);
                
            }
            return Json(companiesSet, JsonRequestBehavior.AllowGet); ;


        }
    }
}
