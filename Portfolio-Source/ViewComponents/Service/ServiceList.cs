using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Portfolio_Source.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceRepository());

        public IViewComponentResult Invoke()
        {
            return View(serviceManager.TGetList());
        }
    }
}
