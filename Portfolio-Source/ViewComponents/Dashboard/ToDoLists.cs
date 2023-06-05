using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repository.EfRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Portfolio_Source.ViewComponents.Dashboard
{
    public class ToDoLists:ViewComponent
    {
        ToDoListManager manager = new ToDoListManager(new EfToDoListRepository());
        public IViewComponentResult Invoke()
        {
            return View(manager.TGetList());
        }
    }
}
