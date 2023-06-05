using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        ITodoListDal _toDoListDal;

        public ToDoListManager(ITodoListDal todoListDal)
        {
            _toDoListDal = todoListDal;
        }
        public void TAdd(ToDoList entity)
        {
            _toDoListDal.Insert(entity);
        }

        public void TDelete(ToDoList entity)
        {
            _toDoListDal.Delete(entity);
        }

        public ToDoList TGetById(int id)
        {
            return _toDoListDal.GetById(id);
        }

        public List<ToDoList> TGetList()
        {
            return _toDoListDal.GetList();
        }

        public void TUpdate(ToDoList entity)
        {
            _toDoListDal.Update(entity);
        }
    }
}
