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
            List<getCompanies> companiesSet = new List<getCompanies>();
            //location ln = entities.locations.SingleOrDefault(e => e.locationId == 1);
            var companies = entities.companies.Where(e => e.isActive == 1).ToList();
            //return model;
            
            foreach (var company in companies)
            {
                getCompanies CompanyDetails = new getCompanies();
                CompanyDetails.companyId = company.companyId;
                CompanyDetails.companyName = company.cname;
                CompanyDetails.condition = company.condition;
                CompanyDetails.appliedDate = company.AppliedDate != null? company.AppliedDate?.ToString("dd/MM/yyyy") :"01/01/2000";
                CompanyDetails.isInerviewScheduled = company.Scheduled;
                CompanyDetails.maxPackage = (int)company.packageMax;
                CompanyDetails.minPackage = (int)company.packageMin;
                CompanyDetails.myloaction = entities.locations.Where(p => p.locationId == company.locationId).Select(p => p.locationName).SingleOrDefault();
                CompanyDetails.subLocation = entities.locations.Where(p => p.locationId == company.locationId).Select(p => p.subLocationName).SingleOrDefault();
                CompanyDetails.tagOfIt = entities.tags.Where(p => p.tagId == company.tagId).Select(p => p.tagName).SingleOrDefault();
                companiesSet.Add(CompanyDetails);
                
            }
            return Json(companiesSet, JsonRequestBehavior.AllowGet); ;


        }

        [HttpPost]
        public int addCompany(company cn, location ln,contactPerson cp, tag tg)
        {
            myofferEntities entities = new myofferEntities();
            cn.isActive = 1;
            cn.locationId = entities.locations.Where(p => p.locationName == ln.locationName && p.subLocationName==ln.subLocationName).Select(p => p.locationId).SingleOrDefault();
            cn.tagId = entities.tags.Where(p => p.tagName == tg.tagName).Select(p => p.tagId).SingleOrDefault();
            entities.companies.Add(cn);
            entities.SaveChanges();
            //company cn2 = new company();
            cp.companyId = entities.companies.Where(p => p.cname == cn.cname).Select(p => p.companyId).SingleOrDefault();
            entities.contactPersons.Add(cp);
            entities.SaveChanges();
            return 1;
        }
    }
}
