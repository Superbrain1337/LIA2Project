using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIA2Project.Models;
using LIA2Project.Models.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace LIA2Project.Controllers
{
    public class UserController : Controller
    {
        UserDataAccessLayer objUser = new UserDataAccessLayer();

        [HttpGet]
        [Route("api/Users/Index")]
        public IEnumerable<Users> Index()
        {
            return objUser.GetAllUsers();
        }

        [HttpGet]
        [Route("api/Users/Login")]
        public bool Login([Bind("UserId")]Users usr)
        {
            var UserList = objUser.GetAllUsers();
            if (UserList.Contains(usr))
            {
                return true;
            }
            return false;
        }

        [HttpPost]
        [Route("api/Users/Create")]
        public int Create([Bind("UserId")]Users usr)
        {
            return objUser.AddUser(usr);
        }

        [HttpGet]
        [Route("api/Users/Details/{id}")]
        public Users Details(int id)
        {
            return objUser.GetUserData(id);
        }

        [HttpPut]
        [Route("api/Cases/Edit")]
        public int Edit(Users usr)
        {
            return objUser.UpdateUser(usr);
        }

        [HttpDelete]
        [Route("api/Cases/Delete/{id}")]
        public int Delete(int id)
        {
            return objUser.DeleteUser(id);
        }
    }
}