using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Schema;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		IUserService _userService;

		public UsersController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result =_userService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("usercontrolıd")]
		public IActionResult UserControlId(int id)
		{
			var control = _userService.UserControlId(id);
			if (control != null)
			{
				return Ok(control);
			}
			return BadRequest(control.Message);
		}

		[HttpPost("delete")]
		public ActionResult Delete(int id)
		{
			var userControl = _userService.Delete(id);
			if (userControl.Success)
			{
				return Ok(userControl);
			}
			return BadRequest(userControl.Message);
		}




	}
}
