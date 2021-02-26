using Business.Abstract;
using Core.Utitilies;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccesResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccesResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var data = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(data);
        }

        public IDataResult<Customer> GetById(int id)
        {
            var data = _customerDal.Get(p=>p.Id==id);
            return new SuccessDataResult<Customer>(data);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccesResult();
        }
    }
}
