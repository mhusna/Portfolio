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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void TAdd(User entity)
        {
            _userDal.Insert(entity);
        }

        public void TDelete(User entity)
        {
            _userDal.Delete(entity);
        }

        public User TGetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> TGetList()
        {
            return _userDal.GetList();
        }

        public void TUpdate(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
