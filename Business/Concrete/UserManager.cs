using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class UserManager : IUserService
	{
		IUserDal _userDal;

		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public List<OperationClaim> GetClaims(User user)
		{
			return _userDal.GetClaims(user);
		}

		public void Add(User user)
		{
			_userDal.Add(user);
		}

		public User GetByMail(string email)
		{
			return _userDal.Get(u => u.Email == email);
		}

		public User GetById(int id)
		{
			return _userDal.Get(u => u.Id == id);
		}

		public IResult UserControlId(int id)
		{
			var userControl = _userDal.Get(u => u.Id == id);
			if (userControl != null)
			{
				return new SuccessResult(Messages.UserFinded);
			}
			return new SuccessResult(Messages.UserNotFound);
		}

		public IResult Delete(int id)
		{
			var userIdControl = _userDal.Get(u => u.Id == id);
			if (userIdControl != null)
			{
				_userDal.Delete(userIdControl);
				return new SuccessResult(Messages.UserDeleted);
			}
			return new ErrorResult(Messages.UserNotFound);
		}

		public IDataResult<List<User>> GetAll()
		{
			return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
		}
	}
}

