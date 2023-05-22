using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Source.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureRepository());
        public IViewComponentResult Invoke()
        {
            return View(featureManager.TGetList());
        }
    }
}
