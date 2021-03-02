using Business.Abstract;
using Core.Utitilies;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public  class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccesResult();
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccesResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            var data = _userDal.GetAll();
            return new SuccessDataResult<List<User>>(data);
        }

        public IDataResult<User> GetById(int id)
        {
          var data=  _userDal.Get(p => p.Id == id);
            return new SuccessDataResult<User>(data);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccesResult();
        }
    }
}
